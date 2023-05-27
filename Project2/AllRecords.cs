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
    public partial class AllRecords : Form
    {

        int index = 0;
        int lines = File.ReadLines("D:\\C# lesson Univeristy\\Project2\\demo.txt").Count();
        public AllRecords()
        {
            InitializeComponent();
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void AllRecords_Load(object sender, EventArgs e)
        {
            getData(index);


        }

        private void records_Click(object sender, EventArgs e)
        {

        }
       
        

        private void prevButton_Click(object sender, EventArgs e)
        {
                index--;
                getData(index);
           
           
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            
                index++;
                getData(index);
            
        }
        //Getting lines from a file
        public void getData(int index)
        {
            var logFile = File.ReadAllLines("D:\\C# lesson Univeristy\\Project2\\demo.txt");
            var logList = new List<string>(logFile);
            int lines=logList.Count;
            if (index<=0) {
                records.Text = logList[0];

            }
            else if(index>=lines) {
                records.Text = logList[lines-1];
            }
            else
            {
                records.Text = logList[index];

            }

        }
    }
}


