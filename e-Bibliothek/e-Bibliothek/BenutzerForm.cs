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
    public partial class BenutzerForm : Form
    {
        public BenutzerForm()
        {
            InitializeComponent();
        }

        private void BenutzerForm_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "database1DataSet2.Benutzer". Sie können sie bei Bedarf verschieben oder entfernen.
            this.benutzerTableAdapter1.Fill(this.database1DataSet2.Benutzer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lobbyMA lma = new lobbyMA();
            lma.Show();
            this.Hide();
        }
    }
}
