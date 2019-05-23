namespace Building
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
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.fileImportButton = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.checkedListBoxFrom = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxTo = new System.Windows.Forms.CheckedListBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelPaths = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.linksLabel = new System.Windows.Forms.Label();
            this.button1stAlgorithm = new System.Windows.Forms.Button();
            this.button2ndAlgorithm = new System.Windows.Forms.Button();
            this.button3rdAlgorithm = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(173, 42);
            this.FileTextBox.Multiline = true;
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(375, 36);
            this.FileTextBox.TabIndex = 0;
            // 
            // fileImportButton
            // 
            this.fileImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileImportButton.Location = new System.Drawing.Point(43, 42);
            this.fileImportButton.Name = "fileImportButton";
            this.fileImportButton.Size = new System.Drawing.Size(110, 36);
            this.fileImportButton.TabIndex = 1;
            this.fileImportButton.Text = "Import File";
            this.fileImportButton.UseVisualStyleBackColor = true;
            this.fileImportButton.Click += new System.EventHandler(this.fileImportButton_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReadFile.Location = new System.Drawing.Point(566, 42);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(110, 36);
            this.buttonReadFile.TabIndex = 2;
            this.buttonReadFile.Text = "Read File";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // checkedListBoxFrom
            // 
            this.checkedListBoxFrom.FormattingEnabled = true;
            this.checkedListBoxFrom.Location = new System.Drawing.Point(43, 133);
            this.checkedListBoxFrom.Name = "checkedListBoxFrom";
            this.checkedListBoxFrom.Size = new System.Drawing.Size(101, 139);
            this.checkedListBoxFrom.TabIndex = 3;
            // 
            // checkedListBoxTo
            // 
            this.checkedListBoxTo.FormattingEnabled = true;
            this.checkedListBoxTo.Location = new System.Drawing.Point(173, 133);
            this.checkedListBoxTo.Name = "checkedListBoxTo";
            this.checkedListBoxTo.Size = new System.Drawing.Size(101, 139);
            this.checkedListBoxTo.TabIndex = 4;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(42, 110);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(30, 13);
            this.labelFrom.TabIndex = 5;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(170, 110);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(20, 13);
            this.labelTo.TabIndex = 6;
            this.labelTo.Text = "To";
            // 
            // labelPaths
            // 
            this.labelPaths.AutoSize = true;
            this.labelPaths.Location = new System.Drawing.Point(42, 292);
            this.labelPaths.Name = "labelPaths";
            this.labelPaths.Size = new System.Drawing.Size(64, 13);
            this.labelPaths.TabIndex = 7;
            this.labelPaths.Text = "Paths found";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(45, 308);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(294, 119);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // linksLabel
            // 
            this.linksLabel.AutoSize = true;
            this.linksLabel.Location = new System.Drawing.Point(314, 110);
            this.linksLabel.Name = "linksLabel";
            this.linksLabel.Size = new System.Drawing.Size(32, 13);
            this.linksLabel.TabIndex = 10;
            this.linksLabel.Text = "Links";
            // 
            // button1stAlgorithm
            // 
            this.button1stAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1stAlgorithm.Location = new System.Drawing.Point(522, 123);
            this.button1stAlgorithm.Name = "button1stAlgorithm";
            this.button1stAlgorithm.Size = new System.Drawing.Size(154, 44);
            this.button1stAlgorithm.TabIndex = 11;
            this.button1stAlgorithm.Text = "1st algorithm";
            this.button1stAlgorithm.UseVisualStyleBackColor = true;
            // 
            // button2ndAlgorithm
            // 
            this.button2ndAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2ndAlgorithm.Location = new System.Drawing.Point(522, 173);
            this.button2ndAlgorithm.Name = "button2ndAlgorithm";
            this.button2ndAlgorithm.Size = new System.Drawing.Size(154, 44);
            this.button2ndAlgorithm.TabIndex = 12;
            this.button2ndAlgorithm.Text = "2nd algorithm";
            this.button2ndAlgorithm.UseVisualStyleBackColor = true;
            // 
            // button3rdAlgorithm
            // 
            this.button3rdAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3rdAlgorithm.Location = new System.Drawing.Point(522, 223);
            this.button3rdAlgorithm.Name = "button3rdAlgorithm";
            this.button3rdAlgorithm.Size = new System.Drawing.Size(154, 44);
            this.button3rdAlgorithm.TabIndex = 13;
            this.button3rdAlgorithm.Text = "3rd algorithm";
            this.button3rdAlgorithm.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(306, 133);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 134);
            this.listBox1.TabIndex = 14;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(360, 308);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(294, 119);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3rdAlgorithm);
            this.Controls.Add(this.button2ndAlgorithm);
            this.Controls.Add(this.button1stAlgorithm);
            this.Controls.Add(this.linksLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelPaths);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.checkedListBoxTo);
            this.Controls.Add(this.checkedListBoxFrom);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.fileImportButton);
            this.Controls.Add(this.FileTextBox);
            this.Name = "Form1";
            this.Text = "Building Paths";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Button fileImportButton;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.CheckedListBox checkedListBoxFrom;
        private System.Windows.Forms.CheckedListBox checkedListBoxTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelPaths;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label linksLabel;
        private System.Windows.Forms.Button button1stAlgorithm;
        private System.Windows.Forms.Button button2ndAlgorithm;
        private System.Windows.Forms.Button button3rdAlgorithm;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

