namespace Prototype.Step2
{
    public class Bus : Vehicle
    {
        public int Doors { get; set; };

        public Bus()
        {

        }

        public Bus(Bus car) : base(car)
        {
            this.Doors = car.Doors;
        }

        public override Vehicle Clone()
        {
            return new Bus(this);
        }
    }
}
