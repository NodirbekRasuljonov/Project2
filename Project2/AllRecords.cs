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
        //some local variable using multiple places
        int index = 0;
        int lines = File.ReadLines("D:\\C# lesson Univeristy\\Project2\\demo.txt").Count();
        string filePath = "D:\\C# lesson Univeristy\\Project2\\demo.txt";
        

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
       
        
        //decreasing the index of a line in file
        private void prevButton_Click(object sender, EventArgs e)
        {
            
                index--;
                getData(index);
           
                
           
           
        }


        //incresing the index of line in file
        private void nextButton_Click(object sender, EventArgs e)
        {
            
                index++;
                getData(index);
           
            
        }

        
        //Getting lines from a file
        public void getData(int index)
        {
            var logFile = File.ReadAllLines(filePath);
            var logList = new List<string>(logFile);
            int lines=logList.Count;
            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists && fileInfo.Length == 0){
                records.Text = "No donnors";
            } 
            else 
            {
                if (index <= 0)
                {
                    records.Text = logList[0];

                }
                else if (index >= lines)
                {
                    records.Text = logList[lines - 1];
                }
                else
                {
                    records.Text = logList[index];

                }
            }
            
            

        }




        //Deleting a donnor if file is empty it will return warning massage
        private void deleteButton_Click(object sender, EventArgs e)

        {

            var logFile = File.ReadAllLines(filePath);
            var logList = new List<string>(logFile);
            List<string> modifiedLines = new List<string>(logFile);
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists && fileInfo.Length == 0)
            {
                DialogResult r = MessageBox.Show("No Donors to Delete", "Warning");

            }
            else
            {
                if (index <= 0)
                {
                    modifiedLines.RemoveAt(0);
                    File.WriteAllLines(filePath, modifiedLines);
                    getData(index);

                }
                else if (index >= lines)
                {
                    modifiedLines.RemoveAt(lines - 1);
                    File.WriteAllLines(filePath, modifiedLines);

                    getData(index);

                }
                else
                {
                    modifiedLines.RemoveAt(index);
                    File.WriteAllLines(filePath, modifiedLines);

                    getData(index);


                }
            }

        }
    }
}


