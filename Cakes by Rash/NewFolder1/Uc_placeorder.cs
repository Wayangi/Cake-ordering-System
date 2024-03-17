using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cakes_by_Rash.NewFolder1
{
    public partial class Uc_placeorder : UserControl
    {

        function fn = new function();
        String query;
        int n, gettotal = 0;
        int amount;
        public Uc_placeorder()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            } 
            catch
            {

            }
            gettotal -= amount;
            label_totalAmount.Text = "Rs. " + gettotal;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String category = comboBox1.Text;
            query = "select Name from Items_1 where Category ='" + category + "'";
            DataSet dT = fn.GetData(query);

            for (int i = 0; i < dT.Tables[0].Rows.Count; i++)

            {

                listBox1.Items.Add(dT.Tables[0].Rows[i][0].ToString());
            }




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantityUpDown.ResetText();
            textTotal.Clear();

            
            String txt = listBox1.GetItemText(listBox1.SelectedItem);
            textItem.Text = txt;

            query = "Select Price from Items_1 where Name = '" + txt + "'";
            DataSet set = fn.GetData(query);
            try
            {
                textPrice.Text = set.Tables[0].Rows[0][0].ToString();
                textID.Text = set.Tables[0].Rows[0][0].ToString();
            }
            catch
            {

            }


            query = "Select id from Items_1 where Name = '" + txt + "'";
            DataSet set_1 = fn.GetData(query);
            try
            {
                textID.Text = set_1.Tables[0].Rows[0][0].ToString();
            }
            catch
            {

            }
        }

        private void quantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quantity = Int64.Parse(quantityUpDown.Value.ToString());
            Int64 price = Int64.Parse(textPrice.Text);
            textTotal.Text = (quantity * price).ToString();

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (textItem.Text == "" && quantityUpDown.Text == "")
            {
                MessageBox.Show("Please update Item Name and quantity! ");
            }
            else
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 385, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }

            }
        }

        private void label_totalAmount_Click(object sender, EventArgs e)
        {

        }
        int unitPrice, Quantity, TotalPrice, POS = 60;

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        String ItemName;
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            e.Graphics.DrawString("  ", new Font("Constantia", 12, FontStyle.Bold), Brushes.Black, new Point(80));
            e.Graphics.DrawString("        Cakes By Rash ", new Font("Constantia", 12, FontStyle.Bold), Brushes.Purple, new Point(90));
            e.Graphics.DrawString("   Item Name            Unit Price      Quantity     Total Price", new Font("Constantia", 10, FontStyle.Regular), Brushes.Black, new Point(26, 40));
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                ItemName = "" + row.Cells["Column1"].Value;
                unitPrice = Convert.ToInt32(row.Cells["Column2"].Value);
                Quantity = Convert.ToInt32(row.Cells["Column3"].Value);
                TotalPrice = Convert.ToInt32(row.Cells["Column4"].Value);

                e.Graphics.DrawString("" + ItemName, new Font("Constantia", 8, FontStyle.Bold), Brushes.Blue, new Point(35, POS));
                e.Graphics.DrawString("                " + unitPrice, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, new Point(110, POS));
                e.Graphics.DrawString("                      " + Quantity, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, new Point(190, POS));
                e.Graphics.DrawString("                              " + TotalPrice, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, new Point(225, POS));
                POS = POS + 20;
            }
            e.Graphics.DrawString("          Your Total: Rs." + gettotal, new Font("Arial", 12, FontStyle.Bold), Brushes.Maroon, new Point(60, POS + 50));
            e.Graphics.DrawString("                      __Cakes By Rash__", new Font("Constantia", 10, FontStyle.Bold), Brushes.DarkBlue, new Point(40, POS + 85));
            e.Graphics.DrawString("                            Thank You", new Font("Constantia", 10, FontStyle.Bold), Brushes.DarkBlue, new Point(40, POS + 105));
            e.Graphics.DrawString("                         Visit Us Again !", new Font("Constantia", 10, FontStyle.Bold), Brushes.DarkBlue, new Point(40, POS + 125));
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            POS = 100;
            gettotal = 0;
        }

        private void Uc_placeorder_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textTotal.Text != "0" && textTotal.Text != "")
            {
                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = textID.Text;
                dataGridView1.Rows[n].Cells[1].Value = textItem.Text;
                dataGridView1.Rows[n].Cells[2].Value = textPrice.Text;
                dataGridView1.Rows[n].Cells[3].Value = quantityUpDown.Value;
                dataGridView1.Rows[n].Cells[4].Value = textTotal.Text;

                gettotal += int.Parse(textTotal.Text);
                label_totalAmount.Text = "Rs. " + gettotal;
            }
            else
            {
                MessageBox.Show("Minimum quantity need to be 1","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
