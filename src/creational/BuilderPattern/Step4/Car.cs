namespace BuilderPattern.Step4
{
    public class Car
    {
        internal Car(int id, string brand, string model, string color, int numberDoors, string screenType, double weight, double height)
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
