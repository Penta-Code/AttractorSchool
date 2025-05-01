using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2
{
    internal class InputProcessing
    {
        public static string Processing()
        {
            Console.Write("\nВведите символ: ");
            string input = Console.ReadLine().ToLower();

            foreach (char myChar in input)
            {
                if (char.IsWhiteSpace(myChar) || char.IsDigit(myChar) || char.IsPunctuation(myChar))
                    throw new ArgumentException();
            }

            return input;
        }
    }
}