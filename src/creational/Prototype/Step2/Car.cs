namespace Prototype.Step2
{
    public class Car : Vehicle
    {
        public int TopSpeed { get; set; }

        public Car()
        {

        }

        public Car(Car car) : base(car)
        {
            this.TopSpeed = car.TopSpeed;
        }

        public override Vehicle Clone()
        {
            return new Car(this);
        }
    }
}
