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

namespace Cakes_by_Rash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection(@"Data Source=E-WIS-RASH;Initial Catalog=Cake Ordering System;Integrated Security=True");
            connection.Open();

       
           SqlCommand cmd = new SqlCommand("Select * from Registe_now where Username='" + username.Text + "' and Password ='" + password.Text + "'", connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlData.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                Form3 dashboard = new Form3();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 fm = new Form3("Guest");
            fm.Show();
            this.Hide();
        }

    }


    }

