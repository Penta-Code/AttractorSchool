using HomeWork22.Interfaces;

namespace HomeWork22
{
    internal class Phone : IPhone
    {
        public void TurnOn()
        {
            Console.WriteLine("Телефон включен");
        }
        public void TurnOff()
        {
            Console.WriteLine("Телефон выключен");
        }
        public void BluetoothOn()
        {
            Console.WriteLine("Bluetooth включен");
        }
        public void BluetoothOff()
        {
            Console.WriteLine("Bluetooth выключен");
        }
    }
}