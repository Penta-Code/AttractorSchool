using HomeWork22_2.Interfaces;

namespace HomeWork22_2
{
    internal class Square : ISquare
    {
        private int _side;

        public Square(int side)
        {
            _side = side;
        }

        public double GetSide()
        {
            return _side;
        }
    }
}