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
    public partial class Abitur : MaterialSkin.Controls.MaterialForm
    {
        public Abitur()
        {
            InitializeComponent();
        }

        private void Abitur_Load(object sender, EventArgs e)
        {

        }

        private void Abitur_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu f2 = new Menu();
            f2.Show();
        }
    }
}
