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
    public partial class UC_Remove : UserControl
    {
        function fn = new function();
        String query;
        public UC_Remove()
        {
            InitializeComponent();
        }

        private void UC_Remove_Load(object sender, EventArgs e)
        {
            
        }

        public void loadData() {
            query = "Select * from Items_1";
            DataSet set = fn.GetData(query);
            dataGridView1.DataSource = set.Tables[0];
        }
        private void Del_lable_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            query = "Select * from Items_1 where Name like '" + textitem.Text + "%'";
            DataSet set = fn.GetData(query);
            dataGridView1.DataSource = set.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show ("Delete item?","Important Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "Delete from Items_1 where id =" + id + "";
                fn.setData(query);
                loadData();
            }
        }
    }
}
