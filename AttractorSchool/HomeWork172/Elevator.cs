namespace HomeWork172
{
    public class Elevator
    {
        public int CurrentFloor { get; private set; }
        public int Capacity { get; private set; }
        public int MaxFloor { get; set; }
        public bool Work { get; private set; } = true;

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
            Random rnd = new();
            int num = 0;


            if (floor > CurrentFloor)
            {
                Console.WriteLine($"Current floor is - {CurrentFloor}");
                while (num != 3 && CurrentFloor != floor)
                {
                    num = rnd.Next(1, 4);
                    if (num == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nLift is stuck on {CurrentFloor}! Try again!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine($"Current floor is - {++CurrentFloor}");
                    }
                }
            }
            else if (floor < CurrentFloor)
            {
                while (num != 3 && CurrentFloor != floor)
                {
                    num = rnd.Next(1, 4);
                    if (num == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nLift is stuck on {CurrentFloor}! Try again!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine($"Current floor is - {--CurrentFloor}");
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"You already on the {floor}\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public bool IsAllowableWeight(int weight) => (weight >= 0) && (weight <= Capacity) ? true : false;

        public bool IsAllowableFloor(int floor) => ((floor > 0) && (floor <= MaxFloor)) ? true : false;

        public static int GetFloor(string input)
        {
            if (int.TryParse(input, out int floor))
            {
                return floor;
            }

            return 0;
        }

        public static int GetWeight(string input)
        {
            if (int.TryParse(input, out int weight))
            {
                return weight;
            }

            return 0;
        }
    }
}