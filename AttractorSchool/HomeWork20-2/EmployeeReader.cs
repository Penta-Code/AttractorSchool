using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20_2
{
    internal class EmployeeReader
    {
        public void Read()
        {
            File.ReadAllLines("../../../input.txt");
        }
    }
}
