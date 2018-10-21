using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class vnesiKraj : Form
    {
        public vnesiKraj()
        {
            InitializeComponent();
        }

        private void vnesiButton_Click(object sender, EventArgs e)
        {
            string komanda = "INSERT INTO kraji (ime) VALUES ('" + imeKrajaTextBox.Text +"');";


            using (MySqlConnection conn = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41906_projekt; password = salabajzer123; database = db_a41906_projekt; sslmode=none"))
            {
                conn.Open();
                using (MySqlCommand com = new MySqlCommand(komanda, conn))
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show("Kraj vnesen.","Vnos");
                    com.Dispose();
                }
                conn.Close();
            }
            imeKrajaTextBox.Text = "";
        }

        private void vnesiKraj_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nazajButton_Click(object sender, EventArgs e)
        {
            ustvariPot ustvariPot = new ustvariPot();
            this.Hide();
            ustvariPot.Show();
        }

        private void izbrisKrajaButton_Click(object sender, EventArgs e)
        {
            izbrisKraja izbrisKraja = new izbrisKraja();
            this.Hide();
            izbrisKraja.Show();
        }

        private void vnesiKraj_Load(object sender, EventArgs e)
        {
            if(prijavaForm.rank==10)
            {
                izbrisKrajaButton.Visible = true;
            }
            else
            {
                izbrisKrajaButton.Visible = false;
            }
        }
    }
}
