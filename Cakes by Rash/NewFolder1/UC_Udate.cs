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
    public partial class UC_Udate : UserControl
    {
        function fn = new function();
        String query;
        public UC_Udate()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void UC_Udate_Load(object sender, EventArgs e)
        {
           
            loadData();

        }

        public void loadData()
        {
            query = "Select * from Items_1";
            DataSet set = fn.GetData(query);
            dataGridView1.DataSource = set.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = "Update Items_1 set name = '" + textitem.Text + "',category= '" + textCategory.Text + "', Price =" + textPrice.Text + " where id =" + id + "";
            fn.setData(query);
            loadData();

            textitem.Clear();
            textCategory.Clear();
            textPrice.Clear();
            textBox1.Clear();
        }

        
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "Select * from Items_1 where Name like '" + textBox1.Text + "%'";
            DataSet set = fn.GetData(query);
            dataGridView1.DataSource = set.Tables[0];
            
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            textCategory.Text = category;
            textitem.Text = name;
            textPrice.Text = price.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void textitem_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
