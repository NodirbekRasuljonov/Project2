using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

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


        //save button
        private void saveButton_Click(object sender, EventArgs e)
        {
           DonorInfoClass donorInfo = new DonorInfoClass(name:nameTextbox.Text,surname:surnameTextBox.Text,socialID:socialIdTextBox.Text,phoneNumber:phoneNumberTextBox.Text,email:emailTextBox.Text,date:label9.Text);
            donorInfo.writeToFile();
            clearTextBoxes();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AddDonnor_Load(object sender, EventArgs e)
        {
            updateDateTime();

        }

        //Clear TextBoxes
        public void clearTextBoxes() {
            nameTextbox.Clear();
            surnameTextBox.Clear();
            socialIdTextBox.Clear();
            phoneNumberTextBox.Clear();
            emailTextBox.Clear();
            bloodTypeTextBox.Clear();
            updateDateTime();
        }


        //Update Date Time
        public void updateDateTime()
        {
            label9.Text =  DateTime.Now.ToString();
        }

    }



    //Donnor  class
    public class DonorInfoClass
    {
        string name { get; set; }
        string surname { get; set; }
        string socialID { get; set; }
        string phoneNumber { get; set; }
        string email { get; set; }
        string date { get; set; }


       
        public DonorInfoClass(string name, string surname, string socialID, string phoneNumber, string email,string date)
        {
            this.name = name;
            this.surname = surname;
            this.socialID = socialID;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.date = date;
        }

        //writing a data into a file
        public void  writeToFile()
        {
            Random rand = new Random();
            int uniqueID = rand.Next(10000, 99999);
            string filePath = @"D:\C# lesson Univeristy\Project2\allData.txt";
            StreamWriter fileWriter =new StreamWriter(filePath,true);
            fileWriter.WriteLine($"ID:{uniqueID},Name:{name},Surname:{surname},SocialID:{socialID},Phone Number:{phoneNumber},Email:{email}, Donation Date {date}");
            fileWriter.Close();

                
            DialogResult r = MessageBox.Show("Donnor Added", "Save File");
           
        }  
    }

}
