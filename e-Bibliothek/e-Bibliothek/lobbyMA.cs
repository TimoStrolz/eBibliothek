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
    public partial class lobbyMA : Form
    {
        public lobbyMA()
        {
            InitializeComponent();
        }

        private void lobbyMA_Load(object sender, EventArgs e)
        {

        }

        private void btnVerfügbarkeit_Click(object sender, EventArgs e)
        {
            VerfügbarkeitsForm vf = new VerfügbarkeitsForm();
            vf.Show();
            this.Close();
        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            HinzufügenForm hf = new HinzufügenForm();
            hf.Show();
            this.Hide();
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            KatalogForm kf = new KatalogForm();
            kf.Show();
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            BenutzerForm bf = new BenutzerForm();
            bf.Show();
            this.Hide();
        }
    }
}
