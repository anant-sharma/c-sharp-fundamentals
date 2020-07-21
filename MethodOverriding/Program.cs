using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Create Shapes List
            List<Shape> shapes = new List<Shape>();

            // Add Shapes
            shapes.Add(new Square());
            shapes.Add(new Rectangle());
            shapes.Add(new Cuboid());

            // Draw shapes
            shapes.ForEach(s => s.Draw());
        }
    }
}
