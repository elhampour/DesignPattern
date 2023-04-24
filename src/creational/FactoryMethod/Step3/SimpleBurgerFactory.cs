using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Step3
{
    public class SimpleBurgerFactory
    {
        public Burger CreateBurger(string request)
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

            return burger;
        }
    }
}
