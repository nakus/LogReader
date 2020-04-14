namespace LogReader

{
    partial class MainPage
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
            this.richTextBoxReader = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFileName = new System.Windows.Forms.RichTextBox();
            this.checkBoxUserSrc = new System.Windows.Forms.CheckBox();
            this.textBoxUserSrc = new System.Windows.Forms.TextBox();
            this.bSaveResults = new System.Windows.Forms.Button();
            this.checkedListBoxST = new System.Windows.Forms.CheckedListBox();
            this.richTextBoxReader1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run Filters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = ".txt file";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Open File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBoxReader
            // 
            this.richTextBoxReader.Location = new System.Drawing.Point(696, 12);
            this.richTextBoxReader.Name = "richTextBoxReader";
            this.richTextBoxReader.Size = new System.Drawing.Size(463, 640);
            this.richTextBoxReader.TabIndex = 6;
            this.richTextBoxReader.Text = "";
            // 
            // richTextBoxFileName
            // 
            this.richTextBoxFileName.Location = new System.Drawing.Point(11, 58);
            this.richTextBoxFileName.Name = "richTextBoxFileName";
            this.richTextBoxFileName.ReadOnly = true;
            this.richTextBoxFileName.Size = new System.Drawing.Size(209, 44);
            this.richTextBoxFileName.TabIndex = 7;
            this.richTextBoxFileName.Text = "";
            // 
            // checkBoxUserSrc
            // 
            this.checkBoxUserSrc.AutoSize = true;
            this.checkBoxUserSrc.Location = new System.Drawing.Point(12, 112);
            this.checkBoxUserSrc.Name = "checkBoxUserSrc";
            this.checkBoxUserSrc.Size = new System.Drawing.Size(18, 17);
            this.checkBoxUserSrc.TabIndex = 9;
            this.checkBoxUserSrc.UseVisualStyleBackColor = true;
            // 
            // textBoxUserSrc
            // 
            this.textBoxUserSrc.Location = new System.Drawing.Point(43, 108);
            this.textBoxUserSrc.Name = "textBoxUserSrc";
            this.textBoxUserSrc.Size = new System.Drawing.Size(177, 22);
            this.textBoxUserSrc.TabIndex = 10;
            // 
            // bSaveResults
            // 
            this.bSaveResults.Location = new System.Drawing.Point(15, 621);
            this.bSaveResults.Name = "bSaveResults";
            this.bSaveResults.Size = new System.Drawing.Size(99, 32);
            this.bSaveResults.TabIndex = 11;
            this.bSaveResults.Text = "Save Results";
            this.bSaveResults.UseVisualStyleBackColor = true;
            this.bSaveResults.Click += new System.EventHandler(this.bSaveResults_Click);
            // 
            // checkedListBoxST
            // 
            this.checkedListBoxST.FormattingEnabled = true;
            this.checkedListBoxST.Items.AddRange(new object[] {
            "Failed",
            "failed",
            "HDD"});
            this.checkedListBoxST.Location = new System.Drawing.Point(10, 294);
            this.checkedListBoxST.Name = "checkedListBoxST";
            this.checkedListBoxST.Size = new System.Drawing.Size(210, 276);
            this.checkedListBoxST.TabIndex = 12;
            // 
            // richTextBoxReader1
            // 
            this.richTextBoxReader1.Location = new System.Drawing.Point(267, 13);
            this.richTextBoxReader1.Name = "richTextBoxReader1";
            this.richTextBoxReader1.Size = new System.Drawing.Size(414, 640);
            this.richTextBoxReader1.TabIndex = 13;
            this.richTextBoxReader1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 140);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 17;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 168);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 192);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 22);
            this.textBox3.TabIndex = 19;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 196);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(43, 220);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(177, 22);
            this.textBox4.TabIndex = 21;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(12, 224);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(18, 17);
            this.checkBox4.TabIndex = 20;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(43, 248);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(177, 22);
            this.textBox5.TabIndex = 23;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(12, 252);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(18, 17);
            this.checkBox5.TabIndex = 22;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 665);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBoxReader1);
            this.Controls.Add(this.checkedListBoxST);
            this.Controls.Add(this.bSaveResults);
            this.Controls.Add(this.textBoxUserSrc);
            this.Controls.Add(this.checkBoxUserSrc);
            this.Controls.Add(this.richTextBoxFileName);
            this.Controls.Add(this.richTextBoxReader);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainPage";
            this.Text = "Log Reader";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBoxReader;
        private System.Windows.Forms.RichTextBox richTextBoxFileName;
        private System.Windows.Forms.CheckBox checkBoxUserSrc;
        private System.Windows.Forms.TextBox textBoxUserSrc;
        private System.Windows.Forms.Button bSaveResults;
        private System.Windows.Forms.CheckedListBox checkedListBoxST;
        private System.Windows.Forms.RichTextBox richTextBoxReader1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}

