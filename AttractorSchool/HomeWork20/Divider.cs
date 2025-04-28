using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20
{
    internal class Divider
    {
        public static void Divide(string x, string y)
        {
            int parseX = 0;
            int parseY = 0;

            try
            {
                parseX = int.Parse(x);
                parseY = int.Parse(y);

                double result = (double)parseX / parseY;

                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Число x или y не является числом\nStack Trace:\n{ex.StackTrace}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Нельзя делать на ноль\nError message:\n{ex.Message}\nTarget site:\n{ex.TargetSite}");
            }
        }

        public static string AskX()
        {
            Console.Write("Введите число х: ");
            return Console.ReadLine();
        }

        public static string AskY()
        {
            Console.Write("Введите число y: ");
            return Console.ReadLine();
        }
    }
}