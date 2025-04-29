using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20_2
{
    internal static class FileReader
    {
        public static string[] GetEmployess(string path)
        {
            return File.ReadAllLines(path);
        }

        public static void WriteFilteredEmployess(string path, string[] employees)
        {
            try
            {
                File.WriteAllLines(path, employees);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
            }
        }
    }
}