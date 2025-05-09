using HomeWork24.Helpers;

namespace HomeWork24.TruckStates
{
    internal class InBaseState : ITruckState
    {
        public void ChangeDriver(Truck truck)
        {
            Console.WriteLine("Водитель успешно заменен");
            truck.Driver = CreateDriver.GetDriver();
        }

        public void StartRun(Truck truck)
        {
            Console.WriteLine("Грузовик отправился в путь");
            truck.TruckState = new InRunState();
            truck.State = "run";
        }

        public void StartRepair(Truck truck)
        {
            Console.WriteLine("Грузовик отправился в ремонт");
            truck.TruckState = new InRepairState();
            truck.State = "repair";
        }
    }
}