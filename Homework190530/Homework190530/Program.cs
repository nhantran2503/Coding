using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework190530
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cau 1
            Console.WriteLine("Cau 1");
            nameData();

            // Cau 2
            Console.WriteLine("\nCau 2");
            nameData("cau2");

            //cau 3
            Console.WriteLine("\nCau 3");
            uint number3 = numberInput();
            for (uint counting = 1; counting <= number3; ++counting)
                Console.Write("{0} ", counting);

            //cau 4
            Console.WriteLine("\n\nCau 4");
            for (int a = 2; a <= 10; a += 2)
                Console.Write("{0} ", a);

            //cau 5 
            Console.WriteLine("\n\nCau 5");
            uint numberCau5 = numberInput();
            uint total = 0;
            for (uint counting = 1; counting <= numberCau5; ++counting)
            {
                Console.Write("{0} ", counting);
                total += counting;
            }
            Console.WriteLine("\nThe sum of all number is: {0}", total);

            //cau 6
            Console.WriteLine("\nCau 6");
            uint numberCau6 = numberInput();
            uint m = 0;
            for (uint i = 2; i <= numberCau6 / 2; i++)
            {
                if (numberCau6 % i == 0)
                {
                    Console.WriteLine("The number is not prime");
                    m = 1;
                    break;
                }
            }
            if (m == 0)
                Console.WriteLine("The number is prime");

            //cau 7
            Console.WriteLine("\nCau 7");
            uint numberCau7 = numberInput();
            Console.WriteLine("Prime numbers from 1 to n");

            for (uint j = 1; j <= numberCau7; j++)
            {
                uint n = 0;
                for (uint i = 2; i <= j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        n = 1;
                        break;
                    }
                }
                if (n == 0)
                    Console.Write("{0} ", j);
            }

            //cau 8
            Console.WriteLine("\n\nCau 8");
            Console.Write("Even date of May: ");
            for (int i = 2; i <= 31; i += 2)
            {
                Console.Write("{0} ", i);
            }

            //cau 9
            Console.WriteLine("\n\nCau 9");
            Console.WriteLine("Divisible by 3 and 4 date of May");
            for (int i = 1; i <= 31; ++i)
            {
                if (i % 3 == 0)
                    Console.Write("{0} ", i);
                else if (i % 4 == 0)
                    Console.Write("{0} ", i);
            }

            //cau 10
            Console.WriteLine("\n\nCau 10");
            Console.WriteLine("Date of May that is not divisible by 3");
            for (int i = 1; i <= 31; ++i)
            {
                if (i % 3 != 0)
                    Console.Write("{0} ", i);
            }

            //cau 11
            Console.WriteLine("\n\nCau 11");
            Console.WriteLine("Date of May that is not divisible by 3");
            for (int i = 1; i <= 31; ++i)
            {
                if (i % 3 == 0)
                    continue;
                Console.Write("{0} ", i);
            }

            //cau 12
            Console.WriteLine("\n\nCau 12");
            Console.WriteLine("Even date of May");
            for (int i = 2; i <= 31; i += 2)
            {
                Console.Write("{0} ", i);
            }

            //cau 13
            Console.WriteLine("\n\nCau 13");
            Console.WriteLine("Date of May");
            string evenDay = " ";
            string oddDay = " ";
            for (int i = 1; i <= 31; i += 1)
            {
                if (i % 2 == 0)
                {
                    evenDay += " ";
                    evenDay += i;
                }
                else
                {
                    oddDay += " ";
                    oddDay += i;
                }
            }
            Console.WriteLine(oddDay);
            Console.WriteLine(evenDay);

            //cau 14
            Console.WriteLine("\nCau 14");
            int x = new Random().Next(1, 101);
            int z = 0;
            Console.WriteLine("I have a number from 1 to 100, guess which it is\n");
            do
            {
                Console.Write("Please input your number: ");
                int y = int.Parse(Console.ReadLine());
                if (x == y)
                {
                    Console.WriteLine("\nCongrats, you have won!!");
                    Console.WriteLine("You have tried {0} times", z);
                    break;
                }
                else if (x < y)
                {
                    Console.WriteLine("Your number is bigger than mine");
                    z += 1;
                    continue;
                }
                else
                {
                    Console.WriteLine("Your number is smaller than mine");
                    z += 1;
                    continue;
                }
            } while (true);

            //cau 15
            Console.WriteLine("\nCau 15");
            string exit;
            do
            {
                int x2 = new Random().Next(1, 101);
                int z2 = 0;
                Console.WriteLine("I have a number from 1 to 100, guess which it is\n");
                do
                {
                    Console.Write("Please input your number: ");
                    int y2 = int.Parse(Console.ReadLine());
                    if (x2 == y2)
                    {
                        Console.WriteLine("\nCongrats, you have won!!");
                        Console.WriteLine("You have tried {0} times", z2);
                        break;
                    }
                    else if (x2 < y2)
                    {
                        Console.WriteLine("Your number is bigger than mine");
                        z2 += 1;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Your number is smaller than mine");
                        z2 += 1;
                        continue;
                    }
                } while (true);
                Console.Write("Do you want to play again? y/n: ");
                while (true)
                {
                    switch (exit = Console.ReadLine().ToUpper())
                    {
                        case "Y":
                            Console.WriteLine("Have fun\n");
                            break;
                        case "N":
                            Console.WriteLine("See ya");
                            break;
                        default:
                            Console.WriteLine("I dont't understand\n");
                            continue;
                    }
                    break;
                }
            } while (exit != "N");


            Console.ReadLine();
        }

        static void nameData()
        {
            Console.WriteLine("Your favorite people include:" + Environment.NewLine
                + "\t1. Superman" + Environment.NewLine
                + "\t2. Batman" + Environment.NewLine
                + "\t3. Wonderwoman" + Environment.NewLine
                + "\t4. Flash" + Environment.NewLine);
            do
            {
                string input = inputValue();
                showPerson(input);
                if (input == "x")
                    break;
            } while (true);
        }

        static void nameData(string mess)
        {
            Console.WriteLine("Your favorite people include:" + Environment.NewLine
                + "\t1. Superman" + Environment.NewLine
                + "\t2. Batman" + Environment.NewLine
                + "\t3. Wonderwoman" + Environment.NewLine
                + "\t4. Flash" + Environment.NewLine);
            int number1=0;
            int number2=0;
            int number3=0;
            int number4=0;
            do
            {
                string input = inputValue().ToUpper();
                showPerson(input, number1, number2, number3, number4);
                if (input == "1")
                    ++number1;
                else if (input == "2")
                    ++number2;
                else if (input == "3")
                    ++number3;
                else if (input == "4")
                    ++number4;
                if ((input == "X") || (input == "QUIT")) 
                    break;
            } while (true);
        }

        static string inputValue()
        {
            string input;
            Console.WriteLine("Input the number you want to see");
            Console.WriteLine("End with x");
            return input = Console.ReadLine();
        }

        static void showPerson(string input)
        {
            switch (input)
            {
                case "1":
                    Console.WriteLine("This is Superman");
                    break;
                case "2":
                    Console.WriteLine("This is Batman");
                    break;
                case "3":
                    Console.WriteLine("This is Wonderwoman");
                    break;
                case "4":
                    Console.WriteLine("This is Flash");
                    break;
                case "x":
                    Console.WriteLine("End program");
                    break;
                default:
                    Console.WriteLine("No data");
                    break;
            }
        }

        static void showPerson(string input, int number1, int number2, int number3, int number4)
        {
            switch (input)
            {
                case "1":
                    if (number1 != 0)
                        Console.WriteLine("Already told");
                    else
                        Console.WriteLine("This is Superman");
                    break;
                case "2":
                    if (number2 != 0)
                        Console.WriteLine("Already told");
                    else
                        Console.WriteLine("This is Batman");
                    break;
                case "3":
                    if (number3 != 0)
                        Console.WriteLine("Already told");
                    else
                        Console.WriteLine("This is Wonderwoman");
                    break;
                case "4":
                    if (number4 != 0)
                        Console.WriteLine("Already told");
                    else
                        Console.WriteLine("This is Flash");
                    break;
                case "X":
                case "QUIT":
                    Console.WriteLine("End program");
                    break;
                default:
                    Console.WriteLine("No data");
                    break;
            }
        }
        
        static uint numberInput()
        {
            Console.Write("Please input a number: ");
            return uint.Parse(Console.ReadLine());
        }
        
    }
}
