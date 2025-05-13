using HW24Refactor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW24Refactor.States
{
    internal class InBaseState: ITruckState
    {
        private readonly Truck _truck;
        public string Name => "base";

        public InBaseState(Truck truck)
        {
            _truck = truck;
        }

        public void ChangeDriver()
        {
            Console.WriteLine("Введите имя нового водителя:");
            var name = Console.ReadLine();

            Console.WriteLine("Введите фамилию нового водителя:");
            var surname = Console.ReadLine();

            Console.WriteLine("Введите возраст:");
            int age = int.TryParse(Console.ReadLine(), out var a) ? a : 0;

            Console.WriteLine("Введите стаж:");
            int experience = int.TryParse(Console.ReadLine(), out var e) ? e : 0;

            _truck.Driver = new Driver { Name = name, Surname = surname, Age = age, Experience = experience };
            Console.WriteLine("Водитель успешно изменён.");
        }

        public void StartRun()
        {
            _truck.State = "run";
            _truck.StateHandler = new InRunState(_truck);
            Console.WriteLine($"Грузовик \"{_truck.Name}\" выехал на маршрут.");
        }

        public void StartRepair()
        {
            _truck.State = "repair";
            _truck.StateHandler = new InRepairState(_truck);
            Console.WriteLine($"Грузовик \"{_truck.Name}\" отправлен в ремонт.");
        }
    }
}
