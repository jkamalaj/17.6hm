using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
        class Baku : ICity
        {
        public void AddHuman()
        {
          throw new NotImplementedException();
        }

        public void SearchHumans()
        {
          throw new NotImplementedException();
        }
      
        Human[] Humans = new Human[0];

            public Human[] Human { get; set; }



        //    public Human[] GetStudents()
        //    {
        //        Human[] Students = new Student[0];
        //        foreach (var item in Human)
        //        {
        //            if (item is Student)
        //            {
        //                Array.Resize(ref Students, Students.Length + 1);
        //                Students[Students.Length - 1] = item;
        //            }
        //        }
        //        return Students;
        //    }
        //    public  Human[] GetEmployee()
        //    {
        //        Human[] Employee = new Employee[0];
        //        foreach (var item in Human)
        //        {
        //            if (item is Employee)
        //            {
        //                Array.Resize(ref Humans, Humans.Length + 1);
        //                Humans[Humans.Length - 1] = item;
        //            }
        //        }
        //        return Employee;
        //    }

          

        //public static void AddHuman (ref Human[] humans,Human human)
        //{
        //    Array.Resize(ref humans, humans.Length + 1);
        //    humans[humans.Length - 1] = human;
        //}

        //public Human[] SearchHumans(string word)
        //{
        //    Human[] human = new Human[0];
        //        for (int i = 0; i < Human.Length; i++)
        //        {
        //           string FullName = Human[i].SurName + " " + Human[i].Name;
        //           if (FullName.Contains(word))
        //           {
        //               Array.Resize(ref human, human.Length + 1);
        //                Human[human.Length - 1] = Human[i];
        //            }

        //       }
        //        return human;
        //}

      
    }
    }



