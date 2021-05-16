using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoJSON
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            InitUI();
        }

        private void InitUI()
        {
            CenterToScreen();

            string[] pinCodes = { "570001", "570002", "570008", "570012", "570017", 
                "570020", "570021", "570023", "570030", "570031" };

            lbPinCodes.DataSource = pinCodes;

            List<string> dates = new List<string>();
            DateTime date;
            
            for (int i = 1; i <= 10; i++)
            {
                date = DateTime.Today.AddDays(i);
                dates.Add(date.ToString("dd-MM-yyyy"));
            }
            lbDates.DataSource = dates;
        }

        private void lbPinCodes_SelectedIndexChanged(object sender, EventArgs e)
        {            
            SearchCenters();
        }

        private void lbDates_SelectedIndexChanged(object sender, EventArgs e)
        {            
            SearchCenters();
        }

       
        
        int mNoOfCentersFound = 0;
        private void DisplayCentersFound() => lblMessage.Text = $"Centers Found: {mNoOfCentersFound}";

        private async void SearchCenters()
        {
            string strPinCode = lbPinCodes.SelectedItem?.ToString();
            string strDate = lbDates.SelectedItem?.ToString();

            if (strPinCode == null || strDate == null) return;

            var sessions = await GetData(strPinCode, strDate);
            sessionBindingSource.DataSource = sessions;

            if (sessions == null || sessions.Count == 0)
                mNoOfCentersFound = 0;
            else
                mNoOfCentersFound = sessions.Count;

            DisplayCentersFound();
        }

        private async Task<List<Session>> GetData(string strPinCode,string strDate)
        {
            HttpClient client = new HttpClient();
            
            //https://cdn-api.co-vin.in/api/v2/appointment/sessions/public/findByPin?pincode=570001&date=10-05-2021
            string url = $"https://cdn-api.co-vin.in/api/v2/appointment/sessions/public/findByPin?pincode={strPinCode}&date={strDate}";

            var result = await client.GetStringAsync(url);
            var hospitalsRoot = JsonConvert.DeserializeObject<HospitalsRoot>(result);

            return hospitalsRoot.sessions; ;
        }                
    }
}
