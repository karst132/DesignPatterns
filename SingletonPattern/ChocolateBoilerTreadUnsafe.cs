using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class ChocolateBoilerTreadUnsafe
    {
        private static ChocolateBoilerTreadUnsafe? instance = null;

        public static ChocolateBoilerTreadUnsafe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChocolateBoilerTreadUnsafe();
                }
                return instance;
            }
        }

        private bool empty;
        private bool boiled;

        public bool IsEmpty { get { return this.empty; } }
        public bool IsBoiled { get { return this.boiled; } }

        // This code is only started when the boiler is empty
        private ChocolateBoilerTreadUnsafe()
        {
            empty = true;
            boiled = false;

            // delay for easier testing of thread safety
            Task.Delay(100).Wait();
        }
        // To fill the boiler it must be empty and once it is full, we set the empty and boiled flag
        public void fill()
        {
            if(empty)
            {
                empty = false;
                boiled = false;
            }
        }
        // To drain the boiler, it must be full (non empty) and also boiled.
        // Once it is drained we set empty back to true
        public void drain()
        {
            if(!empty && boiled)
            {
                empty = true;
            }
        }
        // To boil the mixture, the boiler has to be full and not already boiled.
        // Once it is boiled we set the boiled flag to true
        public void boil()
        {
            if(!empty && !boiled)
            {
                boiled = true;
            }
        }
    }
}
