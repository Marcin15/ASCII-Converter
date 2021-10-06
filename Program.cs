using System;
using System.IO;

namespace ASCII_Converter
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../Style.txt";
            var fileReader = new FontReader(path);

            string[] content = fileReader.Content;
            int heightOfFont = fileReader.HeightOfFont;
            int widthOfFont = fileReader.WidthOfFont;

            string textToConvert = ConsoleReader.Read();
            char[,,] ASCIIart = new char[27, heightOfFont, widthOfFont];

            ASCIIart = GetASCII.Get(heightOfFont, widthOfFont, ASCIIart, content);
            ShowASCIIArt.Show(heightOfFont,widthOfFont,textToConvert,ASCIIart);

            Console.Read();
        }
    }
}
