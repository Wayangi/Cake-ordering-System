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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=E-WIS-RASH;Initial Catalog=Cake Ordering System;Integrated Security=True");
            connection.Open();
            SqlCommand cmd =  new SqlCommand("Insert into Registe_now values(@Username,@Email,@Password,@Re_Type_Password)", connection);
            cmd.Parameters.AddWithValue("@Username", textBox1.Text);
            cmd.Parameters.AddWithValue("@Email", textBox2.Text);
            cmd.Parameters.AddWithValue("@Password", textBox3.Text);
            cmd.Parameters.AddWithValue("@Re_Type_Password", textBox4.Text);
            cmd.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Registration Successful.");
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }
    }
}
