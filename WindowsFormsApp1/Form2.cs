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
    public partial class Form2 : Form
    {
        public static string pot;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = prijavaForm.ime;
            textBox2.Text = prijavaForm.priimek;
            izberiPotComboBox();
        }

        private void izberiPotComboBox()
        {
            string komanda = "SELECT od FROM poti";

            using (MySqlConnection conn = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41906_projekt; password = salabajzer123; database = db_a41906_projekt; sslmode=none"))
            {
                conn.Open();
                using (MySqlCommand com = new MySqlCommand(komanda, conn))
                {
                    MySqlDataReader reader = com.ExecuteReader();
                    reader.Read();
                    while (reader.Read())
                    {
                        izbiraComboBox.Items.Add(reader.GetString("od"));
                    }
                    com.Dispose();
                }
                conn.Close();
            }
        }

        private void izbiraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pot = izbiraComboBox.SelectedItem.ToString();
            izpisPoti izpisPoti = new izpisPoti();
            this.Hide();
            izpisPoti.Show();
        }

        private void ustvariPotBtn_Click(object sender, EventArgs e)
        {
            ustvariPot ustvaripot = new ustvariPot();
            ustvaripot.Show();
            this.Hide();
        }
    }
}
