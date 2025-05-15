using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork25
{
    internal struct Cone
    {
        public string Name { get; } = "Cone";
        public int Height { get; set; }
        public int BaseWidth { get; set; }

        public Cone(int height, int width)
        {
            Height = height;
            BaseWidth = width;
        }
    }
}