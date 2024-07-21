using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeRegistry registry = new ShapeRegistry();

            // Add prototype shapes
            registry.AddShape("SmallCircle", new Circle(5));
            registry.AddShape("LargeCircle", new Circle(10));
            registry.AddShape("Rectangle", new Rectangle(6, 8));

            // Clone and use shapes
            IShape shape1 = registry.GetShape("SmallCircle");
            shape1.Draw();

            IShape shape2 = registry.GetShape("LargeCircle");
            shape2.Draw();

            IShape shape3 = registry.GetShape("Rectangle");
            shape3.Draw();

            // Modify a cloned shape
            Circle clonedCircle = (Circle)registry.GetShape("SmallCircle");
            clonedCircle.Radius = 15;
            clonedCircle.Draw();

            // Original prototype remains unchanged
            registry.GetShape("SmallCircle").Draw(); 
        }
    }
}