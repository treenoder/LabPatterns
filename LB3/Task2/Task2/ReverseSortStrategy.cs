using System;
using System.Collections.Generic;

namespace Task2
{
    public class ReverseSortStrategy: ISortStrategy
    {
        public List<IComparable> Sort(List<IComparable> list)
        {
            list.Sort();
            list.Reverse();
            return list;
        }
    }
}