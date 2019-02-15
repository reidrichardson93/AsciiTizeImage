namespace AsciifyForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainOFD = new System.Windows.Forms.OpenFileDialog();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.greyscaleButton = new System.Windows.Forms.Button();
            this.asciifyButton = new System.Windows.Forms.Button();
            this.kernelWidth = new System.Windows.Forms.NumericUpDown();
            this.kernelHeight = new System.Windows.Forms.NumericUpDown();
            this.greyscalePictureBox = new System.Windows.Forms.PictureBox();
            this.originalButton = new System.Windows.Forms.Button();
            this.kernelWLabel = new System.Windows.Forms.Label();
            this.kernelHLabel = new System.Windows.Forms.Label();
            this.asciiTextBox = new System.Windows.Forms.RichTextBox();
            this.charBox2 = new System.Windows.Forms.TextBox();
            this.charBox3 = new System.Windows.Forms.TextBox();
            this.charBox1 = new System.Windows.Forms.TextBox();
            this.charBox4 = new System.Windows.Forms.TextBox();
            this.charBox5 = new System.Windows.Forms.TextBox();
            this.charBox6 = new System.Windows.Forms.TextBox();
            this.charLabel1 = new System.Windows.Forms.Label();
            this.charLabel3 = new System.Windows.Forms.Label();
            this.charLabel2 = new System.Windows.Forms.Label();
            this.charLabel4 = new System.Windows.Forms.Label();
            this.charLabel5 = new System.Windows.Forms.Label();
            this.charLabel6 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyscalePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1574, 40);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(170, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // mainOFD
            // 
            this.mainOFD.FileName = "openFileDialog1";
            this.mainOFD.FileOk += new System.ComponentModel.CancelEventHandler(this.mainOFD_FileOk);
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.originalPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.originalPictureBox.Location = new System.Drawing.Point(10, 67);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(785, 640);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalPictureBox.TabIndex = 1;
            this.originalPictureBox.TabStop = false;
            // 
            // greyscaleButton
            // 
            this.greyscaleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.greyscaleButton.Location = new System.Drawing.Point(705, 759);
            this.greyscaleButton.Name = "greyscaleButton";
            this.greyscaleButton.Size = new System.Drawing.Size(190, 90);
            this.greyscaleButton.TabIndex = 16;
            this.greyscaleButton.Text = "Grayscale";
            this.greyscaleButton.Click += new System.EventHandler(this.greyscaleButton_Click);
            // 
            // asciifyButton
            // 
            this.asciifyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.asciifyButton.Enabled = false;
            this.asciifyButton.Location = new System.Drawing.Point(705, 874);
            this.asciifyButton.Name = "asciifyButton";
            this.asciifyButton.Size = new System.Drawing.Size(190, 90);
            this.asciifyButton.TabIndex = 6;
            this.asciifyButton.Text = "ASCII-fy";
            this.asciifyButton.UseVisualStyleBackColor = true;
            this.asciifyButton.Click += new System.EventHandler(this.asciifyButton_Click);
            // 
            // kernelWidth
            // 
            this.kernelWidth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.kernelWidth.Location = new System.Drawing.Point(475, 818);
            this.kernelWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kernelWidth.Name = "kernelWidth";
            this.kernelWidth.Size = new System.Drawing.Size(120, 31);
            this.kernelWidth.TabIndex = 7;
            this.kernelWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kernelHeight
            // 
            this.kernelHeight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.kernelHeight.Location = new System.Drawing.Point(475, 874);
            this.kernelHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kernelHeight.Name = "kernelHeight";
            this.kernelHeight.Size = new System.Drawing.Size(120, 31);
            this.kernelHeight.TabIndex = 8;
            this.kernelHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // greyscalePictureBox
            // 
            this.greyscalePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.greyscalePictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.greyscalePictureBox.Location = new System.Drawing.Point(10, 67);
            this.greyscalePictureBox.Name = "greyscalePictureBox";
            this.greyscalePictureBox.Size = new System.Drawing.Size(785, 638);
            this.greyscalePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greyscalePictureBox.TabIndex = 9;
            this.greyscalePictureBox.TabStop = false;
            this.greyscalePictureBox.Visible = false;
            // 
            // originalButton
            // 
            this.originalButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.originalButton.Location = new System.Drawing.Point(705, 759);
            this.originalButton.Name = "originalButton";
            this.originalButton.Size = new System.Drawing.Size(190, 90);
            this.originalButton.TabIndex = 15;
            this.originalButton.Text = "Original";
            this.originalButton.Click += new System.EventHandler(this.originalButton_Click);
            // 
            // kernelWLabel
            // 
            this.kernelWLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.kernelWLabel.AutoSize = true;
            this.kernelWLabel.Location = new System.Drawing.Point(314, 820);
            this.kernelWLabel.Name = "kernelWLabel";
            this.kernelWLabel.Size = new System.Drawing.Size(135, 25);
            this.kernelWLabel.TabIndex = 12;
            this.kernelWLabel.Text = "Kernel Width";
            // 
            // kernelHLabel
            // 
            this.kernelHLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.kernelHLabel.AutoSize = true;
            this.kernelHLabel.Location = new System.Drawing.Point(314, 876);
            this.kernelHLabel.Name = "kernelHLabel";
            this.kernelHLabel.Size = new System.Drawing.Size(142, 25);
            this.kernelHLabel.TabIndex = 13;
            this.kernelHLabel.Text = "Kernel Height";
            // 
            // asciiTextBox
            // 
            this.asciiTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.asciiTextBox.Font = new System.Drawing.Font("Consolas", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asciiTextBox.Location = new System.Drawing.Point(805, 67);
            this.asciiTextBox.Name = "asciiTextBox";
            this.asciiTextBox.ReadOnly = true;
            this.asciiTextBox.Size = new System.Drawing.Size(785, 640);
            this.asciiTextBox.TabIndex = 14;
            this.asciiTextBox.Text = "";
            this.asciiTextBox.WordWrap = false;
            // 
            // charBox2
            // 
            this.charBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.charBox2.Location = new System.Drawing.Point(1059, 789);
            this.charBox2.MaxLength = 1;
            this.charBox2.Name = "charBox2";
            this.charBox2.Size = new System.Drawing.Size(50, 31);
            this.charBox2.TabIndex = 17;
            this.charBox2.Text = ".";
            // 
            // charBox3
            // 
            this.charBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.charBox3.Location = new System.Drawing.Point(1059, 822);
            this.charBox3.MaxLength = 1;
            this.charBox3.Name = "charBox3";
            this.charBox3.Size = new System.Drawing.Size(50, 31);
            this.charBox3.TabIndex = 18;
            this.charBox3.Text = ":";
            // 
            // charBox1
            // 
            this.charBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.charBox1.Location = new System.Drawing.Point(1059, 748);
            this.charBox1.MaxLength = 1;
            this.charBox1.Name = "charBox1";
            this.charBox1.Size = new System.Drawing.Size(50, 31);
            this.charBox1.TabIndex = 19;
            this.charBox1.Text = " ";
            // 
            // charBox4
            // 
            this.charBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.charBox4.Location = new System.Drawing.Point(1059, 859);
            this.charBox4.MaxLength = 1;
            this.charBox4.Name = "charBox4";
            this.charBox4.Size = new System.Drawing.Size(50, 31);
            this.charBox4.TabIndex = 20;
            this.charBox4.Text = "/";
            // 
            // charBox5
            // 
            this.charBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.charBox5.Location = new System.Drawing.Point(1059, 896);
            this.charBox5.MaxLength = 1;
            this.charBox5.Name = "charBox5";
            this.charBox5.Size = new System.Drawing.Size(50, 31);
            this.charBox5.TabIndex = 21;
            this.charBox5.Text = "%";
            // 
            // charBox6
            // 
            this.charBox6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.charBox6.Location = new System.Drawing.Point(1059, 933);
            this.charBox6.MaxLength = 1;
            this.charBox6.Name = "charBox6";
            this.charBox6.Size = new System.Drawing.Size(50, 31);
            this.charBox6.TabIndex = 22;
            this.charBox6.Text = "#";
            // 
            // charLabel1
            // 
            this.charLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.charLabel1.AutoSize = true;
            this.charLabel1.Location = new System.Drawing.Point(998, 751);
            this.charLabel1.Name = "charLabel1";
            this.charLabel1.Size = new System.Drawing.Size(55, 25);
            this.charLabel1.TabIndex = 23;
            this.charLabel1.Text = "0-10";
            // 
            // charLabel3
            // 
            this.charLabel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.charLabel3.AutoSize = true;
            this.charLabel3.Location = new System.Drawing.Point(986, 825);
            this.charLabel3.Name = "charLabel3";
            this.charLabel3.Size = new System.Drawing.Size(67, 25);
            this.charLabel3.TabIndex = 24;
            this.charLabel3.Text = "20-40";
            // 
            // charLabel2
            // 
            this.charLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.charLabel2.AutoSize = true;
            this.charLabel2.Location = new System.Drawing.Point(986, 788);
            this.charLabel2.Name = "charLabel2";
            this.charLabel2.Size = new System.Drawing.Size(67, 25);
            this.charLabel2.TabIndex = 25;
            this.charLabel2.Text = "10-20";
            // 
            // charLabel4
            // 
            this.charLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.charLabel4.AutoSize = true;
            this.charLabel4.Location = new System.Drawing.Point(986, 862);
            this.charLabel4.Name = "charLabel4";
            this.charLabel4.Size = new System.Drawing.Size(67, 25);
            this.charLabel4.TabIndex = 26;
            this.charLabel4.Text = "40-60";
            // 
            // charLabel5
            // 
            this.charLabel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.charLabel5.AutoSize = true;
            this.charLabel5.Location = new System.Drawing.Point(986, 899);
            this.charLabel5.Name = "charLabel5";
            this.charLabel5.Size = new System.Drawing.Size(67, 25);
            this.charLabel5.TabIndex = 27;
            this.charLabel5.Text = "60-80";
            // 
            // charLabel6
            // 
            this.charLabel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.charLabel6.AutoSize = true;
            this.charLabel6.Location = new System.Drawing.Point(968, 936);
            this.charLabel6.Name = "charLabel6";
            this.charLabel6.Size = new System.Drawing.Size(85, 25);
            this.charLabel6.TabIndex = 28;
            this.charLabel6.Text = "80 -100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1070);
            this.Controls.Add(this.charLabel6);
            this.Controls.Add(this.charLabel5);
            this.Controls.Add(this.charLabel4);
            this.Controls.Add(this.charLabel2);
            this.Controls.Add(this.charLabel3);
            this.Controls.Add(this.charLabel1);
            this.Controls.Add(this.charBox6);
            this.Controls.Add(this.charBox5);
            this.Controls.Add(this.charBox4);
            this.Controls.Add(this.charBox1);
            this.Controls.Add(this.charBox3);
            this.Controls.Add(this.charBox2);
            this.Controls.Add(this.asciiTextBox);
            this.Controls.Add(this.kernelHLabel);
            this.Controls.Add(this.kernelWLabel);
            this.Controls.Add(this.originalButton);
            this.Controls.Add(this.greyscalePictureBox);
            this.Controls.Add(this.kernelHeight);
            this.Controls.Add(this.kernelWidth);
            this.Controls.Add(this.asciifyButton);
            this.Controls.Add(this.greyscaleButton);
            this.Controls.Add(this.originalPictureBox);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "ASCII-fy Image";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyscalePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog mainOFD;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.Button greyscaleButton;
        private System.Windows.Forms.Button asciifyButton;
        private System.Windows.Forms.NumericUpDown kernelWidth;
        private System.Windows.Forms.NumericUpDown kernelHeight;
        private System.Windows.Forms.PictureBox greyscalePictureBox;
        private System.Windows.Forms.Button originalButton;
        private System.Windows.Forms.Label kernelWLabel;
        private System.Windows.Forms.Label kernelHLabel;
        private System.Windows.Forms.RichTextBox asciiTextBox;
        private System.Windows.Forms.TextBox charBox2;
        private System.Windows.Forms.TextBox charBox3;
        private System.Windows.Forms.TextBox charBox1;
        private System.Windows.Forms.TextBox charBox4;
        private System.Windows.Forms.TextBox charBox5;
        private System.Windows.Forms.TextBox charBox6;
        private System.Windows.Forms.Label charLabel1;
        private System.Windows.Forms.Label charLabel3;
        private System.Windows.Forms.Label charLabel2;
        private System.Windows.Forms.Label charLabel4;
        private System.Windows.Forms.Label charLabel5;
        private System.Windows.Forms.Label charLabel6;
    }
}

