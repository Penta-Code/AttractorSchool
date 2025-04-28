using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    internal class Store
    {
        public Product[] Products { get; }

        public Store()
        {
            Products = GetProducts();
        }

        public void DoInspection()
        {
            Console.WriteLine("Product | Delivered at | Storage place | S. life days | Fresh");
            Console.WriteLine("--------+--------------+---------------+--------------+------");
            foreach (var product in Products)
            {
                Console.WriteLine($"{product.Name}    | {product.DeliveryTimestamp.ToShortDateString()}    | {product.StoragePlace}       | {product.StorageLifeDays}      | {product.IsFresh()}");
            }
        }

        private DateTime GetRandomDeliveryTime()
        {
            int randomNum = new Random().Next(1, 201);
            var deliveryTime = DateTime.Now.AddDays(-randomNum);
            return deliveryTime;
        }

        public string GetRandomStoragePlace()
        {
            int randomNum = new Random().Next(1, 3);
            if (randomNum == 1)
            {
                return "Showcase";
            }
            return "Icebox";
        }

        private Product[] GetProducts()
        {
            Product[] prods = new Product[20];

            for (int i = 0; i < prods.Length; i++)
            {
                var random = new Random().Next(1, 6);

                switch (random)
                {
                    case 1:
                        prods[i] = new Milk(GetRandomDeliveryTime(), GetRandomStoragePlace());
                        break;
                    case 2:
                        prods[i] = new Salt(GetRandomDeliveryTime(), GetRandomStoragePlace());
                        break;
                    case 3:
                        prods[i] = new Fish(GetRandomDeliveryTime(), GetRandomStoragePlace());
                        break;
                    case 4:
                        prods[i] = new Corn(GetRandomDeliveryTime(), GetRandomStoragePlace());
                        break;
                    case 5:
                        prods[i] = new Stew(GetRandomDeliveryTime(), GetRandomStoragePlace());
                        break;
                    default:
                        break;
                }
            }
            return prods;
        }
    }
}