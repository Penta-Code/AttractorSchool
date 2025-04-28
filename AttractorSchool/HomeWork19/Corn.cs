using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    internal class Corn : Product
    {
        public Corn(DateTime deliveryTimestamp, string storagePlace) : base(deliveryTimestamp, storagePlace)
        {
            DeliveryTimestamp = deliveryTimestamp;
            StoragePlace = storagePlace;
            StorageLifeDays = 150;
            Name = "Corn";
        }

        public override bool IsFresh()
        {
            DateTime expDate = DeliveryTimestamp.AddDays(StorageLifeDays);
            return expDate > DateTime.Now;
        }
    }
}
