using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork25
{
    internal struct Cylinder
    {
        public string Name { get; } = "Cylinder";
        public int Height { get; set; }
        public int BaseWidth { get; set; }

        public Cylinder(int height, int width)
        {
            Height = height;
            BaseWidth = width;
        }
    }
}