﻿using System;
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
            string komanda = "SELECT p.cas AS 'cas', p.opis, k.ime AS 'kraj', k1.ime AS 'kraj1', u.username, a.cena, m.ime AS 'model', z.ime AS 'znamka' FROM poti p INNER JOIN zacetnikraji zK on p.zacetniKraj=zK.id INNER JOIN kraji k ON k.id=zK.kraj_id INNER JOIN uporabniki u ON p.uporabnik_id=u.id INNER JOIN avtomobili a ON a.uporabnik_id=u.id INNER JOIN modeli m ON m.id=a.model_id INNER JOIN znamke z ON z.id=m.znamka_id INNER JOIN koncniKraji kK ON kK.id=p.koncniKraj INNER JOIN kraji k1 ON k1.id=kK.kraj_id WHERE (k.ime='"+Form2.pot+"')";

            using (MySqlConnection conn = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41906_projekt; password = salabajzer123; database = db_a41906_projekt; sslmode=none"))
            {
                conn.Open();
                using (MySqlCommand com = new MySqlCommand(komanda, conn))
                {
                    MySqlDataReader reader = com.ExecuteReader();
                    while(reader.Read())
                    {
                        izpisCasTextBox.Text = reader["cas"].ToString();
                        izpisKonecTextBox.Text = reader["kraj1"].ToString();
                        izpisModelTextBox.Text = reader["model"].ToString();
                        izpisOpisTextBox.Text = reader["opis"].ToString();
                        //izpisStrosekTextBox.Text = reader[""].ToString();
                        izpisUporabnikTextBox.Text = reader["username"].ToString();
                        izpisZacetekTextBox.Text = reader["kraj"].ToString();
                        izpisZnamkaTextBox.Text = reader["znamka"].ToString();
                    }
                        
                    
                    com.Dispose();
                }
                conn.Close();
            }
        }
    }
}
