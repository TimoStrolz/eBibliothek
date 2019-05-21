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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "database1DataSet.Benutzer". Sie können sie bei Bedarf verschieben oder entfernen.
            this.benutzerTableAdapter.Fill(this.database1DataSet.Benutzer);

        }
    }
}
