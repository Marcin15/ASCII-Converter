using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Converter
{
    public class ConsoleReader
    {
        public static string Read()
        {
            string readMessage = null;
            do
            {
                if(readMessage is not null)
                {
                    if (!ValidateEnteredTextMessage(readMessage))
                    {
                        Console.WriteLine("Entered format is incorrect. Please enter your message again");
                        Console.ReadKey();
                    }
                }

                Console.Clear();

                Console.WriteLine("Enter text message you want to convert to ASCII art. You can only use letters.");
                readMessage = Console.ReadLine().ToUpper();

            } while (!ValidateEnteredTextMessage(readMessage));

            return readMessage;
        }

        private static bool ValidateEnteredTextMessage(string enteredMessage)
        {
            for (int i = 0; i < enteredMessage.Length; i++)
            {
                if(enteredMessage[i] >= 65 && enteredMessage[i] <= 90)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
