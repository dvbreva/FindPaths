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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(140, 32);
            this.FileTextBox.Multiline = true;
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(402, 36);
            this.FileTextBox.TabIndex = 0;
            // 
            // fileImportButton
            // 
            this.fileImportButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fileImportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fileImportButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileImportButton.Location = new System.Drawing.Point(13, 32);
            this.fileImportButton.Name = "fileImportButton";
            this.fileImportButton.Size = new System.Drawing.Size(110, 36);
            this.fileImportButton.TabIndex = 1;
            this.fileImportButton.Text = "Import File";
            this.fileImportButton.UseVisualStyleBackColor = false;
            this.fileImportButton.Click += new System.EventHandler(this.fileImportButton_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonReadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReadFile.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReadFile.Location = new System.Drawing.Point(566, 32);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(110, 36);
            this.buttonReadFile.TabIndex = 2;
            this.buttonReadFile.Text = "Read File";
            this.buttonReadFile.UseVisualStyleBackColor = false;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // checkedListBoxFrom
            // 
            this.checkedListBoxFrom.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxFrom.FormattingEnabled = true;
            this.checkedListBoxFrom.Location = new System.Drawing.Point(15, 125);
            this.checkedListBoxFrom.Name = "checkedListBoxFrom";
            this.checkedListBoxFrom.Size = new System.Drawing.Size(83, 148);
            this.checkedListBoxFrom.TabIndex = 3;
            // 
            // checkedListBoxTo
            // 
            this.checkedListBoxTo.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxTo.FormattingEnabled = true;
            this.checkedListBoxTo.Location = new System.Drawing.Point(114, 125);
            this.checkedListBoxTo.Name = "checkedListBoxTo";
            this.checkedListBoxTo.Size = new System.Drawing.Size(83, 148);
            this.checkedListBoxTo.TabIndex = 4;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelFrom.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrom.Location = new System.Drawing.Point(28, 103);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(41, 17);
            this.labelFrom.TabIndex = 5;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.Color.Transparent;
            this.labelTo.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTo.Location = new System.Drawing.Point(135, 103);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(23, 17);
            this.labelTo.TabIndex = 6;
            this.labelTo.Text = "To";
            // 
            // labelPaths
            // 
            this.labelPaths.AutoSize = true;
            this.labelPaths.BackColor = System.Drawing.Color.Transparent;
            this.labelPaths.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPaths.Location = new System.Drawing.Point(19, 295);
            this.labelPaths.Name = "labelPaths";
            this.labelPaths.Size = new System.Drawing.Size(63, 17);
            this.labelPaths.TabIndex = 7;
            this.labelPaths.Text = "Progress";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 316);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(301, 119);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // linksLabel
            // 
            this.linksLabel.AutoSize = true;
            this.linksLabel.BackColor = System.Drawing.Color.Transparent;
            this.linksLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linksLabel.Location = new System.Drawing.Point(276, 103);
            this.linksLabel.Name = "linksLabel";
            this.linksLabel.Size = new System.Drawing.Size(121, 17);
            this.linksLabel.TabIndex = 10;
            this.linksLabel.Text = "Links Information";
            // 
            // button1stAlgorithm
            // 
            this.button1stAlgorithm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1stAlgorithm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1stAlgorithm.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1stAlgorithm.Location = new System.Drawing.Point(522, 121);
            this.button1stAlgorithm.Name = "button1stAlgorithm";
            this.button1stAlgorithm.Size = new System.Drawing.Size(154, 44);
            this.button1stAlgorithm.TabIndex = 11;
            this.button1stAlgorithm.Text = "1st algorithm";
            this.button1stAlgorithm.UseVisualStyleBackColor = false;
            this.button1stAlgorithm.Click += new System.EventHandler(this.button1stAlgorithm_Click);
            // 
            // button2ndAlgorithm
            // 
            this.button2ndAlgorithm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2ndAlgorithm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2ndAlgorithm.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2ndAlgorithm.Location = new System.Drawing.Point(522, 181);
            this.button2ndAlgorithm.Name = "button2ndAlgorithm";
            this.button2ndAlgorithm.Size = new System.Drawing.Size(154, 44);
            this.button2ndAlgorithm.TabIndex = 12;
            this.button2ndAlgorithm.Text = "2nd algorithm";
            this.button2ndAlgorithm.UseVisualStyleBackColor = false;
            this.button2ndAlgorithm.Click += new System.EventHandler(this.button2ndAlgorithm_Click);
            // 
            // button3rdAlgorithm
            // 
            this.button3rdAlgorithm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3rdAlgorithm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3rdAlgorithm.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3rdAlgorithm.Location = new System.Drawing.Point(522, 240);
            this.button3rdAlgorithm.Name = "button3rdAlgorithm";
            this.button3rdAlgorithm.Size = new System.Drawing.Size(154, 44);
            this.button3rdAlgorithm.TabIndex = 13;
            this.button3rdAlgorithm.Text = "3rd algorithm";
            this.button3rdAlgorithm.UseVisualStyleBackColor = false;
            this.button3rdAlgorithm.Click += new System.EventHandler(this.button3rdAlgorithm_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(215, 125);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 130);
            this.listBox1.TabIndex = 14;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(320, 316);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(356, 119);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearButton.BackgroundImage")));
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(570, 441);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 31);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 483);
            this.Controls.Add(this.clearButton);
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
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Building Paths";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button clearButton;
    }
}

