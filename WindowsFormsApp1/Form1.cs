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
  
            string line1; //Testing Checkbox List

            
            List<string> searchItems = new List<string>();

            List<Tuple<string, int>> searchItems1 = new List<Tuple<string, int>>();

            Dictionary<string, int> searchItems2 = new Dictionary<string, int>();

            //Keeps location of line in file
            int counter1 = 1;

         

            ///////Using Check Box List Items
            foreach (object itemChecked in checkedListBoxST.CheckedItems)
            {
                searchItems.Add(itemChecked.ToString());

                
            }

            //If any of the user check boxes are selected, this addes the text/term to the search list
            if (checkBoxUserSrc.Checked)
            {
                searchItems.Add(textBoxUserSrc.Text);
            }
            if (checkBox1.Checked)
            {
                searchItems.Add(textBox1.Text);
            }
            if (checkBox2.Checked)
            {
                searchItems.Add(textBox2.Text);
            }
            if (checkBox3.Checked)
            {
                searchItems.Add(textBox3.Text);
            }
            if (checkBox4.Checked)
            {
                searchItems.Add(textBox4.Text);
            }
            if (checkBox5.Checked)
            {
                searchItems.Add(textBox5.Text);
            }

        

            //Error checks if a file is open or not
            if (richTextBoxFileName.Text == "") // Bad file
            {
                richTextBoxReader1.Text = "Please open a file first";
            }
            if (richTextBoxFileName.Text != "")// Good File
            {

                //Reads file
                using (StreamReader xr = new StreamReader(richTextBoxFileName.Text))
                {
                    richTextBoxReader1.Text = "";


                    while ((line1 = xr.ReadLine()) != null)
                    {
                        if (searchItems.Count == 0)//Is anything selected?
                        {
                            richTextBoxReader1.Text = "There is nothing selected. \n";
                        }
                        else
                        {
                            foreach (string item in searchItems)
                            {
                                if (line1.Contains(item))
                                {
                                    richTextBoxReader1.Text = richTextBoxReader1.Text +
                                    item + " | found at: " + counter1.ToString() + " || " +
                                    line1 + "\n\n";

                                }
                            }
                        }
                        counter1++;
                       
                    }///end while reading file

                }///End using StreamReader

            }// End of if statement that checks if a file is open
          
        }//End Button click function
        

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
