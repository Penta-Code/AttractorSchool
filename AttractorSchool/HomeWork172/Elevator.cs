using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork172
{
    public class Elevator
    {
        private int CurrentFloor { get; set; }
        private int Capacity { get; set; }
        private int MaxFloor { get; set; }

        public Elevator(int currentFloor, int capacity, int maxFloor)
        {
            CurrentFloor = currentFloor;
            Capacity = capacity;
            MaxFloor = maxFloor;
        }

        public Elevator(int currentFloor) : this(currentFloor, 200, 18)
        { }

        public void Move(int floor)
        {
            if (IsAllowableFloor(floor))
            {
                if (floor > CurrentFloor)
                {
                    for (int i = CurrentFloor; i <= MaxFloor; i++)
                    {
                        Console.WriteLine($"Current floor is - {CurrentFloor}");
                    }
                }
                else if (floor < Capacity)
                {
                    for (int i = CurrentFloor; i >= 0; i--)
                    {
                        Console.WriteLine($"Current floor is - {CurrentFloor}");
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        public bool IsAllowableWeight(int weight) => Capacity <= weight ? true : false;

        public bool IsAllowableFloor(int floor) => MaxFloor <= floor ? true : false;
    }
}
