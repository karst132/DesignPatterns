using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Enums;

namespace FactoryPattern.Beverages
{
    internal class Water : Beverage
    {
        public Water() : this(BeverageSize.Grande) { }

        public Water(BeverageSize size)
        {
            Size = size;
            description = "Water";
        }

        public override double Cost()
        {
            switch (Size)
            {
                case BeverageSize.Tall:
                    return 0.49;
                case BeverageSize.Grande:
                    return 0.74;
                case BeverageSize.Vendi:
                    return 0.99;
                default:
                    throw new ArgumentException("Invalid size");
            }
        }
    }
}
