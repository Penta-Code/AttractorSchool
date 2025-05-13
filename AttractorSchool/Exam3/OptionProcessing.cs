using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    internal class OptionProcessing(Product[] prods, Options option, int selectedOption, int id)
    {
        public void Options()
        {
            bool isFound = false;

            if (selectedOption == 1)
            {
                foreach (var item in prods)
                {
                    if (id == item.Id)
                    {
                        option.StartSale(item);
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    Console.WriteLine("Продукт с указанным Id не найден!");
                }
            }

            if (selectedOption == 2)
            {
                foreach (var item in prods)
                {
                    if (id == item.Id)
                    {
                        option.PriceUp(item);
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    Console.WriteLine("Продукт с указанным Id не найден!");
                }
            }

            if (selectedOption == 3)
            {
                foreach (var item in prods)
                {
                    if (id == item.Id)
                    {
                        option.GiveToWinner(item);
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    Console.WriteLine("Продукт с указанным Id не найден!");
                }
            }

            if (selectedOption == 4)
            {
                foreach (var item in prods)
                {
                    if (id == item.Id)
                    {
                        option.StopSale(item);
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    Console.WriteLine("Продукт с указанным Id не найден!");
                }
            }
        }
    }
}