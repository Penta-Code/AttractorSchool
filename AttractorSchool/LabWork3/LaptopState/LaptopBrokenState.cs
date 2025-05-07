using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork3.LaptopState
{
    internal class LaptopBrokenState : ILaptopState
    {
        public void TurnOn(Laptop laptop)
        {
            throw new Exception("Ноутбук сломан. Нет доступных действий");
        }

        public void TurnOff(Laptop laptop)
        {
            throw new Exception("Ноутбук сломан. Нет доступных действий");
        }

        public void StartProgramm(Laptop laptop)
        {
            throw new Exception("Ноутбук сломан. Нет доступных действий");
        }
    }
}