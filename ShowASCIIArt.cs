using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Converter
{
    public class ShowASCIIArt
    {
        public static void Show(int heightOfFont, int widthOfFont, string textToConvert, char[,,] ASCIIart)
        {
            for (int i = 0; i < heightOfFont; i++)
            {
                for (int k = 0; k < textToConvert.Length; k++)
                {
                    int letterPrintingIndex = textToConvert[k] - 'A';

                    for (int j = 0; j < widthOfFont; j++)
                    {
                        
                        Console.Write(ASCIIart[letterPrintingIndex, i, j]);
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
