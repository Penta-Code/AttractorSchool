namespace HomeWork20_2
{
    internal class EmployeeCollection
    {
        public Employee[] Employees { get; set; }

        public EmployeeCollection(string path)
        {
            FillEmployeesList(path);
        }

        public void PrintUsers()
        {
            if (Employees.Length < 1)
            {
                Console.WriteLine($"Файл со списком сотрудников пуст или произошла ошибка при считывании сотрудников из файла!");
                throw new NullReferenceException();
            }

            Console.WriteLine("\nСписок сотрудников:\nНомер | ФИО     | Должность  | Год  \n------|---------|------------|------");
            foreach (var emp in Employees)
            {
                Console.WriteLine($"{emp.Number}     | {emp.FirstName}  | {emp.LastName}   | {emp.Profession}   | {emp.Year}");
            }
        }

        public void FillEmployeesList(string path)
        {
            try
            {
                string[] readUsers = FileReader.GetEmployess(path);
                Employees = new Employee[readUsers.Length];

                for (int i = 0; i < readUsers.Length; i++)
                {
                    string[] props = readUsers[i].Split(' ');
                    Employees[i] = new Employee(props[0], props[1], props[2], props[3], props[4]);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Критическая ошибка:\nНе удалось найти файл по указаному пути: {path}");
                throw new FileNotFoundException();
            }
        }

        public string[] Filter(string profession)
        {
            string[] filteredEmployees = new string[0];

            Console.WriteLine("\nРезультат:\n");
            Console.WriteLine("Номер | ФИО     | Должность  | Год  ");
            Console.WriteLine("------|---------|------------|------");
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Profession == profession)
                {
                    Console.WriteLine($"{Employees[i].Number}     | {Employees[i].FirstName} {Employees[i].LastName}   | {  Employees[i].Profession}   | {Employees[i].Year}");
                    Array.Resize(ref filteredEmployees, filteredEmployees.Length + 1);
                    filteredEmployees[filteredEmployees.Length - 1] = new string($"{Employees[i].Number} {Employees[i].FirstName} {Employees[i].LastName} {Employees[i].Profession} {Employees[i].Year}");
                }
            }
            return filteredEmployees;
        }
    }
}