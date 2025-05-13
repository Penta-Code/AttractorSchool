using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    internal class Menu
    {
        public void ShowProducts(Product[] prods)
        {
            Console.WriteLine("{0, -3} | {1, -20}", "#", "Продукт");

            foreach (var prod in prods)
            {
                Console.WriteLine(prod);
            }
            Console.WriteLine();
        }

        public int ShowOptions(Product[] prods, out int Id)
        {
            int option = 0;
            //int product = 0;
            Console.WriteLine("Доступны следующие действия:");
            Console.WriteLine("1. Выставить на аукцион\n2. Поднять цену\n3. Выдать победителю\n4. Снять с торгов");
            
            Console.WriteLine("Введите номер действия:");
            string inputAction = Console.ReadLine();

            while (!int.TryParse(inputAction, out option) || option < 1 || option > 4)
            {
                Console.WriteLine("Доступные номера действий: 1, 2, 3, 4");
                inputAction = Console.ReadLine();
            }

            Console.WriteLine("Введите Id продукта");
            string inputProd = Console.ReadLine();

            while (!int.TryParse(inputProd, out Id))
            {
                Console.WriteLine("Продукт не найден. Доступные Id продуктов:");
                foreach (var prod in prods)
                {
                    Console.WriteLine(prod.Id);
                }
                inputProd = Console.ReadLine();
            }

            return option;
        }
    }
}