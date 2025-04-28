using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    internal class Stew : Product
    {
        public Stew(DateTime deliveryTimestamp, string storagePlace) : base(deliveryTimestamp, storagePlace)
        {
            DeliveryTimestamp = deliveryTimestamp;
            StoragePlace = storagePlace;
            StorageLifeDays = 180;
            Name = "Stew";
        }

        public override bool IsFresh()
        {
            DateTime expDate = DeliveryTimestamp.AddDays(StorageLifeDays);
            return expDate > DateTime.Now;
        }
    }
}