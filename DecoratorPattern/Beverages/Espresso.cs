using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Espresso : Beverage
    {
        public Espresso() : this(Size.Grande) { }

        public Espresso(Size size)
        {
            Size = size;
            description = "Espresso";
        }

        public override double Cost()
        {
            switch (Size)
            {
                case Size.Tall:
                    return 1.99;
                case Size.Grande:
                    return 2.99;
                case Size.Vendi:
                    return 3.99;
                default:
                    throw new ArgumentException("Invalid size");
            }
        }
    }
}
