using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork3.LaptopState
{
    internal interface ILaptopState
    {
        void TurnOn(Laptop laptop);
        void TurnOff(Laptop laptop);
        void StartProgramm(Laptop laptop);
    }
}
