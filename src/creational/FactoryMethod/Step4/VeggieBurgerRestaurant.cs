namespace FactoryMethod.Step4
{
    public class VeggieBurgerRestaurant : Restaurant
    {
        public override Burger CreateBurger()
        {
            return new VeggieBurger();
        }
    }
}
