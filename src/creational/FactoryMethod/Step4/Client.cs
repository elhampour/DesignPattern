namespace FactoryMethod.Step4
{
    public class Client
    {
        public void Do()
        {
            Restaurant beefResto = new BeefBurgerRestaurant();
            Burger beefBurger = beefResto.OrderBurger();

            Restaurant veggieResto = new VeggieBurgerRestaurant();
            Burger veggieBurger = veggieResto.OrderBurger();
        }
    }
}
