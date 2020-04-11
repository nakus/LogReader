namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxfailed = new System.Windows.Forms.CheckBox();
            this.richTextBoxReader = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFileName = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run Filters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Open File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxfailed
            // 
            this.checkBoxfailed.AutoSize = true;
            this.checkBoxfailed.Location = new System.Drawing.Point(23, 163);
            this.checkBoxfailed.Name = "checkBoxfailed";
            this.checkBoxfailed.Size = new System.Drawing.Size(64, 21);
            this.checkBoxfailed.TabIndex = 5;
            this.checkBoxfailed.Text = "failed";
            this.checkBoxfailed.UseVisualStyleBackColor = true;
            // 
            // richTextBoxReader
            // 
            this.richTextBoxReader.Location = new System.Drawing.Point(230, 35);
            this.richTextBoxReader.Name = "richTextBoxReader";
            this.richTextBoxReader.Size = new System.Drawing.Size(558, 403);
            this.richTextBoxReader.TabIndex = 6;
            this.richTextBoxReader.Text = "";
            // 
            // richTextBoxFileName
            // 
            this.richTextBoxFileName.Location = new System.Drawing.Point(15, 90);
            this.richTextBoxFileName.Name = "richTextBoxFileName";
            this.richTextBoxFileName.ReadOnly = true;
            this.richTextBoxFileName.Size = new System.Drawing.Size(209, 44);
            this.richTextBoxFileName.TabIndex = 7;
            this.richTextBoxFileName.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxFileName);
            this.Controls.Add(this.richTextBoxReader);
            this.Controls.Add(this.checkBoxfailed);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Log Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxfailed;
        private System.Windows.Forms.RichTextBox richTextBoxReader;
        private System.Windows.Forms.RichTextBox richTextBoxFileName;
    }
}

