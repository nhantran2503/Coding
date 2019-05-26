using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework190523
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cau 1
            string name = "Nhan";
            string address = "Ho Chi Minh city";
            char gender = 'M';
            byte age1 = 28;
            float height20 = 1.65f;
            float weight20;
            short class_Tcode1;
            int class_Tcode1_time;
            string Tcode1_address;
            string _;
            weight20 = 65.0f;
            class_Tcode1 = 1;
            class_Tcode1_time = 180;
            Tcode1_address = "Go Vap";
            _ = "Random?";

            //Cau 2
            double x;
            double y;
            double z;
            string input;
            Console.Write("Gia tri x: ");
            input = Console.ReadLine();
            x = double.Parse(input);
            Console.Write("Gia tri y: ");
            input = Console.ReadLine();
            y = double.Parse(input);
            z = x * x + 2 * x * y + y * y;
            Console.WriteLine(z);
            Console.WriteLine("z {0} cho x", z % x == 0 ? "chia het" : "khong chia het");
            Console.ReadLine();
        }
    }
}
