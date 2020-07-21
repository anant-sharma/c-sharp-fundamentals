using System;

namespace MethodOverriding
{
    internal class Rectangle : Shape
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}
