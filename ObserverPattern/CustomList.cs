using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CustomList<T> : List<T>
    {
        public bool TryGet(int index, out T? value)
        {
            try
            {
                value = this.ElementAt(index);
            }
            catch (ArgumentOutOfRangeException)
            {
                value = default;
                return false;
            }
            return true;
        }
    }
}
