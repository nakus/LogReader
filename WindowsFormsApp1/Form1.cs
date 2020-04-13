using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void SetText(string text)
        {
            richTextBoxReader.Text = text;
            //richTextBoxReader1.Text = text;
        }

        private void SetFileName(string fileName)
        {
            richTextBoxFileName.Text = fileName;
        }

        //Button to run report with/out search terms selected
        private void button1_Click(object sender, EventArgs e)
        {
            string line; //Line in file
            string line1; //Testing Checkbox List
            //Search tearms holders
            string src1 = "";
            string src2 = "";
            string src3 = "";
            
            List<string> searchItems = new List<string>();
            List<string> fileLog = new List<string>();

            //Keeps location of line in file
            int counter = 1; 
            int counter1 = 1;

            int i = 0;
            
            //Total counters for search terms
            int isfailedCounter = 0;
            int isHDDCounter = 0;
            int isUScounter = 0;

            ///////Using Check Box List Items ~~~~~ TEST~~~~~/////////////
            foreach (object itemChecked in checkedListBoxST.CheckedItems)
            {
                searchItems.Add(itemChecked.ToString());

                
            }
         
            
            using (StreamReader xr = new StreamReader(richTextBoxFileName.Text))
            {
                richTextBoxReader1.Text = "";
                while ((line1 = xr.ReadLine()) != null)
                {
                    foreach(string item in searchItems)
                    {
                        if (line1.Contains(item))
                            {
                                richTextBoxReader1.Text = richTextBoxReader1.Text +
                                item + "found at: " + counter1.ToString() + " || " + 
                                line1 + "\n\n";
                                counter1++;
                            }
                        else
                        {
                            counter1++;
                        }
                     
                    }
                   
                    
                        
                }///end while reading file

            }///End using StreamReader
            

            ///////End of using check box list
        


            if (checkBoxHDD.Checked)
                src2 = "HDD";

            if (checkBoxfailed.Checked)
                src1 = "failed";
            
            if (checkBoxUserSrc.Checked)
            {
                src3 = textBoxUserSrc.Text;
            }
           

         //Using the 'basic check boxes'// 
                using (StreamReader sr = new StreamReader(richTextBoxFileName.Text))
                { 
                    richTextBoxReader.Text = " ";
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Checks if failed is checked and searches for it
                        if ((checkBoxfailed.Checked && line.Contains(src1)))
                        {
                            
                            richTextBoxReader.Text = richTextBoxReader.Text + "Failed at: " + counter.ToString() + " || "+ line + "\n\n";
                            
                            counter++;
                        isfailedCounter++;
                        }
                        //Checks if HDD is checked and searches for it
                         else if ((checkBoxHDD.Checked && line.Contains(src2)))
                        {
                            richTextBoxReader.Text = richTextBoxReader.Text + "HDD at: " + counter.ToString() + " || " + line + "\n\n";
                        
                            counter++;
                        isHDDCounter++;
                        }
                        //Checks if User defined search term is checked and searches for it
                        else if ((checkBoxUserSrc.Checked && line.Contains(src3)))
                        {
                            richTextBoxReader.Text = richTextBoxReader.Text + src3 + " found at: " + counter.ToString() + " || " + line + "\n\n";
                            
                            counter++;
                            isUScounter++;
                        }
                        else 
                            counter++;

                        //If nothing is checked, display whole report
                        if (!checkBoxfailed.Checked && !checkBoxHDD.Checked && !checkBoxUserSrc.Checked)
                         {
                                SetText(sr.ReadToEnd());
                         }
  
                   
                    } //end While traversing file
          //Basic check boxes/////////////////

         //Counters for each search term//

                if (checkBoxfailed.Checked)
                {
                    richTextBoxReader.Text = richTextBoxReader.Text + "'failed found: " + isfailedCounter + " times\n";
                }
                if (checkBoxHDD.Checked)
                {
                    richTextBoxReader.Text = richTextBoxReader.Text + "'HDD found: " + isHDDCounter + " times\n";
                }
                if (checkBoxUserSrc.Checked)
                {
                    richTextBoxReader.Text = richTextBoxReader.Text + src3 + " found: " + isUScounter + " times\n";
                }
        ///////////////////////////////////


                sr.Close(); // Closes file


                } //end StreamReader
               
        }//End function


        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }
        
        //Opens the file or log
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    SetText(sr.ReadToEnd());
                    //richTextBoxReader1.Text = sr.ReadToEnd();
                    SetFileName(openFileDialog1.FileName);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error. \n\n Error message:  {ex.Message} \n\n + $ Details: \n\n {ex.StackTrace}");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Exports results to a file
        private void bSaveResults_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(fileName, richTextBoxReader.Text);
            }
            
        }

        
    }
}
