
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;


namespace AsciifyForm

{
    class BitmapBuilder
    {
        //setting members, both private
        private StreamReader read_file;
        public Bitmap newMap;

        public BitmapBuilder(string path){
            read_file = new StreamReader(path);
        }

        public Bitmap ppmToBitmap(){
            //declaring temp variables
            int[] rgbValues;
            bool run = true;
            //checking to make sure the file is an ASCII format .ppm file
            string currentLine = read_file.ReadLine().ToLower();
            
            if (currentLine != "p3" && currentLine != "p6" ){
                MessageBox.Show("This is not a valid '.ppm' file. Please try opening a new file.");
                run = false;
            }


            //if the file type check is valid then build the bitmap
            if (run){
                read_file.ReadLine(); //disregarding comment line
                currentLine = read_file.ReadLine(); //reading the size of the picture file
                string[] temp = currentLine.Split(); //splitting the size values into a string array
                int width = int.Parse(temp[0]); //parsing the width into an integer
                int height = int.Parse(temp[1]); //parsing the height into an integer
                rgbValues = new int[((width * 3) * height)];
                currentLine = read_file.ReadLine(); //reading the scale line in the header
                newMap = new Bitmap(width, height);

                //looping through three lines of the file at a time pulling each pixel value from the file
                int x = 0;
                int y = 0;
                int z = 0;
                while (!read_file.EndOfStream){

                    //pulling a line(one R, G, or B value) from the file
                    //then scaling the value and rounding the value and casting it to an int
                    currentLine = read_file.ReadLine();
                    rgbValues[z] = int.Parse(currentLine);
                    z++;

                    
                }
                //time to set the pixels
                for (int i = 0; i < rgbValues.Length; i += 3){
                    //creating color value
                    Color tempColor = Color.FromArgb(rgbValues[i], rgbValues[i+1], rgbValues[i+2]);
                    //setting colors to the bitmap one pixel at a time
                    newMap.SetPixel(x,y, tempColor );
                    //incrementing x
                    x++;
                    //when x is at the end of the row reset x and increment y
                    if (x == width){
                        x = 0;
                        y++;
                    }
                }

                

            }
            read_file.Close();
            return newMap;
        }
    }
}
