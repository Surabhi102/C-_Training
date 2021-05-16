using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DemoADO
{
    public partial class FormMain : Form
    {              
        public FormMain()
        {
            InitializeComponent();
            CenterToScreen();

            InitializeConnection();
        }

        #region User Actions       

        private void btnRead_Click(object sender, EventArgs e)
        {           
            
            lbPatientNames.DataSource = ReadPatientNames();

            if (mStrErrorMessage == string.Empty)
                ShowSuccessMessage();
            else
                ShowErrorMessage();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {           
            WritePatient();

            if (mStrErrorMessage == string.Empty)
                ShowSuccessMessage();
            else
                ShowErrorMessage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form form = new FormSecond();
            form.Show();
        }
        #endregion

        #region MessageBoxes
        string mStrErrorMessage;

        private void ShowSuccessMessage() => MessageBox.Show("Operation Completed", "Success");

        private void ShowErrorMessage() => MessageBox.Show(mStrErrorMessage, "Error");

        #endregion

        #region Operations

        SqlConnection mSqlConnection;
        SqlDataReader mSqlDataReader;
        SqlCommand mSqlCommand;
        string mStrSQlQuery;

        private void InitializeConnection()
        {
            string strServerName = "(localdb)";
            string strInstanceName = "mssqllocaldb";
            string strDBName = "HospitalDB";

            string strConnectionString = string.Format(@"Data Source={0}\{1};Initial Catalog={2};Integrated Security=SSPI",
                strServerName, strInstanceName, strDBName);

            try
            {
                mSqlConnection = new SqlConnection(strConnectionString);
                mStrErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                mStrErrorMessage = ex.Message;                
            }
        }      

        private List<string> ReadPatientNames()
        {            
            mStrSQlQuery = "select * from patients";
            List<string> patientNames = new List<string>();

            try
            {
                mSqlConnection.Open();
                mSqlCommand = new SqlCommand(mStrSQlQuery, mSqlConnection);
                mSqlDataReader = mSqlCommand.ExecuteReader();

                while (mSqlDataReader.Read())
                {
                    patientNames.Add(mSqlDataReader[1].ToString());
                }
                mStrErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                mStrErrorMessage = ex.Message;
            }

            finally
            {
                mSqlDataReader?.Close();
                mSqlConnection?.Close();
            }

            return patientNames;
        }

        private void WritePatient()
        {
            string strPatientName = "Patient_" + DateTime.Now.Millisecond;

            mStrSQlQuery = $"insert into patients (name) values('{strPatientName}')";

            try
            {
                mSqlConnection.Open();
                mSqlCommand = new SqlCommand(mStrSQlQuery, mSqlConnection);
                mSqlCommand.ExecuteNonQuery();                
                mStrErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                mStrErrorMessage = ex.Message;
            }

            finally
            {
                mSqlConnection?.Close();
            }
        }

        #endregion       
    }
}
