namespace HomeWork172
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevator lift = new(1);

            if(lift.CurrentFloor < lift.MaxFloor && lift.CurrentFloor > 0)
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Lift is on: {lift.CurrentFloor}\nInput floor number or input Q to exit");
                    var floorInput = Console.ReadLine();
                    if (floorInput == "Q" || floorInput == "q")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"\nYou left the lift");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Input weight to transport or input Q to exit");
                    var weightInput = Console.ReadLine();
                    if (weightInput == "Q" || weightInput == "q")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"\nYou left the lift");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }

                    int floor = Elevator.GetFloor(floorInput);
                    int weight = Elevator.GetWeight(weightInput);

                    if (lift.IsAllowableFloor(floor))
                    {
                        if (lift.IsAllowableWeight(weight))
                        {
                            lift.Move(floor);
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\nERROR: Weight must be between 0 and {lift.Capacity}\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nERROR: The floor number must be between 1 and {lift.MaxFloor}\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ERROR: Wrong initial floor number: {lift.CurrentFloor}!\nThe floor number must be between 1 and {lift.MaxFloor}\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}