using System;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human[] Human = new Human[0];
            string answer;
            
            do
            {
                Console.WriteLine("1.Employee elave et");
                Console.WriteLine("2.Student elave et");
                Console.WriteLine("3.Employeelerin sayini goster");
                Console.WriteLine("4.Studentlerin sayini goster");
                Console.WriteLine("5.Employeelerin sayina bax");
                Console.WriteLine("6.Studentlerin sayina bax");
                Console.WriteLine("7.Insanlar uzerinde axtaris et");
                Console.WriteLine("0.Menudan cix");

                Console.WriteLine("Seciminizi edin");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        Employee employee = GenerateEmployee();
                        AddHuman(ref Human, employee);
                        break;
                    case "2":
                        Student student = GenerateStudent();
                        AddHuman(ref Human, student);
                        break;
                    case "3":
                         EmployeeCount();

                        break;
                    case "4":
                        StudentCount();
                        break;
                    case "5":
                        GetEmployee();
                        break;
                    case "6":
                        GetStudents();
                        break;
                    case "7":
                        SearchHumans();
                        break;
                    default:
                        break;
                }
            } while (answer!="1" && answer!="2" && answer!="3");

             Human[] GetStudents()
            {
                Human[] Students = new Student[0];
                foreach (var item in Human)
                {
                    if (item is Student)
                    {
                        Array.Resize(ref Students, Students.Length + 1);
                        Students[Students.Length - 1] = item;
                    }
                }
                return Students;
            }
            Human[] GetEmployee()
            {
                Human[] Employee = new Employee[0];
                foreach (var item in Human)
                {
                    if (item is Employee)
                    {
                        Array.Resize(ref Human, Human.Length + 1);
                        Human[Human.Length - 1] = item;
                    }
                }
                return Employee;
            }

            static void AddHuman(ref Human[] humans, Human human)
            {
                Array.Resize(ref humans, humans.Length + 1);
                humans[humans.Length - 1] = human;
                Console.WriteLine("Human add olundu");
            }
            static Employee GenerateEmployee()
            {
                Console.WriteLine("Adi daxil edin");
                string name = Console.ReadLine();
                Console.WriteLine("Soyadi daxil edin");
                string surname = Console.ReadLine();
                Console.WriteLine("Position daxil edin");
                string position = Console.ReadLine();

                Employee humanEmployee = new Employee()
                {
                    Name = name,
                    SurName = surname,
                    Position = position,
                };
                return humanEmployee;
            }
            static Student GenerateStudent()
            {
                Console.WriteLine("Studentin adini daxil edin");
                string name = Console.ReadLine();
                Console.WriteLine("Studentin soyadini daxil edin");
                string surname = Console.ReadLine();
                Console.WriteLine("Studentin GroupNo daxil edin");
                string groupno = Console.ReadLine();

                Student humanStudent = new Student()
                {
                    Name = name,
                    SurName = surname,
                    GroupNo=groupno,
                };
                return humanStudent;
            }
             Human[] EmployeeCount()
            {
                int count = 0;
                foreach (var item in Human)
                {
                    if (item is Employee)
                    {
                        count++;
                    }
                }
                return count;
            }
           
            Human[] StudentCount()
            {
                int count = 0;
                foreach(var item in Human)
                {
                    if(item is Student)
                    {
                        count++;
                    }
                }
                return count;
            }
            Human[] SearchHumans(string word)
            {
                Human[] human = new Human[0];
                for (int i = 0; i < Human.Length; i++)
                {
                    string FullName = Human[i].SurName + " " + Human[i].Name;
                    if (FullName.Contains(word))
                    {
                        Array.Resize(ref human, human.Length + 1);
                        Human[human.Length - 1] = Human[i];
                    }

                }
                return human;
            }
        }
    }
}
