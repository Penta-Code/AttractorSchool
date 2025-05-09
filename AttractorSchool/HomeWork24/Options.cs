using HomeWork24.Helpers;
using System.Text.Json;

namespace HomeWork24
{
    internal static class Options
    {
        private static int updateCounter = 0;

        public static void ShowAllTrucksData(string readPath, Truck[] trucks)
        {
            Console.WriteLine("\n{0,-3}|{1,-20}|{2,-15}|{3,-20}", "№", "Грузовик", "Водитель", "Состояние");
            foreach (var item in trucks)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void ShowTruckDataById(string readPath, Truck[] trucks)
        {
            bool work = true;

            Console.WriteLine("Введите Id грузовика:");
            string input = Console.ReadLine();

            while (work)
            {
                if (!int.TryParse(input, out int truckId))
                {
                    Console.WriteLine("Грузовик не найден. Введите Id грузовика и попробуйте еще раз:");
                    input = Console.ReadLine();
                }
                else
                {
                    for (int i = 0; i < trucks.Length; i++)
                    {
                        if (trucks[i].Id == truckId)
                        {
                            Console.WriteLine("\n{0,-15}|{1,-20}", "№", trucks[i].Id);
                            Console.WriteLine("{0,-15}|{1,-20}", "Марка", trucks[i].Name);
                            Console.WriteLine("{0,-15}|{1,-20}", "Водитель", trucks[i].Driver.ToString());
                            Console.WriteLine("{0,-15}|{1,-20}", "Состояние", trucks[i].State);
                            work = false;
                            break;
                        }

                        if (i == trucks.Length - 1)
                        {
                            Console.WriteLine("Грузовик не найден. Введите Id грузовика и попробуйте еще раз:");
                            input = Console.ReadLine();
                        }
                    }
                }
            }
        }

        public static void UpdateTruckState(string writePath, string state, Truck truck)
        {
            if (state == "run")
            {
                truck.Run();
                truck.State = "run";
                Console.WriteLine($"Грузовик {truck.Name} - На маршруте");
                string truckJson = JsonSerializer.Serialize(truck);
                FileReader.WriteData(writePath, truckJson);
                updateCounter++;
            }

            if (state == "change driver")
            {
                truck.UpdateDriver();
                Console.WriteLine($"Грузовик {truck.Name} - Водитель заменен");
                string truckJson = JsonSerializer.Serialize(truck);
                FileReader.WriteData(writePath, truckJson);
                updateCounter++;
            }

            if (state == "repair")
            {
                truck.Repair();
                truck.State = "repair";
                Console.WriteLine($"Грузовик {truck.Name} - На СТО");
                string truckJson = JsonSerializer.Serialize(truck);
                FileReader.WriteData(writePath, truckJson);
                updateCounter++;
            }
        }

        public static void CloseAppAndWriteData(string writePath, Truck truck)
        {
            if (updateCounter > 0)
            {
                string truckJson = JsonSerializer.Serialize(truck);
                FileReader.WriteData(writePath, truckJson);
            }

            Environment.Exit(0);
        }
    }
}