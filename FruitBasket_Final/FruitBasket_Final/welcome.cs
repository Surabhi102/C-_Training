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

namespace FruitBasket_Final
{
   
    public partial class welcome : Form
    {
        SqlConnection mSqlConnection;
        //SqlDataReader mSqlDataReader;
        SqlCommand mSqlCommand;
        string mStrSQlQuery;
        string mStrErrorMessage;
        public static string playername = "";
        public static string id;
        public welcome()
        {
            InitializeComponent();
            InitializeConnection();
            CenterToScreen();
        }

        private void InitializeConnection()
        {
            string strServerName = "(localdb)";
            string strInstanceName = "mssqllocaldb";
            string strDBName = "GameDB";

            string strConnectionString = string.Format(@"Data Source={0}\{1};Initial Catalog={2};Integrated Security=SSPI",
                strServerName, strInstanceName, strDBName);

            try
            {
                mSqlConnection = new SqlConnection(strConnectionString);
                
                mStrErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                mStrErrorMessage = ex.Message+"in";
            }
        }
        private void WritePlayer()
        {
            string strPlayerName = Convert.ToString(playerName.Text);
            playername = strPlayerName;

            mStrSQlQuery = $"insert into HighestScore (Name) values('{strPlayerName}')";

            try
            {
                mSqlConnection.Open();

                mSqlCommand = new SqlCommand(mStrSQlQuery, mSqlConnection);

                mSqlCommand.ExecuteNonQuery();

                mStrErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                mStrErrorMessage = ex.Message + "qq";
            }

            finally
            {
                mSqlConnection?.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new FruitBasket();
            frm.Show();
            WritePlayer();
            string strPlayerName = Convert.ToString(playerName.Text);
            playername = strPlayerName;
           

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
