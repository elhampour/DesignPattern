using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Step2
{
    public class Car
    {
        public Car(int id, string brand, string model)
        {
            Id = id;
            Brand = brand;
            Model = model;
        }

        public Car(int id, string screenType, double weight, double height)
        {
            Id = id;
            ScreenType = screenType;
            Weight = weight;
            Height = height;
        }

        public Car(int id, string brand, string model, string color, int numberDoors)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Color = color;
            NumberDoors = numberDoors;
        }

        public Car(int id, string brand, string screenType, double weight, double height)
        {
            Id = id;
            Brand = brand;
            ScreenType = screenType;
            Weight = weight;
            Height = height;
        }

        public Car(int id, string brand, string model, string color, int numberDoors, string screenType, double weight, double height)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Color = color;
            NumberDoors = numberDoors;
            ScreenType = screenType;
            Weight = weight;
            Height = height;
        }

        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int NumberDoors { get; set; }

        public string ScreenType { get; set; }

        public double Weight { get; set; }

        public double Height { get; set; }
    }
}
