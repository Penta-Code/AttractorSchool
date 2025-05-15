using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork25
{
    internal struct Parallelepiped : ICalculatable
    {
        public string Name { get; } = "Parallelepiped";
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Parallelepiped(int length, int height, int width)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        public double CalculateVolume()
        {
            return Length * Height * Width;
        }

        public double CalculateSquare()
        {
            return 2*((Width * Length) + (Width * Height) + (Length * Height));
        }
    }
}