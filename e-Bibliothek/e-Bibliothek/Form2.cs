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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bWeiter_Click(object sender, EventArgs e)
        {
            if (tBEmail.Text == "")
            {
                MessageBox.Show("Geben sie ein EMail-Adresse ein");
                return;
            }
            if (tBPasswort1.Text == "")
            {
                MessageBox.Show("Geben sie ein Passwort ein");
                return;
            }
            if (tBPasswort2.Text == "")
            {
                MessageBox.Show("Bitte Bestätigen sie ihr Passwort");
                return;
            }
            if (tBAdresse.Text == "")
            {
                MessageBox.Show("Geben sie ihre Adresse ein");
                return;
            }
            if(tBPasswort1.Text != tBPasswort2.Text)
            {
                MessageBox.Show("Passwörter stimmen nicht überrein.");
                return;
            }

            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\timos\Source\Repos\eBibliothek2\e-Bibliothek\e-Bibliothek\Database1.mdf;Integrated Security=True";
            // Create a new Benutzer object.
            Benutzer b1 = new Benutzer(tBEmail.Text, tBPasswort1.Text, dateTimePicker1.Value, tBAdresse.Text);
            string sqlFormattedDate = b1.BDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            sql = String.Format("INSERT INTO Benutzer (BenutzerName, PassWd, BDate, Adresse) VALUES('{0}', '{1}', '{2}', '{3}'); ", b1.BenutzerName, b1.PassWD, sqlFormattedDate, b1.Adresse);
            connection = new SqlConnection(connetionString);
            
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                
                command.ExecuteNonQuery();
                //command.Dispose();
                connection.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show("Can not open connection ! " + z);
            }

            FormTest ft = new FormTest();
            ft.Show();
            this.Close();



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tBAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
