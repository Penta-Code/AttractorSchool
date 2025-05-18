using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork27
{
    internal class SortReverseArray<T>
    {
        public static T[] Sort(T[] list)
        {
            Array.Sort(list);
            return list;
        }

        public static T[] Reverse(T[] list)
        {
            Array.Reverse(list);
            return list;
        }
    }
}