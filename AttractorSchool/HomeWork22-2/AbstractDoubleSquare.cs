using HomeWork22_2.Interfaces;

namespace HomeWork22_2
{
    internal abstract class AbstractDoubleSquare : IDoubleSquare
    {
        protected double area;
        public abstract void BuildDoubleSquare(ISquare square1, ISquare square2);
        protected abstract double CalculateArea();

        public double GetArea()
        {
            if (this.area == 0)
            {
                area = CalculateArea();
            }

            return CalculateArea();
        }
    }
}