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
    public partial class prijavaForm : Form
    {
        public static string user = "";
        public static string ime = "";
        public static string priimek = "";
        public prijavaForm()
        {
            InitializeComponent();
            passTextBox.UseSystemPasswordChar = true;
        }

        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            runLogin();
        }

        private void runLogin()
        {
            string komanda = "SELECT username, ime, priimek FROM uporabniki WHERE ((username= '" + usernameTextBox.Text + "') AND (password ='" + passTextBox.Text + "'));";
            
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
                        ime = reader["ime"].ToString();
                        priimek = reader["priimek"].ToString();
                        Form2 form2 = new Form2();
                        this.Hide();
                        form2.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napačno uporabniško ime ali geslo.", "Neuspešna prijava!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usernameTextBox.Text = "";
                        passTextBox.Text = "";
                    }
                    com.Dispose();
                }
                conn.Close();
            }

        }

        private void pokaziGesloCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pokaziGesloCheckBox.Checked == true)
            {
                passTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passTextBox.UseSystemPasswordChar = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            registracija register = new registracija();
            register.Show();
            this.Hide();
        }
    }
}
