using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    internal class Options
    {
        public void StartSale(Product prod)
        {
            prod.SetUp();
        }

        public void PriceUp(Product prod)
        {
            prod.RaisePrice();
        }

        public void GiveToWinner(Product prod)
        {
            prod.GiveToTheWinner();
        }

        public void StopSale(Product prod)
        {
            prod.SetOff();
        }

        public void ShowDetails(Product prod)
        {
            Console.WriteLine(prod);
        }
    }
}