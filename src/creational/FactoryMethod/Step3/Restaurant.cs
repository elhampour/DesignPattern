namespace FactoryMethod.Step3
{
    public class Restaurant
    {
        public Burger OrderBurger(string request)
        {
            SimpleBurgerFactory factory = new SimpleBurgerFactory();
            Burger burger = factory.CreateBurger(request);
            burger.Prepare();
            return burger;
        }
    }
}
