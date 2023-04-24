namespace BuilderPattern.Step3
{
    public class CarBuilder
    {
        private int id { get; set; }

        private string brand { get; set; }

        private string model { get; set; }

        private string color { get; set; }

        private int numberDoors { get; set; }

        private string screenType { get; set; }

        private double weight { get; set; }

        private double height { get; set; }

        public CarBuilder Id(int id)
        {
            this.id = id;
            return this;
        }

        public CarBuilder Brand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public CarBuilder Model(string model)
        {
            this.model = model;
            return this;
        }

        public CarBuilder Color(string color)
        {
            this.color = color;
            return this;
        }

        public CarBuilder NumberDoors(int numberDoors)
        {
            this.numberDoors = numberDoors;
            return this;
        }

        public CarBuilder ScreenType(string screenType)
        {
            this.screenType = screenType;
            return this;
        }

        public CarBuilder Weight(double weight)
        {
            this.weight = weight;
            return this;
        }

        public CarBuilder Height(double height)
        {
            this.height = height;
            return this;
        }

        public Car Build()
        {
            return new Car(id, brand, model, color, numberDoors, screenType, weight, height);
        }
    }
}
