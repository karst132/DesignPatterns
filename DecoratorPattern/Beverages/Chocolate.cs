using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Beverages
{
    internal class Chocolate : Beverage
    {
        public Chocolate() : this(Size.Grande) { }

        public Chocolate(Size size)
        {
            Size = size;
            description = "Chocolate";
        }

        public override double Cost()
        {
            switch (Size)
            {
                case Size.Tall:
                    return 1.49;
                case Size.Grande:
                    return 2.99;
                case Size.Vendi:
                    return 2.49;
                default:
                    throw new ArgumentException("Invalid size");
            }
        }
    }
}
