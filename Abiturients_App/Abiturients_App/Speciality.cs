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
    public partial class Speciality : MaterialSkin.Controls.MaterialForm
    {
        public Speciality()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='collegeenrollmentdatabase';username=root;password=41Elaset");
        MySqlCommand command;

        private void Speciality_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM speciality2";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            materialSingleLineTextField1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            materialSingleLineTextField2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            materialSingleLineTextField3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            materialSingleLineTextField4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запрос выполнен");
                }
                else
                {
                    MessageBox.Show("Запрос не выполнен");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally

            {
                closeConnection();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu f2 = new Menu();
            f2.Show();
        }

        private void Speciality_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string addQuery = "INSERT INTO speciality2(idSpeciality, nameOfSpeciality, budget, comerc) VALUES('"+materialSingleLineTextField1.Text+"','" + materialSingleLineTextField2.Text + "','" + materialSingleLineTextField3.Text + "','" + materialSingleLineTextField4.Text + "')";
            executMyQuery(addQuery);
        }
    }
}
