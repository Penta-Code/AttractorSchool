using HomeWork22.Interfaces;

namespace HomeWork22
{
    internal class Fridge : IFridge
    {
        public void TurnOn()
        {
            Console.WriteLine("Холодильник включен");
        }
        public void TurnOff()
        {
            Console.WriteLine("Холодильник выключен");
        }
        public void Frost()
        {
            Console.WriteLine("Заморозка включена");
        }
        public void Defrost()
        {
            Console.WriteLine("Заморозка выключена");
        }
    }
}