using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework190707
{
    enum Genders
    {
        Unknown = 1,
        Male,
        Female
    }

    enum AgeStages
    {
        Child,
        YoungAdult,
        MiddleAgedAdult,
        Elder
    }

    class Program
    {
        //Bai 1
        class Student
        {
            private string FirstName;
            private string LastName;
            int Age;
            private Genders Gender;
            private readonly string ID;
            private AgeStages AgeStage;

            public void ReadInfo()
            {
                Console.WriteLine("Please input the sudent's information");
                FirstName = inputString("First name: ");
                LastName = inputString("Last name: ");
                Age = inputNum("Age: ");
                Console.WriteLine(
                    "\t1. Unknown" + Environment.NewLine +
                    "\t2. Male" + Environment.NewLine +
                    "\t3. Female");
                Gender = genderCheck("Gender: ");
                AgeStage = ageCheck(Age);
            }

            public Student(string id)
            {
                ID = id;
            }

            public string inputString(string mess)
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
                        Enum.IsDefined(typeof(Genders), gender))
                        return gender;
                    else
                        Console.WriteLine("Please input again");
                } while (true);
            }

            static AgeStages ageCheck(int age)
            {
                if (age > 0 && age <= 18)
                    return AgeStages.Child;
                else if (age > 18 && age <= 35)
                    return AgeStages.YoungAdult;
                else if (age > 35 && age <= 55)
                    return AgeStages.MiddleAgedAdult;
                else
                    return AgeStages.Elder;
            }

            public void WriteInfor(int num)
            {
                Console.WriteLine("The information of the student {0}:", num + 1);
                Console.WriteLine(
                    FirstName + " " +
                    LastName + ", " +
                    Gender + ", " +
                    Age + " years old" + ", ID: " +
                    ID);
                Console.WriteLine("The student is a " + AgeStage);
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
            string findID;
            string findName;
            do
            {
                Console.Write("Your choice: ");
                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                        Console.WriteLine("You chose finding by ID");
                        findID = userInput("ID");
                        IDfinding(list, findID);
                        return true;
                    case "2":
                        Console.WriteLine("You chose finding by name");
                        findName = userInput("name");
                        Namefinding(list, findName);
                        return true;
                    case "3":
                        Console.WriteLine("You chose finding by ID and name");
                        findID = userInput("ID");
                        findName = userInput("name");
                        Studentfinding(list, findID, findName);
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

        static string userInput(string mess)
        {
            Console.Write("Input {0}: ", mess);
            return Console.ReadLine();
        }

        static void IDfinding(List<Student> list, string find)
        {
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

        static void Namefinding(List<Student> list, string find)
        {
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

        static void Studentfinding(List<Student> list, string findID, string findName)
        {
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
            Console.WriteLine("Student's ID: ");
            list.Add(new Student(Console.ReadLine()));
            list[list.Count - 1].ReadInfo();
        }

        //Bai 2
        class Vector2D
        {
            private float x;
            private float y;

            public Vector2D()
            {

            }

            public Vector2D(float X, float Y)
            {
                x = X;
                y = Y;
            }

            public Vector2D Add(Vector2D other)
            {
                float X = x + other.x;
                float Y = y + other.y;
                return new Vector2D(X,Y);
            }

            public Vector2D Div(Vector2D other)
            {

                float X = x / other.x;
                float Y = y / other.y;
                return new Vector2D(X, Y);
            }

            public double Distance(Vector2D other)
            {
                return Math.Sqrt(Math.Pow(x - other.x, 2) + Math.Pow(y - other.y, 2));
            }

            public Vector2D Swap(ref Vector2D other)
            {
                x = x + other.x;
                other.x = x - other.x;
                x = x - other.x;
                y = y + other.y;
                other.y = y - other.y;
                y = y - other.y;
                return new Vector2D();
            }

            public Vector2D Clone()
            {
                return new Vector2D(x,y);
            }

            public void WriteInfo(string vectorName)
            {
                Console.WriteLine("Vector {0}: x = {1}, b = {2}", vectorName, x, y);
            }
        }

        static void Main(string[] args)
        {
            // Bai 1
            List<Student> studentList = new List<Student>();
            chooseAction(studentList);
            Console.ReadLine();

            // Bai 2
            Vector2D a = new Vector2D(2, 3);
            Vector2D b = new Vector2D(5, 6);
            a.WriteInfo("a");
            b.WriteInfo("b");
            Vector2D c = a.Add(b);
            Console.WriteLine("\nAfter adding b to a");
            c.WriteInfo("after adding");
            Vector2D d = a.Div(b);
            Console.WriteLine("\nAfter diving a by b");
            d.WriteInfo("after dividing");
            double e = a.Distance(b);
            Console.WriteLine("\nThe distance between a and b is {0}\n",e);
            a.Swap(ref b);
            a.WriteInfo("a");
            b.WriteInfo("b");
            Vector2D f = a.Clone();
            f.WriteInfo("f (clone of a)");
            Console.ReadLine();

        }

    }
}
