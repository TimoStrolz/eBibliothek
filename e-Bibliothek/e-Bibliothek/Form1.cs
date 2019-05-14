using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Bibliothek
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Passwort oder Benutzername falsch");
        }

        private void bRegistrieren_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration f2 = new Registration();
            f2.Show();
        }

        private void bKatalog_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalog f3 = new Catalog();
            f3.Show();
        }

        private void bPasswdV_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewPassWd f4 = new NewPassWd();
            f4.Show();
        }
    }


}
