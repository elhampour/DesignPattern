namespace Prototype.Step2
{
    public abstract class Vehicle
    {
        private string brand;
        private string model;
        private string color;

        protected Vehicle()
        {
        }

        protected Vehicle(Vehicle vehicle)
        {
            this.brand = vehicle.brand;
            this.model = vehicle.model;
            this.color = vehicle.color;
        }

        public abstract Vehicle Clone();
    }
}
