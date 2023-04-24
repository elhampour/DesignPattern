namespace Bridge.Step2
{
    public abstract class Pizza
    {
        protected string sauce;
        protected string toppings;
        protected string crust;

        public abstract void Deliver();
    }
}
