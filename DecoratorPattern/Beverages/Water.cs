using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Water : Beverage
    {
        public Water() : this(Size.Grande) { }

        public Water(Size size)
        {
            Size = size;
            description = "Water";
        }

        public override double Cost()
        {
            switch (Size)
            {
                case Size.Tall:
                    return 0.49;
                case Size.Grande:
                    return 0.74;
                case Size.Vendi:
                    return 0.99;
                default:
                    throw new ArgumentException("Invalid size");
            }
        }
    }
}
