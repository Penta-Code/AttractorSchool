using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    internal class Fish : Product
    {
        public Fish(DateTime deliveryTimestamp, string storagePlace) : base(deliveryTimestamp, storagePlace)
        {
            DeliveryTimestamp = deliveryTimestamp;
            StoragePlace = storagePlace;
            StorageLifeDays = LifeDays(StoragePlace);
            Name = "Fish";
        }

        public override bool IsFresh()
        {
            DateTime expDate = DeliveryTimestamp.AddDays(StorageLifeDays);
            return expDate > DateTime.Now;
        }

        public override double LifeDays(string place)
        {
            if (place.Equals("Icebox"))
            {
                return 20;
            }

            else return 20 / 6;
        }
    }
}