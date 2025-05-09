using HomeWork24.TruckStates;
using System.Text.Json.Serialization;

namespace HomeWork24
{
    public class Truck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Driver Driver { get; set; }
        public string State { get; set; }
        [JsonIgnore]
        public ITruckState TruckState { get; set; }

        public Truck (int id, string name, Driver driver, string state)
        {
            Id = id;
            Name = name;
            Driver = driver;
            State = state;
            SetState();
        }

        public void SetState()
        {
            if (State == "run")
            {
                TruckState = new InRunState();
            }
            else if (State == "repair")
            {
                TruckState = new InRepairState();
            }
            else if (State == "change driver")
            {
                TruckState.ChangeDriver(this);
            }
            else
                TruckState = new InBaseState();
        }

        public void Run()
        {
            TruckState.StartRun(this);
        }
        public void Repair()
        {
            TruckState.StartRepair(this);
        }
        public void UpdateDriver()
        {
            TruckState.ChangeDriver(this);
        }
        public override string ToString()
        {
            return String.Format("{0, -3}|{1, -20}|{2, -15}|{3, -20}", Id, Name, Driver.ToString(), State);
        }
    }
}