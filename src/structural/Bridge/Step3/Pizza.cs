using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Step3
{
    public abstract class Pizza
    {
        protected string sauce;
        protected string toppings;
        protected string crust;

        public abstract void Assemble();

        public abstract void QualityCheck();
    }
}
