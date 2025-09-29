using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Enums;

namespace FactoryPattern.Beverages
{
    internal abstract class Beverage
    {
        public virtual BeverageSize Size { get; set; }

        protected string description = string.Empty;

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
