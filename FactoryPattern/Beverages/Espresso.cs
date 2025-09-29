using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Enums;

namespace FactoryPattern.Beverages
{
    internal class Espresso : Beverage
    {
        public Espresso() : this(BeverageSize.Grande) { }

        public Espresso(BeverageSize size)
        {
            Size = size;
            description = "Espresso";
        }

        public override double Cost()
        {
            switch (Size)
            {
                case BeverageSize.Tall:
                    return 1.99;
                case BeverageSize.Grande:
                    return 2.99;
                case BeverageSize.Vendi:
                    return 3.99;
                default:
                    throw new ArgumentException("Invalid size");
            }
        }
    }
}
