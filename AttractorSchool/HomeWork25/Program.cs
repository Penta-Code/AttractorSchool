namespace HomeWork25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallelepiped paral = new(5, 2, 4);

            double volume = paral.CalculateVolume();
            double sqr = paral.CalculateSquare();

            Console.WriteLine($"Volume = {volume}; Square = {sqr}");
        }
    }
}
