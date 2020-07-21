using System;

namespace MethodOverriding
{
    internal class Square : Shape
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Drawing a Square");
        }
    }
}
