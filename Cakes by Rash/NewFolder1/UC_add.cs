using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cakes_by_Rash.NewFolder1
{
    public partial class UC_add : UserControl
    {
        function fn = new function();
        String query;

     
        public UC_add()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            query = "Insert into Items_1 (id,Name,Category,Price) values('" + textBox4.Text + "','" + textBox2.Text+"', '"+comboBox1.Text + "','" + textBox3.Text + "')";
            fn.setData(query);
            ClearAll();
        }

        public void ClearAll()
        {
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            

        }

        private void panel2_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
