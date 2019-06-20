using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework190613
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = inputNum();
            string[] mssv = new string [n];
            string[] hoten = new string[n];
            uint[] tuoi = new uint[n];
            string[] thongtin = new string[n];
            chooseAction(ref mssv, ref hoten, ref tuoi, ref thongtin);
            Console.ReadLine();
        }

        static int inputNum()
        {
            Console.Write("Input the number of student: ");
            return int.Parse(Console.ReadLine());
        }

        static void chooseAction(ref string[] mssv, ref string[] hoten, ref uint[] tuoi, ref string[] thongtin)
        {
            bool ans;
            bool backMain;
            do
            {
                Console.WriteLine("\nWelcome to student management!" + Environment.NewLine +
                    "What do you want to do?" + Environment.NewLine +
                    "\t1. See the student list." + Environment.NewLine +
                    "\t2. Find student." + Environment.NewLine +
                    "\t3. Add student." + Environment.NewLine +
                    "\tPress X or quit to end." + Environment.NewLine);
                backMain = userChoice(ref mssv, ref hoten, ref tuoi, ref thongtin);
                ans = ifQues("End program",backMain);
            } while (ans);
            Console.WriteLine("See you again soon!!!");
        }

        static bool ifQues(string endMess, bool a)
        {
            if (a == true)
                return loopQues(endMess);
            else
                return false;
        }

        static bool loopQues(string endMess)
        {
            do
            {
                Console.WriteLine("\nDo you want to contimue? y/n");
                string ans = Console.ReadLine().ToLower();
                switch (ans)
                {
                    case "n":
                        Console.WriteLine(endMess);
                        return false;
                    case "y":
                        return true;
                    default:
                        Console.WriteLine("I don't understand");
                        continue;
                }
            } while (true);
        }

        static bool userChoice(ref string[] mssv, ref string[] hoten, ref uint[] tuoi, ref string[] thongtin)
        {
            do
            {
                Console.Write("Your choice: ");
                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                        Console.WriteLine("You chose See the student list");
                        seeList(mssv, hoten, tuoi, thongtin);
                        return true;
                    case "2":
                        Console.WriteLine("You chose Find the student");
                        studentFinding(mssv, hoten, tuoi, thongtin);
                        return true;
                    case "3":
                        Console.WriteLine("You chose add student");
                        studentInput(ref mssv, ref hoten, ref tuoi, ref thongtin);
                        return true;
                    case "x":
                    case "quit":
                        Console.WriteLine("End program");
                        return false;
                    default:
                        Console.WriteLine("I don't understand!");
                        continue;
                }
            } while (true);
        }

        static void seeList(string[] mssv, string[] hoten, uint[] tuoi, string[] thongtin)
        {
            int j = 0;
            for (int i = 0; i < mssv.Length; i++)
            {
                if ((mssv[i]!=null) || (hoten[i] != null))
                {
                    Console.WriteLine("The info of students:");
                    Console.WriteLine("\t{0}.MSSV: {1}\tHo va ten: {2}\tTuoi: {3}\tThong tin: {4}", i + 1, mssv[i], hoten[i], tuoi[i], thongtin[i]);
                    j++;
                }
            }
            if(j==0)
                Console.WriteLine("There is no data");
        }

        static void studentFinding(string[] mssv, string[] hoten, uint[] tuoi, string[] thongtin)
        {
            bool backMain;
            bool ans;
            do
            {
                Console.WriteLine("\nHow do you want to find the student?" + Environment.NewLine +
                 "\t1. MSSV" + Environment.NewLine +
                 "\t2. hoten" + Environment.NewLine +
                 "\t3. MSSV and hoten" + Environment.NewLine +
                 "\tPress X or quit to go back." + Environment.NewLine);
                backMain = userChoice(mssv, hoten, tuoi, thongtin);
                ans = ifQues("Back to main menu",backMain);
            } while (ans);
        }

        static bool userChoice(string[] mssv, string[] hoten, uint[] tuoi, string[] thongtin)
        {
            do
            {
                Console.Write("Your choice: ");
                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                        Console.WriteLine("You chose finding by MSSV");
                        Studentfinding("MSSV", "Ho va ten", mssv, hoten, tuoi, thongtin);
                        return true;
                    case "2":
                        Console.WriteLine("You chose finding by ho va ten");
                        Studentfinding("Ho va ten", "MSSV",hoten, mssv, tuoi, thongtin);
                        return true;
                    case "3":
                        Console.WriteLine("You chose finding by MSSV and ho va ten");
                        Studentfinding("MSSV and Hoten", mssv, hoten);
                        return true;
                    case "x":
                    case "quit":
                        return false;
                    default:
                        Console.WriteLine("I don't understand!");
                        continue;
                }
            } while (true);
        }

        static void Studentfinding(string mess1, string mess2, string[] a, string[] b, uint[] tuoi, string [] thongtin)
        {
            Console.Write("Input {0}: ",mess1);
            string find = Console.ReadLine();
            int j = 0;
            for (int i=0; (i < a.Length)&&(j<3); i++)
            {
                if(a[i].ToLower().Contains(find.ToLower()))
                {
                    Console.WriteLine("The student you want to find is: ");
                    Console.WriteLine("\t{0}) {1}: {3}\t{2}: {4}\tTuoi: {5}\tThong tin: {6}",j+1,mess1,mess2,a[i],b[i],tuoi[i],thongtin[i]);
                    j++;
                }
            }
            if (j == 0)
                Console.WriteLine("Data not found");
        }

        static void Studentfinding(string mess, string[] mssv, string[] hoten)
        {
            Console.WriteLine("Input {0}", mess);
            Console.Write("\tMSSV:");
            string findmssv = Console.ReadLine();
            Console.Write("\tHo va ten:");
            string findhoten = Console.ReadLine();
            for (int i = 0, j = 0; (i < mssv.Length) && (j < 3); i++)
            {
                if (mssv[i].Contains(findmssv))
                {
                    if (hoten[i].ToLower().Contains(findhoten.ToLower()))
                    {
                        Console.WriteLine("The student you want to find is: ");
                        Console.WriteLine("\t{0}.MSSV: {1}\tHo va ten: {2}", j + 1, mssv[i], hoten[i]);
                        j++;
                    }
                }
                if (j == 0)
                    Console.WriteLine("Data not found");
            }
        }

        static void studentInput(ref string[] mssv, ref string[] hoten, ref uint[] tuoi, ref string[] thongtin)
        {
            for (int i = 0; i< mssv.Length; ++i)
            {
                Console.WriteLine("Input the information of student number {0}",i+1);
                Console.Write("MSSV", i+1);
                inputInfor(mssv, i);
                Console.Write("Name", i + 1);
                inputInfor(hoten, i);
                Console.Write("Age", i + 1);
                inputInfor(tuoi, i);
                Console.Write("Information", i + 1);
                inputInfor(thongtin, i);
            }
        }

        static void inputInfor(string[] arr, int i)
        {
            do
            {
                Console.Write("\t");
                string input = Console.ReadLine();
                if (input.Trim().Length > 0)
                {
                    arr[i] = input;
                    break;
                }
                else
                    Console.Write("Please input again");
            } while (true);
        }

        static void inputInfor(uint[] arr, int i)
        {
            do
            {
                Console.Write("\t");
                uint n;
                bool isOK = uint.TryParse(Console.ReadLine(), out n);
                if (isOK && (n<100) && (n>20))
                {
                    arr[i] = n;
                    break;
                }
                else
                    Console.Write("Please input again");
            } while (true);
        }
    }
}
