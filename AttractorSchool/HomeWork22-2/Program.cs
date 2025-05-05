namespace HomeWork22_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(10);
            Square square2 = new Square(12);
            DoubleSquare doubleSquare = new DoubleSquare();

            doubleSquare.BuildDoubleSquare(square1, square2);

            Console.WriteLine("Площадь doubleSquare = {0}", doubleSquare.GetArea());
        }
    }
}