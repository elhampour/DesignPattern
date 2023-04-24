using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Step2
{
    public class VehicleCache
    {
        private Dictionary<string, Vehicle> Cache = new Dictionary<string, Vehicle>();

        public VehicleCache()
        {
            Car car = new Car();
            car.TopSpeed = 261;

            Bus bus = new Bus();
            bus.Doors = 4;

            Cache.Add("Bugatty chiron", car);
            Cache.Add("Mercedees", bus);
        }

        public Vehicle Get(string key)
        {
            return Cache.Where(a => a.Key == key).First().Value.Clone();
        }
    }
}
