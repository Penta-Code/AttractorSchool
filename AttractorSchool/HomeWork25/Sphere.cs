using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork25
{
    internal struct Sphere
    {
        public string Name { get; } = "Sphere";
        public int Radius { get; set; }

        public Sphere(int radius)
        {
            Radius = radius;
        }
    }
}