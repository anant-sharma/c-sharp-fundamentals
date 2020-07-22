using System;

namespace AbstractFundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var square = new Square();
            square.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
