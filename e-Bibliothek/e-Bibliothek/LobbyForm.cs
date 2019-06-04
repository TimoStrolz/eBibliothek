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
    public partial class LobbyForm : Form
    {
        public LobbyForm()
        {
            InitializeComponent();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            KatalogForm kf = new KatalogForm();
            kf.Show();
            

        }

        private void btnReservieren_Click(object sender, EventArgs e)
        {
            ReservationsForm rf = new ReservationsForm();
            rf.Show();
            this.Hide();
        }
    }
}
