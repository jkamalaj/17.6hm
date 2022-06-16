using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal interface ICity
    {
        public Human[] Human { get; set; }

        void AddHuman();
        void SearchHumans();

    }
}
