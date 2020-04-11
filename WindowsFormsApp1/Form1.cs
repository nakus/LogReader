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
            string line;
            string src1;
            int counter = 1;
            int i = 0;


            if (checkBoxfailed.Checked == true)
            {
                
                using (StreamReader sr = new StreamReader(richTextBoxFileName.Text))
                {
                    richTextBoxReader.Text = " ";
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("failed"))
                        {
                            
                            richTextBoxReader.Text = richTextBoxReader.Text + "Failed at: " + counter.ToString() + " || "+ line + "\n\n"; 

                            counter++;
                        }
                        else
                        counter++;
                    }

                }
            }
            
           
            
            
         

            
            
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
