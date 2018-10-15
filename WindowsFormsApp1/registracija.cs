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
    public partial class registracija : Form
    {
        public registracija()
        {
            InitializeComponent();
        }

        private void registracija_Load(object sender, EventArgs e)
        {
            znamkaComboBox();
        }

        private void znamkaComboBox()
        {
            string komanda = "SELECT * FROM znamke";

            using (MySqlConnection conn = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41906_projekt; password = salabajzer123; database = db_a41906_projekt; sslmode=none"))
            {
                conn.Open();
                using (MySqlCommand com = new MySqlCommand(komanda, conn))
                {
                    MySqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        regZnamkaComboBox.Items.Add(reader["ime"].ToString());
                    }
                    com.Dispose();
                }
                conn.Close();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            double cena = Convert.ToDouble(regCenaTextBox.Text);
            int letnik = Convert.ToInt32(regLetnikTextBox.Text);
            double moc = Convert.ToDouble(regMocTextBox.Text);
            int kubiki = Convert.ToInt32(regKubikiTextBox.Text);
            double prevozeni = Convert.ToDouble(regPrevozeniTextBox.Text);
            double poraba = Convert.ToDouble(regPorabaTextBox.Text);

            string model = regModelComboBox.SelectedItem.ToString();

            string comanda = "INSERT INTO avtomobili (cena, letnik, moc, kubiki, prevozeni, poraba, model_id) VALUES ('" + cena + "','" + letnik + "', '" + moc + "', '" + kubiki + "', '"+ prevozeni +"', '"+ poraba +"', (SELECT id FROM modeli WHERE ime='"+ model +"'))";

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

            string ime = regImeTextBox.Text;
            string priimek = regPriimekTextBox.Text;
            string username = regUsernameTextBox.Text;
            string password = regPassTextBox.Text;

            string komanda = "INSERT INTO uporabniki (ime, priimek, username, password, avtomobil_id) VALUES ('" + ime + "','" + priimek + "','" + username + "','" + password + "', (SELECT id FROM avtomobili WHERE cena=" + cena + ")";

            using (MySqlConnection conn = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41906_projekt; password = salabajzer123; database = db_a41906_projekt; sslmode=none"))
            {
                conn.Open();
                using (MySqlCommand com = new MySqlCommand(komanda, conn))
                {
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                conn.Close();
            }
        }

        private void regZnamkaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            regModelComboBox.Items.Clear();
            string znamka = regZnamkaComboBox.SelectedItem.ToString();

            string komanda = "SELECT m.ime FROM modeli m INNER JOIN znamke z ON z.id=m.znamka_id WHERE z.ime = '" + znamka + "' ";

            using (MySqlConnection conn = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41906_projekt; password = salabajzer123; database = db_a41906_projekt; sslmode=none"))
            {
                conn.Open();
                using (MySqlCommand com = new MySqlCommand(komanda, conn))
                {
                    MySqlDataReader reader = com.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        regModelComboBox.Items.Add(reader["ime"].ToString());
                    }
                    com.Dispose();
                }
                conn.Close();
            }
        }

        private void registracija_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
