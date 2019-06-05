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
    public partial class ReservationsForm : Form
    {
        LoginForm lf = new LoginForm();
        public ReservationsForm()
        {
            InitializeComponent();
        }

        private void btnReservieren_Click(object sender, EventArgs e)
        {
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\timos\Source\Repos\eBibliothek2\e-Bibliothek\e-Bibliothek\Database1.mdf;Integrated Security=True";
            
            
            try
            {
                scn.Open();
            
                SqlCommand scmdB = new SqlCommand("UPDATE Bücher SET verfügbarkeit = '1' WHERE  titel=@ttl", scn);
                SqlCommand vB = new SqlCommand("Select verfügbarkeit FROM Bücher WHERE  titel=@ttl", scn);

                SqlCommand scmdKS = new SqlCommand("UPDATE konsolenspiele SET verfügbarkeit = '1' WHERE  titel=@ttl", scn);
                SqlCommand vKS = new SqlCommand("Select verfügbarkeit FROM konsolenspiele WHERE  titel=@ttl", scn);
                SqlCommand aKS = new SqlCommand("select count(*) as cnt from konsolenspiele where mindestalter > @altr and titel=@ttl", scn);

                SqlCommand scmdDVD = new SqlCommand("UPDATE DVDs SET verfügbarkeit = '1' WHERE  titel=@ttl", scn);
                SqlCommand vDVD = new SqlCommand("Select verfügbarkeit FROM DVDs WHERE  titel=@ttl", scn);
                SqlCommand aDVD = new SqlCommand("select count(*) as cnt from DVDs where mindestalter > @altr and titel=@ttl", scn);

                SqlCommand scmdZ = new SqlCommand("UPDATE Zeitungen SET verfügbarkeit = '1' WHERE  titel=@ttl", scn);
                SqlCommand vZ = new SqlCommand("Select verfügbarkeit FROM Zeitungen WHERE  titel=@ttl", scn);

                SqlCommand scmda = new SqlCommand("select BDate from Benutzer where BenutzerName=@usr", scn);
                scmda.Parameters.Clear();
                scmda.Parameters.AddWithValue("@usr", lf.tBUserN.Text);
                var then = Convert.ToDateTime(scmda.ExecuteScalar());
                var now = DateTime.UtcNow;
                int age = now.Year - then.Year;
                if (now.AddYears(-age) < then) age--;
                switch (comboBox1.Text)
                {
                    case "Bücher":
                        scmdB.Parameters.Clear();
                        scmdB.Parameters.AddWithValue("@ttl", textBox1.Text);
                        vB.Parameters.Clear();
                        vB.Parameters.AddWithValue("@ttl", textBox1.Text);
                        if (vB.ExecuteScalar().ToString() == "1" || vB.ExecuteScalar().ToString() == "2")
                        {
                            MessageBox.Show("Gegenstand nicht verfügbar");
                        }
                        else
                        {
                            scmdB.ExecuteNonQuery();
                            MessageBox.Show("Gegenstand reserviert");

                        }
                        break;
                    case "konsolenspiele":
                        scmdKS.Parameters.Clear();
                        scmdKS.Parameters.AddWithValue("@ttl", textBox1.Text);
                        vKS.Parameters.Clear();
                        vKS.Parameters.AddWithValue("@ttl", textBox1.Text);
                        aKS.Parameters.Clear();
                        aKS.Parameters.AddWithValue("@altr", age);
                        aKS.Parameters.AddWithValue("@ttl", textBox1.Text);

                        if (vKS.ExecuteScalar().ToString() == "1" || vKS.ExecuteScalar().ToString() == "2")
                        {
                            MessageBox.Show("Gegenstand nicht verfügbar");
                        }
                        if(aKS.ExecuteScalar().ToString() == "1")
                        {
                            MessageBox.Show("Sie sind zu jung");
                        }
                        else
                        {
                            scmdKS.ExecuteNonQuery();
                            MessageBox.Show("Gegenstand reserviert");

                        }
                        break;

                    case "DVDs":
                        scmdDVD.Parameters.Clear();
                        scmdDVD.Parameters.AddWithValue("@ttl", textBox1.Text);
                        vDVD.Parameters.Clear();
                        vDVD.Parameters.AddWithValue("@ttl", textBox1.Text);
                        aDVD.Parameters.Clear();
                        aDVD.Parameters.AddWithValue("@altr", age);
                        aDVD.Parameters.AddWithValue("@ttl", textBox1.Text);
                        if (vDVD.ExecuteScalar().ToString() == "1" || vDVD.ExecuteScalar().ToString() == "2")
                        {
                            MessageBox.Show("Gegenstand nicht verfügbar");
                        }
                        if (aKS.ExecuteScalar().ToString() == "1")
                        {
                            MessageBox.Show("Sie sind zu jung");
                        }
                        else
                        {
                            scmdDVD.ExecuteNonQuery();
                            MessageBox.Show("Gegenstand reserviert");

                        }
                        break;

                    case "Zeitungen":
                        scmdZ.Parameters.Clear();
                        scmdZ.Parameters.AddWithValue("@ttl", textBox1.Text);
                        vZ.Parameters.Clear();
                        vZ.Parameters.AddWithValue("@ttl", textBox1.Text);
                        if (vZ.ExecuteScalar().ToString() == "1" || vZ.ExecuteScalar().ToString() == "2")
                        {
                            MessageBox.Show("Gegenstand nicht verfügbar");
                        }
                        else
                        {
                            scmdZ.ExecuteNonQuery();
                            MessageBox.Show("Gegenstand reserviert");

                        }
                        break;

                }
                scn.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show("Can not open connection ! " + z);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LobbyForm lf = new LobbyForm();
            lf.Show();
            this.Hide();
        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
