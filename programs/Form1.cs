using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
            string strServerName = "(localdb)";
            string strInstanceName = "mssqllocaldb";
            string strDBName = "HospitalDB";

            string strConnectionString = string.Format(@"Data Source={0}\{1};Initial Catalog={2};Integrated Security=SSPI",
           strServerName, strInstanceName, strDBName);

            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(strConnectionString);

            //try
            //{
            //    sqlConnection.Open();
            //    MessageBox.Show("Opened Connection", "Success");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}

            SqlCommand sqlCommand;
            string strSqlString;
            strSqlString = "select * from patients";
            sqlCommand = new SqlCommand(strSqlString, sqlConnection);
            SqlDataReader sqlDataReader;
            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    MessageBox.Show(sqlDataReader[1].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection?.Close();
                
            }
            

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {

        }
    }
}
