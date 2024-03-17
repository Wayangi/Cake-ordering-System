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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        public Form3(String user)
        {
            InitializeComponent();

            if(user == "Guest")
            {
                btnadd.Hide();
                btnupdate.Hide();
                btnremove.Hide();

            }
            else if (user=="login_user")
            {
                btnadd.Show();
               btnupdate.Show();
                btnremove.Show();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenu1.Visible = true;
            mainMenu1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uc_placeorder1.Visible = true;
            uc_placeorder1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uC_add1.Visible = true;
            uC_add1.BringToFront();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            mainMenu1.Visible = false;
            uC_add1.Visible = false;
            uc_placeorder1.Visible = false;
            uC_Udate2.Visible = false;
            uC_Remove1.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            uC_Udate2.Visible = true;
            uC_Udate2.BringToFront();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            uC_Remove1.Visible = true;
            uC_Remove1.BringToFront();
        }
    }
}
