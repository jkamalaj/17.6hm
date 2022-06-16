using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    
        public abstract class Human
        {
            public Human(string name, string surname)
            {
                Name = name;
                SurName = surname;
            }
            private string _name;
            private string _surName;
            public byte Age;
            public int Count;
   
            public string Name
            {
                get => _name;
                set
                {
                    if (CheckName(value))
                        _name = value;

                }
            }
            public string SurName
            {
                get => _surName;
                set
                {
                    if (CheckSurname(value))
                        _surName = value;
                }
            }
            void ShowInfo()
            {
                Console.WriteLine($"Name:{Name} - Surname:{SurName}- Age:{Age} ");
            }

            public bool CheckName(string name)
            {
                for (var i = 0; i < name.Length; i++)
                {
                    if (!char.IsLetter(name[i]))
                        return false;

                }
                return true;
            }
            public bool CheckSurname(string surname)
            {
                for (var i = 0; i < surname.Length; i++)
                {
                    if (!Char.IsLetter(surname[i]))
                        return false;
                }
                return true;
            }

        }
    }


