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
    public partial class izpisPoti : Form
    {
        public izpisPoti()
        {
            InitializeComponent();
        }

        private void nazajBtn_Click(object sender, EventArgs e)
        {
            Form2 izbiraPoti = new Form2();
            izbiraPoti.Show();
            this.Hide();
        }

        private void izpisPoti_Load(object sender, EventArgs e)
        {
            string komanda = "SELECT * FROM poti WHERE od = '"+ Form2.pot +"'";

            using (MySqlConnection conn = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41906_projekt; password = salabajzer123; database = db_a41906_projekt; sslmode=none"))
            {
                conn.Open();
                using (MySqlCommand com = new MySqlCommand(komanda, conn))
                {
                    MySqlDataReader reader = com.ExecuteReader();
                    reader.Read();
                    while (reader.Read())
                    {
                        
                    }
                    com.Dispose();
                }
                conn.Close();
            }
        }
    }
}
