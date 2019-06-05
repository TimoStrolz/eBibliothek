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
        public HinzufügenForm()
        {
            InitializeComponent();
            panelBuch.Hide();
        }


        private void btnBuch_Click(object sender, EventArgs e)
        {
            panelBuch.Show();
        }

        private void btnKS_Click(object sender, EventArgs e)
        {
  
        }

        private void btnZeitung_Click(object sender, EventArgs e)
        {

        }

        private void btnDVD_Click(object sender, EventArgs e)
        {

        }

        private void btnBHinzufügen_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\timos\Source\Repos\eBibliothek2\e-Bibliothek\e-Bibliothek\Database1.mdf;Integrated Security=True";
            // Create a new Benutzer object.
            //insert into 
            sql = String.Format("INSERT INTO Bücher (autor, titel, isbnnummer, art, seiten, verfügbarkeit) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '0'); ", textBoxBAutor.Text, textBoxBTitel.Text, textBoxBISNN.Text, textBoxBArt.Text, textBoxBS.Text);
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
        }

        

        private void btnBBAck_Click(object sender, EventArgs e)
        {
            panelBuch.Hide();
        }


    }
}
