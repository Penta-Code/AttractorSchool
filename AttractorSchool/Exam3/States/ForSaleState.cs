using Exam3.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Exam3.States
{
    internal class ForSaleState : IProductState
    {
        const string path = "../../../data.json";
        public void GiveToTheWiner(Product prod)
        {
            if (prod.Price == 0)
            {
                throw new WrongProductStateException("Нельзя отдать продукт бесплатно");
            }
            else
                prod.State = new SoldState();
        }

        public void RaisePrice(Product prod)
        {
            prod.Price += 10;
            Console.WriteLine($"Цена на продукт повышена. Новая цена = {prod.Price}");
            string json = JsonSerializer.Serialize(prod);
            File.WriteAllText(path, json);
        }

        public void SetOff(Product prod)
        {
            prod.State = new InStockState();
            Console.WriteLine("Продукт успешно вернулся на склад");
            string json = JsonSerializer.Serialize(prod);
            File.WriteAllText(path, json);
        }

        public void SetUp(Product prod)
        {
            throw new Exception("Продукт уже на торгах");
        }
    }
}