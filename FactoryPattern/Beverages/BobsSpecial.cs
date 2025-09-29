using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Enums;

namespace FactoryPattern.Beverages
{
    internal class BobsSpecial : Beverage
    {
        public BobsSpecial() : this(BeverageSize.Grande) { }

        public BobsSpecial(BeverageSize size)
        {
            description = "Bob's special coffee";
        }

        public override double Cost()
        {
            switch (Size)
            {
                case BeverageSize.Tall:
                    return 2.19;
                case BeverageSize.Grande:
                    return 3.24;
                case BeverageSize.Vendi:
                    return 4.29;
                default:
                    throw new ArgumentException("Invalid size");
            }
        }
    }
}
