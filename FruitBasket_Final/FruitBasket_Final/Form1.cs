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
    public partial class FruitBasket : Form
    {
        int score = 0;
        int speed = 8;
        Random randY = new Random();
        Random randX = new Random();
        SqlCommand mSqlCommand;
        SqlConnection mSqlConnection;
        string mStrSQlQuery;
        string mStrErrorMessage;
        public static string playername = "";
        public FruitBasket()
        {
            InitializeComponent();
            InitializeConnection();
        }

        private void restart()
        {
            pip.Left = randX.Next(5, 818 - pip.Width);
            pip.Top = 35 * -1;
            app.Left = randX.Next(5, 818 - app.Width);
            app.Top = 35 * -1;
            brin.Left = randX.Next(5, 818 - brin.Width);
            brin.Top = 35 * -1;

            score = 0;
            speed = 8;
            timer1.Start();
        }
        private void FruitBasket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (bowl.Left > 0)
                {
                    bowl.Left -= 10;
                }

            }
            if (e.KeyCode == Keys.Right)
            {
                if (bowl.Left < 480)
                {
                    bowl.Left += 10;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sc.Text = "Scores:" + score;
            pname.Text = "Hi, "+welcome.playername;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "fruits" || (string)x.Tag == "veg")
                {
                    x.Top += speed;
                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        x.Top = randY.Next(80, 300) * -1;
                        x.Left = randX.Next(10, this.ClientSize.Width - x.Width);
                    }

                    if (x.Top > 600)
                    {
                        x.Top = 35 * -1;
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                    }

                    if (bowl.Bounds.IntersectsWith(x.Bounds) && (string)x.Tag == "fruits")
                    {
                        score += 1;
                        x.Top = 35 * -1;
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                    }
                    if (bowl.Bounds.IntersectsWith(x.Bounds) && (string)x.Tag == "veg")
                    {
                        //x.Visible = false;
                        timer1.Stop();
                        MessageBox.Show("GameOver!!");
                        restart();
                        Update();

                    }


                }
            }


        }

        private void bowl_Click(object sender, EventArgs e)
        {

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
                mStrErrorMessage = ex.Message + "in";
            }
        }
        private void Update()
        {
            mStrSQlQuery = $"update HighestScore set Name = '{welcome.playername}',Score=score where Name = '{welcome.playername}' ";

            try
            {
                mSqlConnection.Open();

                mSqlCommand = new SqlCommand(mStrSQlQuery, mSqlConnection);

                mSqlCommand.ExecuteNonQuery();

                mStrErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                mStrErrorMessage = ex.Message ;
            }

            finally
            {
                mSqlConnection?.Close();
            }
        }
    }
}
