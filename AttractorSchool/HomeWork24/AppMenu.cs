namespace HomeWork24
{
    internal static  class AppMenu
    {
        public static void Start(string readPath, string writePath, Truck[] trucks)
        {
            int truckId = 0;
            string truckState;
            bool work = true;

            Console.WriteLine("Меню:\n 1. Отобразить текущее состояние грузовиков\n 2. Показать данные грузовика по id\n 3. Обновить состояние грузовика\n 4. Завершить программу и выгрузить все данные\nВыберите действие:");
            string input = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(input, out int option))
                {
                    if (option == 1)
                    {
                        Options.ShowAllTrucksData(readPath, trucks);
                        break;
                    }

                    if (option == 2)
                    {
                        Options.ShowTruckDataById(readPath, trucks);
                        break;
                    }

                    if (option == 3)
                    {
                        Console.WriteLine("Укажите номер грузовика и состояние через пробел. Например: 1 run");
                        string inputStr = Console.ReadLine();

                        while (inputStr.Length == 0)
                        {
                            Console.WriteLine("Укажите номер грузовика и состояние через пробел. Например: 1 run");
                            inputStr = Console.ReadLine();
                        }

                        string[] updateData = inputStr.Split(' ');

                        if (!int.TryParse(updateData[0], out truckId))
                        {
                            throw new Exception("Не удалось считать Id грузовика");
                        }
                        else
                        {
                            for (int i = 0; i < trucks.Length; i++)
                            {
                                if (truckId == trucks[i].Id)
                                {
                                    break;
                                }

                                if (i == trucks.Length - 1)
                                {
                                    throw new Exception("Грузовик не найден по указанному Id");
                                }
                            }
                        }

                        if (updateData.Length == 3)
                        {
                            truckState = $"{updateData[1]} {updateData[2]}";
                        }
                        else
                            truckState = updateData[1];

                        if (truckState != "run" && truckState != "repair" && truckState != "change driver")
                        {
                            throw new Exception("Статус не известен");
                        }

                        Options.UpdateTruckState(writePath, truckState, trucks[--truckId]);
                        break;
                    }

                    if (option == 4)
                    {
                        Options.CloseAppAndWriteData(writePath, trucks[truckId]);
                    }
                }
                else
                {
                    Console.WriteLine("Неизвестная опция. Введите 1, 2, 3 или 4");
                    input = Console.ReadLine();
                }
            }
        }
    }
}