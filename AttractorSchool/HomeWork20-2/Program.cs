using System.Text;

namespace HomeWork20_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string readFilePath = "../../../input.txt";
            const string writeFilePath = "../../../out.txt";

            EmployeeCollection employees = new(readFilePath);
            employees.PrintUsers();

            Console.Write($"\nВведите должность сотрудника: ");
            string profession = Console.ReadLine();

            var filtered = employees.Filter(profession);
            FileReader.WriteFilteredEmployess(writeFilePath, filtered);
        }
    }
}