using System;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine("Square of " + i + " is " + Square(i));
            }
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine("Cube of " + i + " is " + Cube(i));
            }

            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine("Factorial of " + i + " is " + Factorial(i));
            }
        }

        static Func<int, int> Square = x => x * x;
        static Func<int, int> Cube = x => Square(x) * x;

        // Ref: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions#local-functions-vs-lambda-expressions
        static int Factorial(int n)
        {
            Func<int, int> nthFactorial = default(Func<int, int>);

            nthFactorial = (number) => (number < 2) ?
                1 : number * nthFactorial(number - 1);

            return nthFactorial(n);
        }
    }
}
