using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Condiments;
using FactoryPattern.Enums;

namespace FactoryPattern.Beverages
{
    internal class Chocolate : Beverage
    {
        public Chocolate() : this(BeverageSize.Grande) { }

        public Chocolate(BeverageSize size)
        {
            Size = size;
            description = "Chocolate";
        }

        public override double Cost()
        {
            switch (Size)
            {
                case BeverageSize.Tall:
                    return 1.49;
                case BeverageSize.Grande:
                    return 2.99;
                case BeverageSize.Vendi:
                    return 2.49;
                default:
                    throw new ArgumentException("Invalid size");
            }
        }
    }
}
