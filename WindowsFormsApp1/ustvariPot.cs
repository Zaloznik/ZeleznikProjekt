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
            int zacKraj_id = 69;
            int koncKraj_id = 69;
            string zacKraj = zacetniKrajComboBox.SelectedItem.ToString();
            string komanda = "INSERT INTO zacetniKraji (kraj_id) VALUES ((SELECT id FROM kraji WHERE (ime='"+zacKraj+"'))); SELECT last_insert_id();";

            try
            {
                using (MySqlConnection conn = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41906_projekt; password = salabajzer123; database = db_a41906_projekt; sslmode=none"))
                {
                    conn.Open();
                    using (MySqlCommand com = new MySqlCommand(komanda, conn))
                    {
                        zacKraj_id = Convert.ToInt32(com.ExecuteScalar());
                        
                        com.Dispose();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }

            //-------------------------------------------------------------------------------------------------

            string koncKraj = koncniKrajComboBox.SelectedItem.ToString();
            string komanda1 = "INSERT INTO koncniKraji (kraj_id) VALUES ((SELECT id FROM kraji WHERE (ime='" + koncKraj + "'))); SELECT last_insert_id();";

            try
            {
                using (MySqlConnection conn = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41906_projekt; password = salabajzer123; database = db_a41906_projekt; sslmode=none"))
                {
                    conn.Open();
                    using (MySqlCommand com = new MySqlCommand(komanda1, conn))
                    {
                        koncKraj_id = Convert.ToInt32(com.ExecuteScalar());
                        
                        com.Dispose();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //-------------------------------------------------------------------------------------------------

            string comanda = "INSERT INTO poti (zacetniKraj, koncniKraj, cas, opis, uporabnik_id) VALUES ("+ zacKraj_id +", "+ koncKraj_id +",'" + casTextBox.Text + "', '" + opisTextBox.Text + "', (SELECT id FROM uporabniki WHERE username='" + prijavaForm.user + "'))";
            
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
                casTextBox.Text = "";
                opisTextBox.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            zacetniKrajComboBox.ResetText();
            koncniKrajComboBox.ResetText();
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

        private void ustvariPot_Load(object sender, EventArgs e)
        {
            string komanda = "SELECT * FROM kraji";

            using (MySqlConnection conn = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41906_projekt; password = salabajzer123; database = db_a41906_projekt; sslmode=none"))
            {
                conn.Open();
                using (MySqlCommand com = new MySqlCommand(komanda, conn))
                {
                    MySqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        zacetniKrajComboBox.Items.Add(reader["ime"].ToString());
                        koncniKrajComboBox.Items.Add(reader["ime"].ToString());
                    }
                    com.Dispose();
                }
                conn.Close();
            }
        }

        private void krajButton_Click(object sender, EventArgs e)
        {
            vnesiKraj vnesiKraj = new vnesiKraj();
            this.Hide();
            vnesiKraj.Show();
        }
    }
}
