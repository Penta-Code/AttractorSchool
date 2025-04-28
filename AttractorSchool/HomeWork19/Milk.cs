using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    internal class Milk : Product
    {

        public Milk(DateTime deliveryTimestamp, string storagePlace) : base(deliveryTimestamp, storagePlace)
        {
            DeliveryTimestamp = deliveryTimestamp;
            StoragePlace = storagePlace;
            StorageLifeDays = LifeDays(StoragePlace);
            Name = "Milk";
        }

        public override bool IsFresh()
        {
            DateTime expDate = DeliveryTimestamp.AddDays(StorageLifeDays);
            bool IsFresh = expDate > DateTime.Now;
            return IsFresh;
        }

        public override double LifeDays(string place)
        {
            if (place.Equals("Icebox"))
            {
                return 60;
            }

            else return 60 / 2;
        }
    }
}