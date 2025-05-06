using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork3.LaptopState
{
    internal class LaptopOffState : ILaptopState
    {
        public void StartProgramm(Laptop laptop)
        {
            throw new NotImplementedException();
        }

        public void TurnOff(Laptop laptop)
        {
            throw new NotImplementedException();
        }

        public void TurnOn(Laptop laptop)
        {
            Console.WriteLine();
            laptop.IsOn = true;
            //laptop.State = new LaptopOnState();

        }
    }
}
