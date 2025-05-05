using HomeWork22_2.Interfaces;

namespace HomeWork22_2
{
    internal class DoubleSquare : AbstractDoubleSquare
    {
        private double _side;
        private double _area1;
        private double _area2;

        public override void BuildDoubleSquare(ISquare square1, ISquare square2)
        {
            _side = square1.GetSide();
            _area1 = Math.Pow(_side, 2);

            _side = square2.GetSide();
            _area2 = Math.Pow(_side, 2);
        }

        protected override double CalculateArea()
        {
            return _area1 + _area2;
        }
    }
}