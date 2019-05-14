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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        void FillData()
        {
            // 1
            // Open connection
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\timos\Source\Repos\eBibliothek2\e-Bibliothek\e-Bibliothek\Database1.mdf;Integrated Security=True";
            sql =  "SELECT * FROM Benutzer";
            connection = new SqlConnection(connetionString);
            connection.Open();


            SqlDataAdapter a = new SqlDataAdapter();
            DataGridView dataGridView1 = new DataGridView();
            DataTable t = new DataTable();
            a.Fill(t);

           dataGridView1.DataSource = t;
                
            
        }


    }
}
