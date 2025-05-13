using HW24Refactor.States;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW24Refactor.Models
{
    internal class Truck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Driver Driver { get; set; }
        public string State { get; set; } // "base", "run", "repair"

        [JsonIgnore]
        public ITruckState StateHandler { get; set; }

        public void InitializeState()
        {
            StateHandler = State switch
            {
                "base" => new InBaseState(this),
                "run" => new InRunState(this),
                "repair" => new InRepairState(this),
                _ => throw new InvalidOperationException("Неизвестное состояние")
            };
        }
    }
}