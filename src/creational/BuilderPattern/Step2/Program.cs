using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Step1
{
    public class Program
    {
        public void Do()
        {
            int id = 0;
            string brand = "";
            string model = "";
            string color = "";
            int numberDoors = 0;
            string screenType = "";
            double weight = 0;
            double height = 0;

            Car car1 = new Car(id, brand, model, color, numberDoors, screenType, weight, height);

            Car car2 = new Car(id, brand, null, color, numberDoors, null, weight, null);
        }
    }
}
