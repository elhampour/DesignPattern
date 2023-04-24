namespace FactoryMethod.Step1
{
    public class Restaurant
    {
        public object? OrderBurger(string request)
        {
            if (request == "BEEF")
            {
                BeefBurger burger = new BeefBurger();
                burger.Prepare();
                return burger;
            }
            else if (request == "VEGGIE")
            {
                VeggieBurger burger = new VeggieBurger();
                burger.Prepare();
                return burger;
            }
            return null;
        }
    }
}
