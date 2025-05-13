using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Exam3
{
    internal class ProductsInit
    {
        Product[] products = [];
        private int _id;
        private string _name;
        private int _price;
        string _state;
        private int _qty;

        JsonSerializerOptions options = new()
        {
            WriteIndented = true,
        };

        private void FillPropductsList()
        {
            Console.WriteLine("Введите количество продуктов, которое вы хотите добавить:");
            string input = Console.ReadLine();

            while (!int.TryParse(input, out _qty))
            {
                Console.WriteLine("Не верный ввод. Введите число. Например: 2, 5, 20");
                input = Console.ReadLine();
            }

            products = new Product[_qty];

            for (int i = 0; i < products.Length; i++)
            {
                //Получаем валидный Id продукта
                Console.WriteLine("Введите Id продукта");
                string prop = Console.ReadLine();

                while (!int.TryParse(prop, out _id))
                {
                    Console.WriteLine("Id продукта должно быть число. Например: 2, 5, 15");
                    prop = Console.ReadLine();
                }

                //Получаем название продукта
                Console.WriteLine("Введите название продукта");
                _name = Console.ReadLine();

                //Получаем валидную цену продукта
                Console.WriteLine("Введите цену продукта");
                prop = Console.ReadLine();

                while (!int.TryParse(prop, out _price))
                {
                    Console.WriteLine("Цена продукта должно быть число. Например: 10, 100, 1500");
                    prop = Console.ReadLine();
                }

                //Получаем валидную состояние продукта
                Console.WriteLine("Введите состояние продукта. Допустимые состояния: inStock, forSale, sold");
                _state = Console.ReadLine();

                while (_state != "inStock" && _state != "forSale" && _state != "sold")
                {
                    Console.WriteLine("Не верное состояние продукта. Допустимые состояния: inStock, forSale, sold");
                    _state = Console.ReadLine();
                }

                //Создаем продукт
                products[i] = new Product(_id, _name, _price, _state);
            }

            string prodJson = JsonSerializer.Serialize(products, options);
            File.WriteAllText("../../../data.json", prodJson);
        }

        public Product[] GetProducts()
        {
            if (products.Length != 0)
            {
                return products;
            }

            string readData = File.ReadAllText("../../../data.json");

            if (readData.Length == 0)
            {
                Console.WriteLine("Продукты отсутствуют в списке");
                FillPropductsList();
                return products;
            }
            else
            {
                products = JsonSerializer.Deserialize<Product[]>(readData);
                return products;
            }
        }
    }
}