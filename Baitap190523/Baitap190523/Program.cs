using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap190523
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Cau 1
            //int userAge = 28;
            //float userMoney = 2.18f;
            //string userName;
            //Console.WriteLine("Ten cua ban la gi?");
            //userName = Console.ReadLine();

            //// Cau 2
            //var xValue = 21;
            //var yValue = "Alive";
            //var zValue = 8.20;

            //// Cau 3
            //const byte byteValue = 88;
            //const char charValue = 'a';
            //const double doubleValue = 5.22;

            //Console.WriteLine("Ten cua ban la: {0}.",userName);

            Console.Write("Hay nhap so thu 1: ");
            int so1 = int.Parse(Console.ReadLine());
            Console.Write("Hay nhap so thu 2: ");
            int so2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong cua 2 so la: {0}", so1 + so2);
            Console.WriteLine("Hieu cua 2 so la: {0}", so1 - so2);
            Console.WriteLine("Tich cua 2 so la: {0}", so1 * so2);
            Console.WriteLine("Thuong cua 2 so la: {0}", (float)so1/so2);
            Console.WriteLine("So thu 1 {0} so thu 2", so1 >= so2 ? "lon hon" : "nho hon");
            Console.ReadLine();
        }
    }
}
