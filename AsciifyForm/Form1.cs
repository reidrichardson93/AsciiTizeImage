using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsciifyForm
{
    public partial class Form1 : Form
    {
        //declaring class members
        Bitmap originalMap;
        Bitmap grayscaleMap;
        public Form1()
        {
            InitializeComponent();
            originalButton.Hide();
            greyscaleButton.Enabled = false;
            //correctly sizing the display boxes on the form
            Form1_SizeChanged( this, new EventArgs() );
        }

        //open button in the menu strip opens the open file dialogue event
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainOFD.ShowDialog();
        }

        private void mainOFD_FileOk(object sender, CancelEventArgs e)
        {
            newToolStripMenuItem_Click(this, new EventArgs());
            string filePath = mainOFD.FileName;
            if (filePath.EndsWith(".ppm")){
                BitmapBuilder buildMap = new BitmapBuilder(filePath);
                originalMap = buildMap.ppmToBitmap();
                kernelWidth.Maximum = originalMap.Width - 1;
                kernelHeight.Maximum = originalMap.Height - 1;
            }else{
                originalMap = new Bitmap(filePath);
                kernelWidth.Maximum = originalMap.Width - 1;
                kernelHeight.Maximum = originalMap.Height - 1;
            }
            originalPictureBox.Image = originalMap;
            greyscaleButton.Enabled = true;
            asciifyButton.Enabled = true;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int border = originalPictureBox.Left;
            originalPictureBox.Width = (Width / 2) - (border * 2);
            asciiTextBox.Left = originalPictureBox.Left + originalPictureBox.Width + border;
            asciiTextBox.Size = originalPictureBox.Size; 
            greyscalePictureBox.Size = originalPictureBox.Size;
            asciiTextBox.Width = originalPictureBox.Width - (int)(border * 0.70);
            
            
        }

        private void originalButton_Click(object sender, EventArgs e)
        {
            greyscalePictureBox.Hide();
            originalPictureBox.Show();
            greyscaleButton.Show();
            originalButton.Hide();

        }

        private void asciifyButton_Click(object sender, EventArgs e)
        {
            greyscaleButton_Click(this, new EventArgs());
            BitmapAscii asciiBuilder = new BitmapAscii();
            string[] asciiChars = {charBox1.Text, charBox2.Text, charBox3.Text, charBox4.Text, charBox5.Text, charBox6.Text};
            asciiTextBox.Text = asciiBuilder.Asciitize(originalMap, (int)kernelHeight.Value, (int)kernelWidth.Value, asciiChars);
            asciiTextBox.MaxLength = originalMap.Width;
        }

        private void greyscaleButton_Click(object sender, EventArgs e)
        {
            if (greyscalePictureBox.Image == null){
                grayscaleMap = colorToGrayScale(originalMap);
                greyscalePictureBox.Image = grayscaleMap;
            }
            greyscalePictureBox.Show();
            originalPictureBox.Hide();
            greyscaleButton.Hide();
            originalButton.Show();
        }

        private Bitmap colorToGrayScale(Bitmap colorMap){
            Bitmap grayMap = new Bitmap(colorMap.Width, colorMap.Height);
            for (int y = 0; y < colorMap.Height; y++){
                for (int x = 0; x < colorMap.Width; x++){
                    Color tempC = colorMap.GetPixel(x, y);
                    int avg = (tempC.R + tempC.G + tempC.B) / 3;
                    grayMap.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            }
            return grayMap;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asciifyButton.Enabled = false;
            greyscaleButton.Enabled = false;
            originalButton_Click(this, new EventArgs());
            kernelHeight.Value = 1;
            kernelWidth.Value = 1;
            originalMap = null;
            grayscaleMap = null;
            originalPictureBox.Image = null;
            greyscalePictureBox.Image = null;
            asciiTextBox.Text = null;
            charBox1.Text = " ";
            charBox2.Text = ".";
            charBox3.Text = ":";
            charBox4.Text = "/";
            charBox5.Text = "%";
            charBox6.Text = "#";
        }


    }
}
