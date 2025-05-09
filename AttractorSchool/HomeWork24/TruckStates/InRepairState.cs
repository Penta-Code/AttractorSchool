using HomeWork24.Helpers;

namespace HomeWork24.TruckStates
{
    internal class InRepairState : ITruckState
    {
        public void ChangeDriver(Truck truck)
        {
            Console.WriteLine("Водитель успешно заменен");
            truck.Driver = CreateDriver.GetDriver();
        }

        public void StartRun(Truck truck)
        {
            int random = new Random().Next(1, 5);

            if (random == 2)
            {
                truck.TruckState = new InRunState();
                truck.State = "run";
            }
            else
            {
                truck.TruckState = new InBaseState();
                truck.State = "base";
            }
        }

        public void StartRepair(Truck truck)
        {
            throw new Exception("Грузовик уже в ремонте!");
        }
    }
}