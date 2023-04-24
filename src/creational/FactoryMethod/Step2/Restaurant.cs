namespace FactoryMethod.Step2
{
    public class Restaurant
    {
        public Burger OrderBurger(string request)
        {
            Burger burger = null;

            if (request == "BEEF")
            {
                burger = new BeefBurger();
            }
            else if (request == "VEGGIE")
            {
                burger = new VeggieBurger();
            }
            burger.Prepare();
            return burger;
        }
    }
}
