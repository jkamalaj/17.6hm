using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
        class Student : Human
        {
            public Student(string name, string surname, string groupno) : base(name, surname)
            {
             
               GroupNo = groupno;
            }
            public int Grade;
            public string GroupNo;
            public void ShowInfo()
            {
                Console.WriteLine($"Name:{Name}-SurName:{SurName}-GroupNo:{GroupNo}");
            }


        }
    }



