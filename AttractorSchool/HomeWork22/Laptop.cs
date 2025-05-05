using HomeWork22.Interfaces;

namespace HomeWork22
{
    internal class Laptop : ILaptop
    {
        public void TurnOn()
        {
            Console.WriteLine("Ноутбук включен");
        }
        public void TurnOff()
        {
            Console.WriteLine("Ноутбук выключен");
        }
        public void RunProgramm()
        {
            Console.WriteLine("Программа выполняется");
        }
        public void StopProgramm()
        {
            Console.WriteLine("Программа остановлена");
        }
    }
}