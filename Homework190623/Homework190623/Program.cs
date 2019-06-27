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

            string num = "";
            calculator(num);


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

        static void calculator(string str)
        {
            double result;
            bool check;
            do
            {
                str = userInput("formular");
                check = inputCheck(str);

            } while (check != true);
            string[] part = stringSeparate(str);
            switchCase(str, double.Parse(part[0]), double.Parse(part[1]), out result);
            Console.WriteLine("The result is: {0}", result);
            Console.WriteLine("Thank you, have a nice day!!");
        }

        static bool inputCheck(string str)
        {
            string[] part = stringSeparate(str);
            int count = 0;
            
            for (int i = 0; i < part.Length; i++)
            {
                if (isNumber(part[i]))
                    count++;
            }
            if (count < 2)
            {
                Console.WriteLine("Please input again");
                return false;
            }
            else
                return true;
        }

        static string[] stringSeparate(string str)
        {
            string[] separator = new string[] { "+", "-", "*", "/", " ", "," };
            return str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }

        static void switchCase(string str, double a, double b, out double c)
        {
            c = 0;
            if (str.Contains("+"))
                c = add(a, b);
            else if (str.Contains("-"))
                c = minus(a, b);
            else if (str.Contains("*"))
                c = multiply(a, b);
            else if (str.Contains("/"))
                divide(a, b, out c);
            else
                Console.WriteLine("Invalid calculator");
        }

        static bool isNumber(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsNumber(str[i])==false)
                    return false;
            }
            return true;
        }

        static double add(double a, double b)
        {
            return a + b;
        }

        static double minus(double a, double b)
        {
            return a - b;
        }

        static double multiply(double a, double b)
        {
            return a * b;
        }

        static bool divide(double a, double b, out double c)
        {
            if (b == 0)
            {
                c = 0;
                Console.WriteLine("Invalid value");
                return false;
            }
            else
            {
                c = a / b;
                return true;
            }
        }
    }
}
