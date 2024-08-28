using System;
using System.Collections.Generic;

namespace Task2
{
    public class SortStrategy: ISortStrategy
    {
        public List<IComparable> Sort(List<IComparable> list)
        {
            list.Sort();
            return list;
        }
    }
}