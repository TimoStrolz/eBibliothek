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
    public partial class HinzufügenForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string sql = null;
        string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\timos\Source\Repos\eBibliothek2\e-Bibliothek\e-Bibliothek\Database1.mdf;Integrated Security=True";
            
        public HinzufügenForm()
        {
            InitializeComponent();
            panelBuch.Hide();
            panelZeitung.Hide();
            panelKS.Hide();
            panelDVD.Hide();
        }


        private void btnBuch_Click(object sender, EventArgs e)
        {
            panelBuch.Show();
        }

        private void btnKS_Click(object sender, EventArgs e)
        {
            panelKS.Show();
        }

        private void btnZeitung_Click(object sender, EventArgs e)
        {
            panelZeitung.Show();
        }

        private void btnDVD_Click(object sender, EventArgs e)
        {
            panelZeitung.Show();
        }

        private void btnBHinzufügen_Click(object sender, EventArgs e)
        { 
            sql = String.Format("INSERT INTO Bücher (autor, titel, isbnnummer, art, seiten, verfügbarkeit) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '0'); ", textBoxBAutor.Text, textBoxBTitel.Text, textBoxBISNN.Text, textBoxBArt.Text, textBoxBS.Text);
            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);

                command.ExecuteNonQuery();
                MessageBox.Show("Gegenstand Hinzugefügt");
                connection.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show("Can not open connection ! " + z);
            }
        }

        

        private void btnBBAck_Click(object sender, EventArgs e)
        {
            panelBuch.Hide();
        }

        private void btnZBack_Click(object sender, EventArgs e)
        {
            panelZeitung.Hide();

        }

        private void buttonZH_Click(object sender, EventArgs e)
        {
            sql = String.Format("INSERT INTO Zeitungen (titel, verlag, issn-nummer, art, erscheinungshäufigkeit, verfügbarkeit) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '0'); ", textBoxZT.Text, textBoxZV.Text, textBoxZISSNN.Text, textBoxZArt.Text, textBoxZEH.Text);
            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);

                command.ExecuteNonQuery();
                MessageBox.Show("Gegenstand Hinzugefügt");
                connection.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show("Can not open connection ! " + z);
            }
        }

        private void buttonKSH_Click(object sender, EventArgs e)
        {
            sql = String.Format("INSERT INTO konsolenspiele (titel, system, mindestalter, verfügbarkeit) VALUES('{0}', '{1}', '{2}', '0'); ", textBoxKST.Text, textBoxKSS.Text, textBoxKSM.Text);
            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);

                command.ExecuteNonQuery();
                MessageBox.Show("Gegenstand Hinzugefügt");
                connection.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show("Can not open connection ! " + z);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelKS.Hide();
        }

        private void buttonDH_Click(object sender, EventArgs e)
        {
            sql = String.Format("INSERT INTO DVDs (titel, art, laufzeit, mindestalter, verfügbarkeit) VALUES('{0}', '{1}', '{2}', '{3}', '0'); ", textBoxDT.Text, textBoxDA.Text, textBoxDL.Text, textBoxDM.Text);
            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);

                command.ExecuteNonQuery();
                MessageBox.Show("Gegenstand Hinzugefügt");
                connection.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show("Can not open connection ! " + z);
            }
        }

        private void btnDBack_Click(object sender, EventArgs e)
        {
            panelDVD.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lobbyMA lma = new lobbyMA();
            lma.Show();
            this.Hide();
        }
    }
}
