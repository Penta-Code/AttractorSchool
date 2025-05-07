using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork3.LaptopState
{
    internal class LaptopOnState : ILaptopState
    {
        public void TurnOn(Laptop laptop)
        {
            throw new Exception("Ноутбук уже включен!");
        }

        public void TurnOff(Laptop laptop)
        {
            Console.WriteLine("Ноутбук успешно выключен");
            laptop.IsOn = false;
            laptop.State = new LaptopOffState();
            laptop.RunningProgramm = "Никакой";
        }

        public void StartProgramm(Laptop laptop)
        {
            Console.WriteLine("Программа запущена");
            laptop.RunningProgramm = "Выполняется Paint";
        }
    }
}