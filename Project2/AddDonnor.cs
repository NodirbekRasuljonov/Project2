using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class AddDonnor : Form
    {
        public AddDonnor()
        {
            InitializeComponent();
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            Main main= new Main();
            main.Show();
            this.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void AddDonnor_Load(object sender, EventArgs e)
        {
            label9.Text=DateTime.Now.ToString();
        }
    }
}
