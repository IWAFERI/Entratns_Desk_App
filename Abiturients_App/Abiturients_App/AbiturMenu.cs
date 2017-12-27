using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Abiturients_App
{
    public partial class AbiturMenu : MaterialSkin.Controls.MaterialForm
    {
        public AbiturMenu()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='collegeenrollmentdatabase';username=root;password=41Elaset");
        MySqlCommand command;

        private void AbiturMenu_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM people";

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void AbiturMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu f1 = new Menu();
            f1.Show();
        }
    }
}
