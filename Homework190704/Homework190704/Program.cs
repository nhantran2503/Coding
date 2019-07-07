using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework190704
{
    class Program
    {
        class Fraction
        {
            public int Numerator;
            public int Denominator;

            public Fraction()
            {

            }

            public Fraction(int num , int denom)
            {
                Numerator = num;
                Denominator = denom;
            }

            public Fraction(int num)
            {
                Numerator = num;
            }

            public float GetRealValue()
            {
                return (float) Numerator / Denominator;
            }

            public Fraction Add(Fraction other)
            {
                Fraction add = new Fraction();
                add.Numerator = Numerator * other.Denominator + other.Numerator * Denominator;
                add.Denominator = Denominator * other.Denominator;
                return add;
            }

            public Fraction Multiply(Fraction other)
            {
                Fraction multiply = new Fraction();
                multiply.Numerator = Numerator * other.Numerator;
                multiply.Denominator = Denominator * other.Denominator;
                return multiply;
            }

            public string GetDisplayString()
            {
                return Numerator + "/" + Denominator;
            }

            //public void Simplify()
            //{
            //    Console.WriteLine("The simplified fraction is: " + Simple().GetDisplayString());
            //}

            Fraction Simple()
            {
                Fraction simple = new Fraction();
                int k;
                if (Numerator == Denominator)
                {
                    simple.Numerator = 1;
                    simple.Denominator = 1;
                }
                else
                {
                    k = DivideSame(Numerator, Denominator);
                    simple.Numerator = Numerator / k;
                    simple.Denominator = Denominator / k;
                }
                return simple;
            }

            public void Simplify()
            {
                // method 1:
                int a = Math.Abs(Numerator);
                int b = Math.Abs(Denominator);
                while (a != 0 && b != 0)
                {
                    if (a > b)
                        a = a % b;
                    else
                        b = b % a;
                }
                int greatestCommonDivisor = a == 0 ? b : a;
                Numerator /= greatestCommonDivisor;
                Denominator /= greatestCommonDivisor;
            }

                int DivideSame(int num, int denom)
            {
                List<int> numList = new List<int>();
                numList = Recursive(num,numList);
                List<int> denomList = new List<int>();
                denomList = Recursive(denom,denomList);
                if (numList.Count > denomList.Count)
                    return findSameNumber(numList, denomList);
                else
                    return findSameNumber(denomList, numList);
            }

            List<int> Recursive(int value, List<int> list)
            {
                int k;
                if (Dividecheck(value, out k) == false)
                {
                    list.Add(k);
                    return list;
                }
                else
                {
                    list.Add(k);
                    return Recursive(value / k, list);
                }
            }

            bool Dividecheck(int value, out int k)
            {
                for (int i = 2; i < (value / 2); i++)
                {
                    if (value % i == 0)
                    {
                        k = i;
                        return true;
                    }
                }
                k = value;
                return false;
            }

            
            int findSameNumber(List<int> more, List<int> less)
            {
                int k = 1;
                for (int j = 0; j < more.Count; j++)
                {
                    if (less[0] == more[j])
                    {
                       k *= less[0];
                       less.Remove(less[0]);
                    }
                            
                }

                return k;
            }
        }
        static void Main(string[] args)
        {
            Fraction first = new Fraction(4, 3);
            Fraction second = new Fraction(2, 3);
            Console.WriteLine(first.GetRealValue());
            Fraction add = new Fraction();
            add = first.Add(second);
            Console.WriteLine(add.GetDisplayString());
            add.Simplify();
            Fraction multiply = new Fraction();
            multiply = first.Multiply(second);
            Console.WriteLine(multiply.GetDisplayString());
            multiply.Simplify();

            Fraction Input = new Fraction();
            Input.Numerator = int.Parse(Console.ReadLine());
            Input.Denominator = int.Parse(Console.ReadLine());
            Console.WriteLine(Input.GetDisplayString());
            Input.Simplify();
            Console.ReadLine();
        }
    }
}
