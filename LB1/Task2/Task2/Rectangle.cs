using System;

namespace Task2
{
    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        
        public object Clone()
        {
            return new Rectangle(Width, Height);
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with width {Width} and height {Height}");
        }
    }
}