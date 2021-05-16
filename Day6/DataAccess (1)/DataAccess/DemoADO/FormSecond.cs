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

namespace DemoADO
{
    public partial class FormSecond : Form
    {
        public FormSecond()
        {
            InitializeComponent();
            CenterToScreen();

            InitializeConnection();
        }

        #region User Actions
        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadPatients();

            dgvPatients.DataSource = mDataTablePatients;

            if (mStrErrorMessage == string.Empty)
                ShowSuccessMessage();
            else
                ShowErrorMessage();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            WritePatient();

            if (mStrErrorMessage == string.Empty)
            {                
                ReadPatients();
                dgvPatients.DataSource = mDataTablePatients;
                ShowSuccessMessage();
            }
            else
                ShowErrorMessage();
        } 
        #endregion

        #region Operations

        SqlConnection mSqlConnection;
        SqlDataAdapter mSqlDataAdapter;
        DataSet mDataSetHospital;
        DataTable mDataTablePatients;

        string mStrPatientTableName= "PatientsTable";

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

        private void ReadPatients()
        {
            mStrSQlQuery = "select * from patients";
            mDataTablePatients=null;

            try
            {
                mSqlDataAdapter = new SqlDataAdapter(mStrSQlQuery, mSqlConnection);                
                mDataSetHospital = new DataSet();

                mSqlDataAdapter.Fill(mDataSetHospital, mStrPatientTableName);
                mDataTablePatients = mDataSetHospital.Tables[mStrPatientTableName];  
                
                mStrErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                mStrErrorMessage = ex.Message;
            }            
        }

        private void WritePatient()
        {
            string strPatientName = "Patient_" + DateTime.Now.Millisecond;
            try
            {
              
                SqlCommandBuilder builder = new SqlCommandBuilder(mSqlDataAdapter);
                mDataTablePatients.Rows.Add(new object[] { 0,strPatientName });
                builder.GetInsertCommand();

                mSqlDataAdapter.Update(mDataSetHospital, mStrPatientTableName);
                mStrErrorMessage = string.Empty;

            }
            catch (Exception ex)
            {
                mStrErrorMessage = ex.Message;
            }
        }

        #endregion

        #region MessageBoxes
        string mStrErrorMessage;

        private void ShowSuccessMessage() => MessageBox.Show("Operation Completed", "Success");
        private void ShowErrorMessage() => MessageBox.Show(mStrErrorMessage, "Error");
        #endregion
    }
}
