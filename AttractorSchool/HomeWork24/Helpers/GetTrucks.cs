using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HomeWork24.Helpers
{
    internal static class GetTrucks
    {
        public static Truck[] TrucksList(string readPath)
        {
            var jsonData = FileReader.ReadData(readPath);
            return JsonSerializer.Deserialize<Truck[]>(jsonData);
        }
    }
}