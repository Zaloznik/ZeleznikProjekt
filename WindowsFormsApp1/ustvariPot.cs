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
    public partial class ustvariPot : Form
    {
        public ustvariPot()
        {
            InitializeComponent();
        }

        private void ustvariPotBtn_Click(object sender, EventArgs e)
        {
            string comanda = "INSERT INTO poti (od, do, cas, opis, strosek, uporabnik_id) VALUES ('" + zacetekTextBox.Text + "','" + konecTextBox.Text + "', '" + casTextBox.Text + "', '" + opisTextBox.Text + "', '" + strosekTextBox.Text + "', (SELECT id FROM uporabniki WHERE username='" + prijavaForm.user + "'))";
            
            try
            {
                using (MySqlConnection conn = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41906_projekt; password = salabajzer123; database = db_a41906_projekt; sslmode=none"))
                {
                    conn.Open();
                    using (MySqlCommand com = new MySqlCommand(comanda, conn))
                    {
                        com.ExecuteNonQuery();
                        com.Dispose();
                    }
                    conn.Close();
                }
                MessageBox.Show("pot vstavljena uspešno!");
                zacetekTextBox.Text = "";
                konecTextBox.Text = "";
                casTextBox.Text = "";
                opisTextBox.Text = "";
                strosekTextBox.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nazajBtn_Click(object sender, EventArgs e)
        {
            Form2 izbiraForm = new Form2();
            izbiraForm.Show();
            this.Hide();
        }

        private void ustvariPot_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
