using HW24Refactor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW24Refactor.States
{
    internal class InRunState : ITruckState
    {
        private readonly Truck _truck;
        public string Name => "run";

        public InRunState(Truck truck)
        {
            _truck = truck;
        }

        public void ChangeDriver()
        {
            Console.WriteLine("Невозможно изменить водителя — грузовик в пути.");
        }

        public void StartRun()
        {
            Console.WriteLine("Грузовик уже в пути.");
        }

        public void StartRepair()
        {
            _truck.State = "repair";
            _truck.StateHandler = new InRepairState(_truck);
            Console.WriteLine($"Грузовик \"{_truck.Name}\" направлен в ремонт.");
        }
    }
}
