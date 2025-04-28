using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    internal class Salt : Product
    {
        public Salt(DateTime deliveryTimestamp, string storagePlace) : base(deliveryTimestamp, storagePlace)
        {
            DeliveryTimestamp = deliveryTimestamp;
            StoragePlace = storagePlace;
            StorageLifeDays = Double.PositiveInfinity;
            Name = "Salt";
        }

        public override bool IsFresh()
        {
            return true;
        }
    }
}