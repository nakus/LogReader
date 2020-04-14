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

namespace LogReader
{
    
    public partial class MainPage : Form
    {
        string file = "";
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
           
        }
        private void SetText(string text)
        {
            richTextBoxReader.Text = text;
            
        }

        private void SetFileName(string fileName)
        {
            richTextBoxFileName.Text = fileName;
            file = fileName;
        }

        //Button to run report with/out search terms selected
        private void button1_Click(object sender, EventArgs e)
        {
           
            string line1; //Line of the file

            
            
            List<SearchTerms> sTerms = new List<SearchTerms>();

            //Keeps location of line in file
            int counter1 = 1;

         

            ///////Using Check Box List Items
            foreach (object itemChecked in checkedListBoxST.CheckedItems)
            {
                sTerms.Add(new SearchTerms(itemChecked.ToString(), 0));

                
            }

            //If any of the user check boxes are selected, this addes the text/term to the search list
            if (checkBoxUserSrc.Checked)
            {
                if (textBoxUserSrc.Text !="" && !textBoxUserSrc.Text.StartsWith(" "))
                    sTerms.Add(new SearchTerms(textBoxUserSrc.Text, 0));
                
            }
            if (checkBox1.Checked)
            {
                if (textBox1.Text != "")
                    sTerms.Add(new SearchTerms(textBox1.Text, 0));
            }
            if (checkBox2.Checked)
            {
                sTerms.Add(new SearchTerms(textBox2.Text, 0));
            }
            if (checkBox3.Checked)
            {
                sTerms.Add(new SearchTerms(textBox3.Text, 0));
            }
            if (checkBox4.Checked)
            {
                sTerms.Add(new SearchTerms(textBox4.Text, 0));
            }
            if (checkBox5.Checked)
            {
                sTerms.Add(new SearchTerms(textBox5.Text, 0));
            }

        

            //Error checks if a file is open or not
            if (file == "") // Bad file
            {
                richTextBoxReader1.Text = "Please open a file first";
            }
            if (file != "")// Good File
            {

                //Reads file
                using (StreamReader xr = new StreamReader(file))
                {
                    richTextBoxReader1.Text = "";


                    while ((line1 = xr.ReadLine()) != null)
                    {
                        if (sTerms.Count == 0)//Is anything selected?
                        {
                            richTextBoxReader1.Text = "There is nothing selected. \n";
                        }
                        else
                        {
                            
                            foreach (SearchTerms item in sTerms)
                            {
                                if (line1.Contains(item.term))
                                {
                                    richTextBoxReader1.Text += 
                                    item.term + " | found at: " + counter1.ToString() + " || " +
                                    line1 + "\n\n";
                                    item.number++;
                                }

                            }
 
                        }
                        counter1++;
                       
                    }///end while reading file

                }///End using StreamReader

            //Counts the number of times a search term is found in the log
            foreach (SearchTerms searchTerms in sTerms)
                {
                    if (searchTerms.term != "")
                    {
                        richTextBoxReader1.Text += searchTerms.term + " found " + 
                            searchTerms.number + " number of times \n\n";
                    }
                }


            }// End of if statement that checks if a file is open
          
        }//End Button click function
        

   
        //Opens the file or log
        private void button2_Click(object sender, EventArgs e)
        {
            string line ="";
            int counter = 1;
            richTextBoxReader.Text = " ";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //var sr = new StreamReader(openFileDialog1.FileName);
                    string file = openFileDialog1.FileName;
                    using (StreamReader sr = new StreamReader(file))
                    {


                        //sr.ReadToEnd();
                        richTextBoxReader.Text = sr.ReadToEnd();
                        richTextBoxFileName.Text = file;
                        SetFileName(file);

                    }
                    
                    //richTextBoxReader1.Text = sr.ReadToEnd();
                    //SetFileName(openFileDialog1.FileName);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error. \n\n Error message:  {ex.Message} \n\n + $ Details: \n\n {ex.StackTrace}");
                }
            }
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
