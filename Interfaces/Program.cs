using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Walter w = new Person();
            w.SayMyName();

            Smith s = new Person();
            s.SayMyName();
        }
    }

    interface Walter
    {
        void SayMyName();
    }

    interface Smith
    {
        void SayMyName();
    }

    class Person: Walter, Smith
    {
        void Walter.SayMyName()
        {
            Console.WriteLine("My name is Heisenberg...");
        }

        void Smith.SayMyName()
        {
            Console.WriteLine("My name is Smith...");
        }
    }
}
