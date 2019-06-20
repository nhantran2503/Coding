using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework190609
{
    class Program
    {
        static void Main(string[] args)
        {
            //cau 1
            string[] students = new string[10];

            //cau 2
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //cau 3
            int[][] matrix = new int[][]
            {
                new int[]{ 4, 7, 7 },
                new int[]{ 3, 1, 5 },
                new int[]{ 6, 9, 8 },
                new int[]{ 2, 5, 0 }
            };
            for(int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                    Console.Write("{0} ", matrix[i][j]);
                Console.WriteLine();
            }

            //cau 4
            Console.Write("Please input the number of elements: ");
            int n = inputNum();
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("Please input the element number {0}: ",i+1);
                a[i] = inputNum();
            }
            Console.Write("Your array is: ");
            for (int i = 0; i < n; ++i)
                Console.Write("{0} ", a[i]);
            Console.Write("\nThe odd numbers in the array are: ");
            int sum = 0;
            for (int i = 0; i < n; ++i)
            {
                if (a[i] % 2 != 0)
                {
                    Console.Write("{0} ", a[i]);
                    sum += a[i];
                }
            }
            Console.WriteLine("\nThe sum of all the odd numbers is: {0}",sum);
            Console.ReadLine();

        }

        static int inputNum()
        {
            Console.Write("Your input is: ");
            return int.Parse(Console.ReadLine());
        }

    }
}
