using FactoryPattern.Beverages;
using FactoryPattern.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Condiments
{
    internal abstract class DecoratorCondiment : Beverage
    {
        protected Beverage baseBeverage;

        public override BeverageSize Size
        {
            get { return baseBeverage.Size; }
            set { baseBeverage.Size = value; }
        }

        public abstract override double Cost();

        protected DecoratorCondiment(Beverage beverage)
        {
            baseBeverage = beverage;
        }

        public abstract override string GetDescription();

    }
}
