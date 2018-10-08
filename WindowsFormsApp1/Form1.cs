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
    public partial class Form1 : Form
    {
        public static string user = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            runLogin();
        }

        private void runLogin()
        {
            string komanda = "SELECT username FROM uporabniki WHERE ((username= '" + usernameTextBox.Text + "') AND (pass ='" + passTextBox.Text + "'));";
            /*   string selekt = "SELECT username, pass FROM uporabniki";
               string mySQLConnectionString = "datasource=mysql6001.site4now.net;username=a41906_projekt;password=salabajzer123;database=uporabniki";

               MySqlConnection con = new MySqlConnection(mySQLConnectionString);
               MySqlCommand com = new MySqlCommand(selekt, con);

               con.Open();
               MySqlDataReader reader = com.ExecuteReader();*/

            using (MySqlConnection conn = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41906_projekt; password = salabajzer123; database = db_a41906_projekt; sslmode=none"))
            {
                conn.Open();
                using (MySqlCommand com = new MySqlCommand(komanda, conn))
                {
                    MySqlDataReader reader = com.ExecuteReader();
                    reader.Read();
                    try
                    {
                        user = reader["username"].ToString();
                        MessageBox.Show("prijava uspesna");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napačno uporabniško ime ali geslo.", "Neuspešna prijava!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    com.Dispose();
                }
                conn.Close();
            }

        }
    }
}
