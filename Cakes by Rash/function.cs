using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Cakes_by_Rash
{
    class function
    {
        protected SqlConnection GetConnection()
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=E-WIS-RASH;database =Cake Ordering System;Integrated Security=True";
            return connection;
        }



        public DataSet GetData(String query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = query;
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataSet dT = new DataSet();
            sqlData.Fill(dT);
            return dT;
        }
        public void setData(String query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Data Proceeded Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }




}
