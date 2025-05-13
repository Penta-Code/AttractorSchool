using HW24Refactor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW24Refactor.States
{
    internal class InRepairState : ITruckState
    {
        private readonly Truck _truck;
        public string Name => "repair";

        public InRepairState(Truck truck)
        {
            _truck = truck;
        }

        public void ChangeDriver()
        {
            Console.WriteLine("Грузовик в ремонте. Замена водителя невозможна.");
        }

        public void StartRun()
        {
            Console.WriteLine("Невозможно отправить в путь — грузовик в ремонте.");
        }

        public void StartRepair()
        {
            Console.WriteLine("Грузовик уже находится в ремонте.");
        }
    }
}
