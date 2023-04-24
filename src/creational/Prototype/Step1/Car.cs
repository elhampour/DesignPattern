namespace Prototype.Step1
{
    public class Car : Prototype
    {
        private string brand;
        private string model;
        private string color;
        private int topSpeed;

        public Car()
        {

        }

        public Car(Car car)
        {
            this.brand = car.brand;
            this.model = car.model;
            this.color = car.color;
            this.topSpeed = car.topSpeed;
        }

        public Car Clone()
        {
            return new Car(this);
        }
    }
}
