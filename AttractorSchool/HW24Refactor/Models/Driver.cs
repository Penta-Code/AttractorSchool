using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW24Refactor.Models
{
    internal class Driver
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }

        public override string ToString() => $"{Name} {Surname}";
    }
}
