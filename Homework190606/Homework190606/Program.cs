using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework190606
{
    class Program
    {
        static void Main(string[] args)
        {
            //cau 1
            Console.WriteLine("Question 1");
            Console.WriteLine(add(1, 2)); //int version
            Console.WriteLine(add(1000, 2));//int version
            Console.WriteLine(add(1, 2000));//int version
            Console.WriteLine(add(1000, 2000));//int version
            Console.WriteLine(add((byte)1, (byte)2));//byte version

            //cau 2
            Console.WriteLine("\nQuestion 2");
            int check2;
            double result2 = power(0, -2, out check2);
            if (check2 == 1)
            {
                Console.WriteLine("Invalid value");
            }
            else
                Console.WriteLine(result2);

            //cau 3
            Console.WriteLine("\nQuestion 3");
            int check3;
            double result3 = power_recursive(5, -2, out check3);
            if (check3 == 1)
            {
                Console.WriteLine("Invalid value");
            }
            else
                Console.WriteLine(result3);

            //cau 4
            Console.WriteLine("\nQuestion 4");
            int check4;
            double result4;
            power_out(4, 3, out result4, out check4);
            //Su dung out vi ket qua ko du doan duoc va da duoc gan trong ham
            if (check4 == 1)
            {
                Console.WriteLine("Invalid value");
            }
            else
                Console.WriteLine(result4);

            //cau 5
            Console.WriteLine("\nQuestion 5");
            int check5;
            double result5;
            power_out_recursive(4, 3, out result5, out check5);
            if (check5 == 1)
            {
                Console.WriteLine("Invalid value");
            }
            else
                Console.WriteLine(result5);
            Console.ReadLine();
        }

        static int add(int a, int b)
        {
            return a + b;
        }

        static int add(byte a, byte b)
        {
            return a + b;
        }

        static int add(int a, byte b)
        {
            return a + b;
        }

        static double power(int a, int b, out int check)
        {
            check = 0;
            double x = 0;
            double a2 = a;
            if(b == 0)
            {
                x = 1;
            }
            else if (b < 0)
            {
                if (a != 0)
                {
                    x = 1 / a2;
                    for (int i = 1; i < Math.Abs(b); ++i)
                        x /= a2;
                }
                else
                    check = 1;
            }
            else
            {
                x = a2;
                for (int i = 1; i < Math.Abs(b); ++i)
                    x *= a2;
            }
            return x;
        }

        static double power_recursive(int a, int b, out int check)
        {
            check = 0;
            double a2 = a;
            if (b == 0)
                return 1;
            else if (b < 0)
            {
                if (a == 0)
                {
                    check = 1;
                    return 0;
                }
                else
                {
                    return (1 / a2) * power_recursive(a, b + 1, out check);
                }
            }
            else
                return a2 * power_recursive(a, b - 1, out check);
        }

        static double power_out(int a, int b, out double c,out int check)
        {
            check = 0;
            c = 0;
            double a2 = a;
            if (b == 0)
            {
                c = 1;
            }
            else if (b < 0)
            {
                if (a != 0)
                {
                    c = 1 / a2;
                    for (int i = 1; i < Math.Abs(b); ++i)
                        c /= a2;
                }
                else
                    check = 1;
            }
            else if (b > 0)
            {
                c = a2;
                for (int i = 1; i < Math.Abs(b); ++i)
                    c *= a2;
            }
            return c;
        }

        static double power_out_recursive(int a, int b, out double c, out int check)
        {
            check = 0;
            c = 0;
            double a2 = a;
            if (b == 0)
                return c = 1;
            else if (b < 0)
            {
                if (a == 0)
                {
                    check = 1;
                    return c = 0;
                }
                else
                {
                    return c = (1 / a2) * power_out_recursive(a, b + 1, out c,out check);
                }
            }
            else
                return c = a2 * power_out_recursive(a, b - 1, out c, out check);
        }
    }
}
