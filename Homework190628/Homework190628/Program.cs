using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework190628
{
    enum Language
    {
        English,
        Japanese = 3,
        Vietnamese,
        Chinese
    }

    enum Company
    {
        Samsung,
        Apple,
        Google,
        Singma,
        Merck
    }

    class Program
    {
        static void Main(string[] args)
        {
            loopPlay();
            Console.ReadLine();
        }

        static string userInput(string mess)
        {
            Console.WriteLine("Please input a {0}",mess);
            return Console.ReadLine();
        }

        static Company switchCheck(int check)
        {
            switch (check)
            {
                case 1:
                    return loopNameCheck();
                case 2:
                    return loopValueCheck();
                case 3:
                    return loopCheck();
                default:
                    Console.WriteLine("System crash!! Please check the number of the method");
                    return 0;
            }
        }

        static Company loopNameCheck()
        {
            do
            {
                string str = userInput("company name");
                if (Enum.IsDefined(typeof(Company), str))
                    return (Company)Enum.Parse(typeof(Company), str);
                else
                    Console.WriteLine("Plese input the company name again");
            } while (true);
        }

        static Company loopValueCheck()
        {
            do
            {
                string str = userInput("value");
                if (Enum.IsDefined(typeof(Company), int.Parse(str)))
                    return (Company)Enum.Parse(typeof(Company), str);
                else
                    Console.WriteLine("Plese input the value again");
            } while (true);
        }

        static Company loopCheck()
        {
            do
            {
                string str = userInput("company name or value");
                if (Enum.IsDefined(typeof(Company), int.Parse(str)) || Enum.IsDefined(typeof(Company), str))
                    return (Company)Enum.Parse(typeof(Company), str);
                else
                    Console.WriteLine("Plese input the company name or value again");
            } while (true);
        }

        static void enumCheck()
        {
            Company companyName = switchCheck(1);
            Company companyNumber = switchCheck(2);

            Console.WriteLine("The company {0} has the value {0:D}", companyName);
            Console.WriteLine("The value {0:D} is the company {0}",companyNumber);
            if (companyNumber == companyName)
                Console.WriteLine("Your input is the same");
            else
                Console.WriteLine("Your input is not the same");
        }

        static void nextEnum()
        {
            Company value = switchCheck(3);
            Array companies = Enum.GetValues(typeof(Company));
            for (int i = 0; i < companies.Length; i++)
            {
                if(i + 1 < companies.Length)
                    Console.WriteLine("The next company of the list is: {0}", companies.GetValue(i+1));
                else if (i > 0)
                    Console.WriteLine("The next company of the list is: {0}", companies.GetValue(0));
            }

        }

        static void loopPlay()
        {
            string check;
            do
            {
                //enumCheck();
                nextEnum();
                do
                {
                    Console.WriteLine("Do you want to play again? y/n");
                    check = Console.ReadLine().ToUpper();
                    if (check == "Y" || check == "N")
                        break;
                    else
                    {
                        Console.WriteLine("I don't understand");
                        continue;
                    }
                } while (true);
            } while (check != "N");
            Console.WriteLine("Thank you for playing!!!");
        }
    }
}
