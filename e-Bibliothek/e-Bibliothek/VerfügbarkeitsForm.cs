using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Bibliothek
{
    public partial class VerfügbarkeitsForm : Form
    {
        public VerfügbarkeitsForm()
        {
            InitializeComponent();
        }

        private void VerfügbarkeitsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lobbyMA lma = new lobbyMA();
            lma.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\timos\Source\Repos\eBibliothek2\e-Bibliothek\e-Bibliothek\Database1.mdf;Integrated Security=True";


            try
            {
                scn.Open();

                SqlCommand scmdB = new SqlCommand("UPDATE Bücher SET verfügbarkeit = @vbk WHERE  titel=@ttl", scn);
                SqlCommand scmdDVDs = new SqlCommand("UPDATE Bücher SET verfügbarkeit = @vbk WHERE  titel=@ttl", scn);
                SqlCommand scmdKS = new SqlCommand("UPDATE Bücher SET verfügbarkeit = @vbk WHERE  titel=@ttl", scn);
                SqlCommand scmdZ = new SqlCommand("UPDATE Bücher SET verfügbarkeit = @vbk WHERE  titel=@ttl", scn);
                switch (comboBoxVerfügbarkeit.Text)
                {
                    case "reserviert":
                        scmdB.Parameters.Clear();
                        scmdB.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdB.Parameters.AddWithValue("@vbk", '1');

                        scmdZ.Parameters.Clear();
                        scmdZ.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdZ.Parameters.AddWithValue("@vbk", '1');

                        scmdDVDs.Parameters.Clear();
                        scmdDVDs.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdDVDs.Parameters.AddWithValue("@vbk", '1');

                        scmdKS.Parameters.Clear();
                        scmdKS.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdKS.Parameters.AddWithValue("@vbk", '1');
                        break;

                    case "ausgeliehen":
                        scmdB.Parameters.Clear();
                        scmdB.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdB.Parameters.AddWithValue("@vbk", '2');

                        scmdZ.Parameters.Clear();
                        scmdZ.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdZ.Parameters.AddWithValue("@vbk", '2');

                        scmdDVDs.Parameters.Clear();
                        scmdDVDs.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdDVDs.Parameters.AddWithValue("@vbk", '2');

                        scmdKS.Parameters.Clear();
                        scmdKS.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdKS.Parameters.AddWithValue("@vbk", '2');
                        break;

                    case "zurückgebracht":
                        scmdB.Parameters.Clear();
                        scmdB.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdB.Parameters.AddWithValue("@vbk", '0');

                        scmdZ.Parameters.Clear();
                        scmdZ.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdZ.Parameters.AddWithValue("@vbk", '0');

                        scmdDVDs.Parameters.Clear();
                        scmdDVDs.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdDVDs.Parameters.AddWithValue("@vbk", '0');

                        scmdKS.Parameters.Clear();
                        scmdKS.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdKS.Parameters.AddWithValue("@vbk", '0');
                        break;

                    case "verfügbar (Reservation storniert)":
                        scmdB.Parameters.Clear();
                        scmdB.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdB.Parameters.AddWithValue("@vbk", '0');

                        scmdZ.Parameters.Clear();
                        scmdZ.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdZ.Parameters.AddWithValue("@vbk", '0');

                        scmdDVDs.Parameters.Clear();
                        scmdDVDs.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdDVDs.Parameters.AddWithValue("@vbk", '0');

                        scmdKS.Parameters.Clear();
                        scmdKS.Parameters.AddWithValue("@ttl", textBox1.Text);
                        scmdKS.Parameters.AddWithValue("@vbk", '0');
                        break;

                }
                switch (comboBoxCgy.Text)
                {
                    case "Buch":
                        scmdB.ExecuteNonQuery();
                        MessageBox.Show("Änderung übernommen");
                        break;
                    case "Zeitung":
                        scmdZ.ExecuteNonQuery();
                        MessageBox.Show("Änderung übernommen");
                        break;
                    case "Konsolenspiel":
                        scmdB.ExecuteNonQuery();
                        MessageBox.Show("Änderung übernommen");
                        break;
                    case "DVD":
                        scmdDVDs.ExecuteNonQuery();
                        MessageBox.Show("Änderung übernommen");
                        break;

                }
                scn.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show("Can not open connection ! " + z);
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxVerfügbarkeit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCgy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
