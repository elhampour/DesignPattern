namespace Bridge.Step1
{
    public abstract class Pizza
    {
        protected string sauce;
        protected string toppings;
        protected string crust;

        public abstract void Deliver();
    }
}
