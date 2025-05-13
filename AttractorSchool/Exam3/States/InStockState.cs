using Exam3.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Exam3.States
{
    internal class InStockState : IProductState
    {
        const string path = "../../../data.json";
        public void GiveToTheWiner(Product prod)
        {
            throw new WrongProductStateException("Нельзя отдать продукт, так как он не участвует в торгах");
        }

        public void RaisePrice(Product prod)
        {
            throw new WrongProductStateException("Вы не можете поднять цену, так как продукт не участвует в торгах");
        }

        public void SetOff(Product prod)
        {
            throw new WrongProductStateException("Нельзя снять продукт с торгов, который не участвует в торгах");
        }

        public void SetUp(Product prod)
        {
            Console.WriteLine("Продукт успешно выставлен на торги");
            prod.State = new ForSaleState();
            prod.StateStr = "inSale";
            string json = JsonSerializer.Serialize(prod);
            File.WriteAllText(path, json);
        }
    }
}