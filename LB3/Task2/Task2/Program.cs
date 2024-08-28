using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SortedList(new SortStrategy());
            list.Add(3);
            list.Add(1);
            list.Add(2);
            Console.WriteLine("Ascending order:");
            list.Display();
            
            Console.WriteLine();
            
            list = new SortedList(new ReverseSortStrategy());
            list.Add(3);
            list.Add(1);
            list.Add(2);
            Console.WriteLine("Descending order:");
            list.Display();
        }
    }
}