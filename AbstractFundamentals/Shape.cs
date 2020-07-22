using System;

namespace AbstractFundamentals
{
    public abstract class Shape
    {
        public int Height { get; set; }
        public int Length { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copying this Shape.");
        }
    }
}
