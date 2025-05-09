namespace HomeWork24.TruckStates
{
    public interface ITruckState
    {
        void ChangeDriver(Truck truck);
        void StartRun(Truck truck);
        void StartRepair(Truck truck);
    }
}