namespace FactoryMethod.Step4
{
    public class BeefBurgerRestaurant : Restaurant
    {
        public override Burger CreateBurger()
        {
            return new BeefBurger();
        }
    }
}
