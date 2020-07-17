using System;

namespace AnanymousMethods
{
    public delegate void Print(string s);

    class Program
    {
        static void Main(string[] args)
        {
            print("Hello World! from anonymous method");
        }

        static Print print = delegate (string s)
        {
            Console.WriteLine(s);
        };
    }
}
