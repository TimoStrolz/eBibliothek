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
    public partial class ReservationsForm : Form
    {
        public ReservationsForm()
        {
            InitializeComponent();
        }

        private void btnReservieren_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LobbyForm lf = new LobbyForm();
            lf.Show();
            this.Hide();
        }
    }
}
