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
using System.Drawing;
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
        }

        private void SetFileName(string fileName)
        {
            richTextBoxFileName.Text = fileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line; //Line in file
            
            //Search tearms holders
            string src1 = "";
            string src2 = "";
            string src3 = "";

            int counter = 1; //Keeps location of line in file
            int i = 0;
            
            //Total counters for search terms
            int isfailedCounter = 0;
            int isHDDCounter = 0;
            int isUScounter = 0;

            bool isfailed = false;
            bool isHDD = false;

            if (checkBoxHDD.Checked == true)
                src2 = "HDD";

            if (checkBoxfailed.Checked == true)
                src1 = "failed";
            
            if (checkBoxUserSrc.Checked == true)
            {
                src3 = textBoxUserSrc.Text;
            }
            
                
                using (StreamReader sr = new StreamReader(richTextBoxFileName.Text))
                {
                    richTextBoxReader.Text = " ";
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Checks if failed is located
                        if ((checkBoxfailed.Checked && line.Contains(src1)))// || line.Contains(src2))
                        {
                            
                            richTextBoxReader.Text = richTextBoxReader.Text + "Failed at: " + counter.ToString() + " || "+ line + "\n\n";
                            isfailed = true;
                            counter++;
                        isfailedCounter++;
                        }
                        //Checks if HDD is located
                         else if ((checkBoxHDD.Checked && line.Contains(src2)))
                        {
                            richTextBoxReader.Text = richTextBoxReader.Text + "HDD at: " + counter.ToString() + " || " + line + "\n\n";
                        isHDD = true;
                            counter++;
                        isHDDCounter++;
                        }
                        else if ((checkBoxUserSrc.Checked && line.Contains(src3)))
                        {
                            richTextBoxReader.Text = richTextBoxReader.Text + src3 + " found at: " + counter.ToString() + " || " + line + "\n\n";
                            isfailed = true;
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



                sr.Close();
                } //end file
               
            
            
        }
        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    SetText(sr.ReadToEnd());
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
    }
}
