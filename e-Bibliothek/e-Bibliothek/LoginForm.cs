using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Bibliothek
{
    public partial class LoginForm : Form
    {
        static int attempt = 3;
        public int alter;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            var sha1 = System.Security.Cryptography.SHA1.Create();
            var inputBytes = Encoding.ASCII.GetBytes(tBPasswd.Text);
            var hash = sha1.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (var i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            string passWDHash = sb.ToString();

            if (attempt == 0)
            {
                MessageBox.Show("All 3 attempts have failed");
                return;
            }

            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\timos\Source\Repos\eBibliothek2\e-Bibliothek\e-Bibliothek\Database1.mdf;Integrated Security=True";
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from Benutzer where BenutzerName=@usr and PassWD=@pwd", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", tBUserN.Text);
            scmd.Parameters.AddWithValue("@pwd", passWDHash);
            scn.Open();

            if (scmd.ExecuteScalar().ToString() == "1")
            {
                SqlCommand scmda = new SqlCommand("select BDATE from Benutzer where BenutzerName=@usr", scn);
                scmda.Parameters.Clear();
                scmda.Parameters.AddWithValue("@usr", tBUserN.Text);
                var then = Convert.ToDateTime(scmda.ExecuteScalar());
                var now = DateTime.UtcNow;
                int age = now.Year - then.Year;
                if (now.AddYears(-age) < then) age--;
                alter = age;
                LobbyForm lf = new LobbyForm();
                lf.Show();
                this.Hide();
            }

            else
            {

                MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");
                MessageBox.Show("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                --attempt;
                tBUserN.Clear();
                tBPasswd.Clear();
            }
            scn.Close();
        }

        private void bRegistrieren_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration f2 = new Registration();
            f2.Show();
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            KatalogForm kf = new KatalogForm();
            kf.Show();
            
        }

        private void btnMitarbeiter_Click(object sender, EventArgs e)
        {
            LoginMA lma = new LoginMA();
            lma.Show();
            this.Hide();
        }
    }
}
