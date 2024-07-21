using System;

namespace Task2
{
    public class Circle : IShape
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public object Clone()
        {
            return new Circle(Radius);
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {Radius}");
        }
    }
}