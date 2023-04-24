namespace Bridge.Step3
{
    public abstract class Resturant
    {
        protected Pizza pizza;

        protected Resturant(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public abstract void AddSauce();

        public abstract void AddToppings();

        public abstract void MakeCrust(); 

        public void Deliver()
        {
            MakeCrust();
            AddSauce();
            AddToppings();
            pizza.Assemble();
            pizza.QualityCheck();
            //Order in progress
        }
    }
}
