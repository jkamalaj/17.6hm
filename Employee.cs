using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
        class Employee : Human
        {
            public Employee(string name, string surname,string position) : base(name, surname)
            {
              
               Position = position;

            }
            public string Position;
            public void ShowInfo()
            {
                Console.WriteLine($"Name:{Name}-Surname:{SurName}-Position:{Position}");
            }
        }
    }


