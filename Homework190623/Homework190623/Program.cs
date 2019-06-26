using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework190623
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = userInput("message");
            isletterCount(str);
            wordCount(str);

            string num = userInput("formular");

            Console.ReadLine();
        }

        static string userInput(string mess)
        {
            Console.WriteLine("\nPlease input the {0}", mess);
            return Console.ReadLine();
        }

        static void isletterCount(string str)
        {
            int count = 0;
            string letter = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    count++;
                    letter += str[i] + " ";
                }
            }
            Console.WriteLine("There are {0} number of letter, including: {1}", count, letter);
        }

        static bool letterCount(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                    return true;
            }
            return false;
        }

        static void wordCount(string str)
        {
            string[] separator = new string[] { "," ," "};
            string[] part = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            string[] word = new string[str.Length];
            for (int i = 0; i < part.Length; i++)
            {
                if(letterCount(part[i]))
                {
                    if (count == 2)
                        word[count] = part[i].Substring(0, 1).ToUpper() + part[i].Substring(1);
                    else
                        word[count] = part[i];
                    count++;
                }
            }
            string result = string.Join(" ", word);
            Console.WriteLine("The contained words are: " + result);
        }
    }
}
