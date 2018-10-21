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
    public partial class izbrisKraja : Form
    {
        public izbrisKraja()
        {
            InitializeComponent();
        }

        private void izbrisKraja_Load(object sender, EventArgs e)
        {
            string komanda = "SELECT * FROM Kraji";

            using (MySqlConnection conn = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41906_projekt; password = salabajzer123; database = db_a41906_projekt; sslmode=none"))
            {
                conn.Open();
                using (MySqlCommand com = new MySqlCommand(komanda, conn))
                {
                    MySqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        izbrisKrajaComboBox.Items.Add(reader.GetString("ime"));
                    }
                    com.Dispose();
                }
                conn.Close();
            }
        }

        private void izbrisiKrajBtn_Click(object sender, EventArgs e)
        {
            string izbris = izbrisKrajaComboBox.SelectedItem.ToString();
            string komanda = "DELETE FROM kraji WHERE (ime='"+izbris+"')";

            try
            {
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
                MessageBox.Show("Kraj izbrisan", "izbris", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                izbrisKrajaComboBox.ResetText();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void izbrisKraja_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nazajBtn_Click(object sender, EventArgs e)
        {
            vnesiKraj vnesiKraj = new vnesiKraj();
            this.Hide();
            vnesiKraj.Show();
        }
    }
}
