using System;

namespace MethodOverriding
{
    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }
}
