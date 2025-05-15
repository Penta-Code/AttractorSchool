using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork25
{
    internal struct Pyramid
    {
        public string Name { get; } = "Pyramid";
        public int Length { get; set; }
        public int Height { get; set; }
        public int BaseWidth { get; set; }

        public Pyramid(int length, int height, int width)
        {
            Length = length;
            Height = height;
            BaseWidth = width;
        }
    }
}