using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework190602
{
    class Program
    {
        static void Main(string[] args)
        {
            sayHello();
            sayHelloTo("Nhan");
            Console.WriteLine(divide(6,5));
            countEven(a:20,b: 32,c: 35);
            FavoriteDrinks();
            Console.ReadLine();
        }

        static void sayHello()
        {
            Console.WriteLine("Hello, World!");
        }

        static void sayHelloTo(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        static double divide(int a, int b)
        {
            return a / b;
        }

        static int countEven(int a, int b, int c)
        {
            int d = 0;
            if (a % 2 == 0)
                d += 1;
            if (b % 2 == 0)
                d += 1;
            if (a % 2 == 0)
                c += 1;
            return d;
        }

        static int inputSelection()
        {
            return int.Parse(Console.ReadLine());

        }

        static void showDrink(int selection)
        {
            switch(selection)
            {
                case 1:
                    Console.WriteLine("You choose Milk tea");
                    break;
                case 2:
                    Console.WriteLine("You choose Tea");
                    break;
                case 3:
                    Console.WriteLine("You choose Coffee");
                    break;
                case 4:
                    Console.WriteLine("You choose Soda");
                    break;
                default:
                    Console.WriteLine("Nothing on menu");
                    break;
            }
        }

        static void FavoriteDrinks()
        {
            Console.WriteLine("What is your favourite drink?" + Environment.NewLine
                + "\t1. Milk tea" + Environment.NewLine
                + "\t2. Tea" + Environment.NewLine
                + "\t3. Coffee" + Environment.NewLine
                + "\t4. Soda" + Environment.NewLine);
            int selection = inputSelection();
            showDrink(selection);
        }
    }
}
