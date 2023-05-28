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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        //button to navigate adding donnor page
        private void addDonnerButton_Click(object sender, EventArgs e)
        {
            AddDonnor addDonnor= new AddDonnor();
            addDonnor.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }



        //button to exit an app
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //button to navigate all donnor page
        private void allRecordsButton_Click(object sender, EventArgs e)
        {
            AllRecords allRecords= new AllRecords();
            allRecords.Show();
            this.Hide();
        } 
    }
}
