using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        /// <summary>
        /// small
        /// </summary>
        Tall,

        /// <summary>
        /// medium
        /// </summary>
        Grande,

        /// <summary>
        /// large
        /// </summary>
        Vendi 
    }

    internal abstract class Beverage
    {
        public Size Size { get; set; }

        protected string description = string.Empty;

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
