using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework190630
{
    enum Genders
    {
        Unknown = 1,
        Male,
        Female
    }

    // bai 3
    class Cell
    {
        public string Shape;
        public int Size;
        public int Age;
        public int Number;

        public int grow()
        {
            return Size + 1;
        }

        public void split()
        {
            if (Size > 10)
            {
                Size = Size / 2;
                Age++;
            }
        }

        public bool dead()
        {
            if (Age > 70)
            {
                Console.WriteLine("The cell is dead");
                return true;
            }
            else
                return false;
        }

        public void cancer()
        {
            if (Age > 70 && dead() == false)
                Console.WriteLine("The cell is cancer");
        }
    }

    class Program
    {
        class Student
        {
            string FirstName;
            string LastName;
            int Age;
            Genders Gender;
            string ID;

            public void ReadInfo()
            {
                Console.WriteLine("Please input the sudent's information");
                FirstName = inputString("First name: ");
                LastName = inputString("Last name: ");
                Age = inputNum("Age: ");
                Console.WriteLine(
                    "\t1. Unknown" + Environment.NewLine+
                    "\t2. Male"+Environment.NewLine+
                    "\t3. Female");
                Gender = genderCheck("Gender: ");
                ID = inputString("Student's ID: ");
            }

            static string inputString(string mess)
            {
                do
                {
                    Console.Write(mess);
                    string input = Console.ReadLine();
                    if (input.Trim().Length > 0)
                        return input;
                    else
                        Console.WriteLine("The Info should not be emptied. Please input again");
                } while (true);
            }

            static int inputNum(string mess)
            {
                do
                {
                    Console.Write(mess);
                    int n;
                    if (int.TryParse(Console.ReadLine(), out n) && (n < 100) && (n > 20))
                        return n;
                    else
                        Console.WriteLine("The age should be from 20 to 100. Please input again");
                } while (true);
            }

            static Genders genderCheck(string mess)
            {
                do
                {
                    Console.Write(mess);
                    Genders gender;
                    if (Enum.TryParse(Console.ReadLine(), out gender) && 
                        Enum.IsDefined(typeof(Genders),gender))
                        return gender;
                    else
                        Console.WriteLine("Please input again");
                } while (true);
            }

            public void WriteInfor(int num)
            {
                Console.WriteLine("The information of the student {0}:", num+1);
                Console.WriteLine(
                    FirstName + " " + 
                    LastName + ", " + 
                    Gender + ", " + 
                    Age + " years old"+", ID: " +
                    ID);
            }

            public bool checkName(string name)
            {
                if ((FirstName + LastName).ToUpper().Trim().Contains(name.ToUpper().Trim()))
                    return true;
                else
                    return false;
            }

            public bool checkID(string id)
            {
                if (ID.ToUpper().Trim().Contains(id.ToUpper().Trim()))
                    return true;
                else
                    return false;
            }

        }

        static void Main(string[] args)
        {
            // Bai 1
            Student Nhan = new Student();
            Nhan.ReadInfo();
            Student Thong = new Student();
            Thong.ReadInfo();
            Student Oanh = new Student();
            Oanh.ReadInfo();
            Nhan.WriteInfor(0);
            Thong.WriteInfor(1);
            Oanh.WriteInfor(2);


            // Bai 2
            List<Student> studentList = new List<Student>();
            chooseAction(studentList);
            Console.ReadLine();
        }

        static void chooseAction(List<Student> list)
        {
            bool backMain;
            do
            {
                Console.WriteLine("\nWelcome to student management!" + Environment.NewLine +
                    "What do you want to do?" + Environment.NewLine +
                    "\t1. See the student list." + Environment.NewLine +
                    "\t2. Find student." + Environment.NewLine +
                    "\t3. Add student." + Environment.NewLine +
                    "\tPress X or quit to end." + Environment.NewLine);
                backMain = userChoice(list);
            } while (backMain);
            Console.WriteLine("See you again soon!!!");
        }

        static bool userChoice(List<Student> list)
        {
            do
            {
                Console.Write("Your choice: ");
                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                        Console.WriteLine("You chose See the student list");
                        seeList(list);
                        return true;
                    case "2":
                        Console.WriteLine("You chose Find the student");
                        studentFinding(list);
                        return true;
                    case "3":
                        Console.WriteLine("You chose add student");
                        studentInput(list);
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

        // Management part 1
        static void seeList(List<Student> list)
        {
            int j = 0;
            foreach (var item in list)
            {
                j++;
                item.WriteInfor(j);
            }
            if (j == 0)
                Console.WriteLine("There is no data");
        }

        // Management part 2
        static void studentFinding(List<Student> list)
        {
            bool backMain;
            bool ans;
            do
            {
                Console.WriteLine("\nHow do you want to find the student?" + Environment.NewLine +
                 "\t1. ID" + Environment.NewLine +
                 "\t2. Name" + Environment.NewLine +
                 "\t3. ID and Name" + Environment.NewLine +
                 "\tPress X or quit to go back." + Environment.NewLine);
                backMain = userFind(list);
                ans = ifQues("Back to main menu", backMain);
            } while (ans);
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

        static bool userFind(List<Student> list)
        {
            do
            {
                Console.Write("Your choice: ");
                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                        Console.WriteLine("You chose finding by ID");
                        IDfinding(list);
                        return true;
                    case "2":
                        Console.WriteLine("You chose finding by name");
                        Namefinding(list);
                        return true;
                    case "3":
                        Console.WriteLine("You chose finding by ID and name");
                        Studentfinding(list);
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

        static void IDfinding(List<Student> list)
        {
            Console.Write("Input ID: ");
            string find = Console.ReadLine();
            int j = 0;
            Console.WriteLine("The students you want to find are: ");
            for (int i = 0; (i < list.Count) && (j < 3); i++)
            {
                if (list[i].checkID(find))
                {
                    list[i].WriteInfor(i);
                    j++;
                }
            }
            if (j == 0)
                Console.WriteLine("Data not found");
        }

        static void Namefinding(List<Student> list)
        {
            Console.Write("Input the name: ");
            string find = Console.ReadLine();
            int j = 0;
            Console.WriteLine("The students you want to find are: ");
            for (int i = 0; (i < list.Count) && (j < 3); i++)
            {
                if (list[i].checkName(find))
                {
                    list[i].WriteInfor(i);
                    j++;
                }
            }
            if (j == 0)
                Console.WriteLine("Data not found");
        }

        static void Studentfinding(List<Student> list)
        {
            Console.WriteLine("Input ID and Name");
            Console.Write("\tID: ");
            string findID = Console.ReadLine();
            Console.Write("\tName: ");
            string findName = Console.ReadLine();
            Console.WriteLine("The student you want to find are: ");
            for (int i = 0, j = 0; (i < list.Count) && (j < 3); i++)
            {
                if (list[i].checkName(findName))
                {
                    if (list[i].checkID(findID))
                    {
                        list[i].WriteInfor(i);
                        j++;
                    }
                }
                if (j == 0)
                    Console.WriteLine("Data not found");
            }
        }

        // Management part 3
        static void studentInput(List<Student> list)
        {
            list.Add(new Student());
            list[list.Count - 1].ReadInfo();
        }
    }
}
