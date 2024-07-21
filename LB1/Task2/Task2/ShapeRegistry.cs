using System.Collections.Generic;

namespace Task2
{
    public class ShapeRegistry
    {
        private readonly Dictionary<string, IShape> _shapes = new();
        
        public void AddShape(string name, IShape shape)
        {
            _shapes[name] = shape;
        }
        
        public IShape GetShape(string name)
        {
            return (IShape)_shapes[name].Clone();
        }
    }
}