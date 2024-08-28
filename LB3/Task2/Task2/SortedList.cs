using System;
using System.Collections.Generic;

namespace Task2
{
    public class SortedList
    {
        private readonly ISortStrategy _strategy;
        private readonly List<IComparable> _list = new();
        
        public SortedList(ISortStrategy strategy)
        {
            _strategy = strategy;
        }
        
        public void Add(IComparable item)
        {
            _list.Add(item);
        }
        
        public void Display()
        {
            _strategy.Sort(_list);
            _list.ForEach(Console.WriteLine);
        }
    }
}