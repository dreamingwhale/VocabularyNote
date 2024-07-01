namespace Vocabulary
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
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contentBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.findLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.findWordListBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(142, 33);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(120, 19);
            this.wordTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(187, 362);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "add/modify";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Language";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(474, 362);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(364, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Content";
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(364, 73);
            this.contentBox.Multiline = true;
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(360, 130);
            this.contentBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(785, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(32, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Find";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(32, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Language";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(364, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Word";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "Japanese",
            "Korean"});
            this.languageComboBox.Location = new System.Drawing.Point(141, 76);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(121, 20);
            this.languageComboBox.TabIndex = 13;
            this.languageComboBox.Text = "English";
            // 
            // findLanguageComboBox
            // 
            this.findLanguageComboBox.FormattingEnabled = true;
            this.findLanguageComboBox.Items.AddRange(new object[] {
            "English",
            "Japanese",
            "Korean"});
            this.findLanguageComboBox.Location = new System.Drawing.Point(142, 246);
            this.findLanguageComboBox.Name = "findLanguageComboBox";
            this.findLanguageComboBox.Size = new System.Drawing.Size(121, 20);
            this.findLanguageComboBox.TabIndex = 14;
            this.findLanguageComboBox.Text = "English";
            this.findLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.findLanguageComboBox_SelectedIndexChanged);
            // 
            // findWordListBox
            // 
            this.findWordListBox.FormattingEnabled = true;
            this.findWordListBox.Location = new System.Drawing.Point(449, 243);
            this.findWordListBox.Name = "findWordListBox";
            this.findWordListBox.Size = new System.Drawing.Size(121, 20);
            this.findWordListBox.TabIndex = 15;
            this.findWordListBox.SelectedIndexChanged += new System.EventHandler(this.findWordListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 444);
            this.Controls.Add(this.findWordListBox);
            this.Controls.Add(this.findLanguageComboBox);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.wordTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contentBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.ComboBox findLanguageComboBox;
        private System.Windows.Forms.ComboBox findWordListBox;
    }
}

