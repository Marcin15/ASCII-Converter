using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Converter
{
    public class GetASCII
    {
        public static char[,,] Get(int heightOfFont, int widthOfFont, char[,,] ASCIIart, string[] readFile)
        {
            int letterIndex = 0;
            for (int i = 0; i < heightOfFont; i++)
            {
                string ROW = readFile[i + 1];
                for (int j = 0; j < ROW.Length; j++)
                {
                    if (j % widthOfFont == 0 && j != 0)
                    {
                        letterIndex++;
                    }
                    ASCIIart[letterIndex, i, j % widthOfFont] = ROW[j];
                }
                letterIndex = 0;
            }

            return ASCIIart;
        }
    }
}
