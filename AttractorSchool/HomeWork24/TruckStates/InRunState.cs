namespace HomeWork24.TruckStates
{
    internal class InRunState : ITruckState
    {
        public void ChangeDriver(Truck truck)
        {
            throw new Exception("Нельзя менять водителя, когда грузовик в пути");
        }

        public void StartRun(Truck truck)
        {
            throw new Exception("Грузовик уже находится в пути");
        }

        public void StartRepair(Truck truck)
        {
            Console.WriteLine("Грузовик отправляется на ремонт");
            truck.TruckState = new InRepairState();
            truck.State = "repair";
        }
    }
}