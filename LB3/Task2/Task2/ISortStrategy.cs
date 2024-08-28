using System;
using System.Collections.Generic;

namespace Task2
{
    public interface ISortStrategy
    {
        List<IComparable> Sort(List<IComparable> list);
    }
}