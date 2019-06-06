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
    public partial class KatalogForm : Form
    {
        public KatalogForm()
        {
            InitializeComponent();
            dataGridViewZeitungen.Hide();
            dataGridViewKSpiele.Hide();
            dataGridViewDVDs.Hide();
            MessageBox.Show("INFO verfügbarkeit 0 = Verfügbar, 1 = reserviert, 2 = ausgeliehen");
        }

        private void Katalog_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "database1DataSet1.DVDs". Sie können sie bei Bedarf verschieben oder entfernen.
            this.dVDsTableAdapter.Fill(this.database1DataSet1.DVDs);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "database1DataSetKSpiele.konsolenspiele". Sie können sie bei Bedarf verschieben oder entfernen.
            this.konsolenspieleTableAdapter.Fill(this.database1DataSetKSpiele.konsolenspiele);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "database1DataSetZeitungen.Zeitungen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.zeitungenTableAdapter.Fill(this.database1DataSetZeitungen.Zeitungen);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "database1DataSetBücher.Bücher". Sie können sie bei Bedarf verschieben oder entfernen.
            this.bücherTableAdapter.Fill(this.database1DataSetBücher.Bücher);

        }

        private void btnBücher_Click(object sender, EventArgs e)
        {
            dataGridViewBücher.Show();
            dataGridViewZeitungen.Hide();
            dataGridViewKSpiele.Hide();
            dataGridViewDVDs.Hide();
        }

        private void btnZeitungen_Click(object sender, EventArgs e)
        {
            dataGridViewBücher.Hide();
            dataGridViewZeitungen.Show();
            dataGridViewKSpiele.Hide();
            dataGridViewDVDs.Hide();
        }

        private void btnKSpiele_Click(object sender, EventArgs e)
        {
            dataGridViewBücher.Hide();
            dataGridViewZeitungen.Hide();
            dataGridViewKSpiele.Show();
            dataGridViewDVDs.Hide();
        }

        private void btnDVD_Click(object sender, EventArgs e)
        {
            dataGridViewBücher.Hide();
            dataGridViewZeitungen.Hide();
            dataGridViewKSpiele.Hide();
            dataGridViewDVDs.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridViewKSpiele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDVDs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
} 
