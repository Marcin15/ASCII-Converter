using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Converter
{
    public class FontReader
    {
        private string[] content;
        public string[] Content 
        { 
            get 
            {
                return content;
            } 
            private set { } 
        }
        public int HeightOfFont { 
            get 
            {
                return ReadHeightOfFont(content[0]);
            }
            private set { } 
        }
        public int WidthOfFont 
        {
            get
            {
                return ReadWidthOfFont(content[0]);
            }
            private set { } 
        }

        public FontReader(string path)
        {
            content = ReadFile(path);
        }
        private string[] ReadFile(string path) => content = File.ReadAllLines(path);
        private int ReadHeightOfFont(string line)
        {
            var heightOfFontStr = line.Split(' ');

            if (int.TryParse(heightOfFontStr[0], out int heightOfFont))
            {
                return heightOfFont;
            }
            else
            {
                return 0;
            }
        }

        private int ReadWidthOfFont(string line)
        {
            var heightOfFontStr = line.Split(' ');

            if (int.TryParse(heightOfFontStr[1], out int heightOfFont))
            {
                return heightOfFont;
            }
            else
            {
                return 0;
            }
        }
    }
}
