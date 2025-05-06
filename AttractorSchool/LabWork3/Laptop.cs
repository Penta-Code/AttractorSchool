using LabWork3.LaptopState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork3
{
    internal class Laptop
    {
        public bool IsOn { get; set; }
        public string RunningProgramm { get; set; }

        public ILaptopState State { get; set; }

        public Laptop(bool isOn, string runningProgramm, ILaptopState state)
        {
            IsOn = isOn;
            RunningProgramm = runningProgramm;
            State = state;
        }

        public void TurnOn()
        {
            State.TurnOn(this);
        }

        public void TurnOff()
        {
            State.TurnOff(this);
        }

        public void StartProgramm()
        {
            State.StartProgramm(this);
        }
    }
}