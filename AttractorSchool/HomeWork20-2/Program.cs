using System.Text;

namespace HomeWork20_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            EmployeeCollection employees = new();

            try
            {
                employees.EmployeesList = File.ReadAllLines("../../../input.txt");
                employees.CreateUsers(employees.EmployeesList);
                employees.PrintUsers();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Файл не найден по указанному пути!");
            }
        }
    }
}
