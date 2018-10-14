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
            string komanda = "SELECT p.od, p.do, p.cas, p.opis, p.strosek, u.username, m.ime, z.ime FROM potip INNER JOIN uporabniki u ON u.id=p.uporabnik_id INNER JOIN avtomobili a ON a.id=u.avtomobil_id INNER JOIN modeli m ON m.id=a.model_id INNER JOIN znamke z ON z.id=m.znamka_id WHERE od = '"+ Form2.pot +"'";

            using (MySqlConnection conn = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41906_projekt; password = salabajzer123; database = db_a41906_projekt; sslmode=none"))
            {
                conn.Open();
                using (MySqlCommand com = new MySqlCommand(komanda, conn))
                {
                    MySqlDataReader reader = com.ExecuteReader();
                    reader.Read();
                        izpisCasTextBox.Text = reader["p.cas"].ToString();
                        izpisKonecTextBox.Text = reader["p.do"].ToString();
                        izpisModelTextBox.Text = reader["m.ime"].ToString();
                        izpisOpisTextBox.Text = reader["p.opis"].ToString();
                        izpisStrosekTextBox.Text = reader["p.strosek"].ToString();
                        izpisUporabnikTextBox.Text = reader["u.username"].ToString();
                        izpisZacetekTextBox.Text = reader["p.od"].ToString();
                        izpisZnamkaTextBox.Text = reader["z.ime"].ToString();
                    
                    com.Dispose();
                }
                conn.Close();
            }
        }
    }
}
