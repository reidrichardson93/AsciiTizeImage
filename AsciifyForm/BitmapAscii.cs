using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AsciifyForm
{
    //This class has all the necessary components to convert a 
    class BitmapAscii
    {
        private StringBuilder asciiString = new StringBuilder();
        

        //Asciitize method that accepts a bitmap and returns a string
        //string contains the ascii text version of the picture
        public string Asciitize(Bitmap colorMap, int kernelHeight, int kernelWidth, string[] asciiChars){
            
            //looping through the bitmap one kernel at a time
            for (int i = 0; i < colorMap.Height; i += kernelHeight){
                for(int j = 0; j < colorMap.Width; j += kernelWidth){
                    //double variable to hold the normalized value
                    //list of colors to be passed to AverageColor()
                    double normValue = 0.0;
                    List<Color> kernelList = new List<Color>();
                    if (kernelHeight > 1 || kernelWidth > 1){
                        //looping through each kernel
                        for (int y = 0; y < kernelHeight; y++){
                            for (int x = 0; x < kernelWidth; x++){
                                //pulling each pixel in the kernel one at a time
                                //then adding them to the color list
                                if (x + j >= colorMap.Width || y + i >= colorMap.Height){

                                }else{
                                    Color tempC = colorMap.GetPixel((x + j), (y + i));
                                    kernelList.Add(tempC);
                                }
                            }
                        }
                        normValue = AverageColor(kernelList);
                    }else{
                        normValue = AveragePixel(colorMap.GetPixel(j, i));
                    }
                    //calling average color to get normalized value
                    //then passing normalized value to GrayToString
                    //to build the new ascii string
                    asciiString.Append(GrayToString(normValue, asciiChars));
                }
                //preserving the structure of the image
                asciiString.Append("\n");
            }
            return asciiString.ToString();
        }

        //AveragePixel method that takes the rgb values of a pixel then
        //returns a normalized value of the gray (0-1) as a double
        private double AveragePixel(int r, int g, int b){
            double avg = (r + g + b) / 3;
            return (1 - (avg / 255.0));
        }

        //AveragePixel overload method that accepts a full color object
        //instead of the rgb values then
        //returns a normalized value of the gray (0-1) as a double
        private double AveragePixel(Color tempC){
            double avg = (tempC.R + tempC.G + tempC.B) / 3;
            return (1 - (avg / 255.0));
        }

        //AverageColor methos that accepts a list of colors then
        //returns a single average color as a normalized value (0-1)
        private double AverageColor(List<Color> colorList){
            double average = 0.0;
            for(int i = 0; i < colorList.Count; i++){
                average += AveragePixel(colorList[i]);
            }
            average = average / colorList.Count;
            return average;
        }

        //GrayToString method that accepts a double and returns
        //an ascii char in the form of a string
        private string GrayToString(double normalizedValue, string[] asciiChars){

            //initializing string to be output
            string output = "";
            //if else statement that breaks up the normalized value scale
            //into 6 different sections then sets output to a char
            //with a similar amount of "ink"
            if (normalizedValue >= 0 && normalizedValue < 0.10){
                output = asciiChars[0];
            }else if (normalizedValue >= 0.10 && normalizedValue < 0.20){
                output = asciiChars[1];
            }else if (normalizedValue >= 0.20 && normalizedValue < 0.40){
                output = asciiChars[2];
            }else if (normalizedValue >= 0.40 && normalizedValue < 0.60){
                output = asciiChars[3];
            }else if (normalizedValue >= 0.60 && normalizedValue < 0.80){
                output = asciiChars[4];
            }else if (normalizedValue >= 0.80 && normalizedValue <= 1){
                output = asciiChars[5];
            }
            return output;
        }

        //overriding/overloading ToString() method so it returns the
        //ascii image string
        public override string ToString(){
            
            return asciiString.ToString();
        }

    }
}
