using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    internal abstract class Product
    {
        public DateTime DeliveryTimestamp { get; set; }
        public string StoragePlace { get; set; }
        public double StorageLifeDays { get; set; }
        public string Name { get; set; }

        public Product(DateTime deliveryTimestamp, string storagePlace )
        {
            DeliveryTimestamp = deliveryTimestamp;
            StoragePlace = storagePlace;
        }

        public virtual double LifeDays(string place)
        {
            if (place.Equals("Icebox"))
            {
                return 365;
            }

            else return 365 / 12;
        }

        public abstract bool IsFresh();
    }
}