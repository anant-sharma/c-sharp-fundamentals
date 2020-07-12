using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class ListDemo
    {
        public static void Init()
        {
            var numbers = new List<int> { 2, 7, 3, 5 };
            numbers.Add(15);
            numbers.AddRange(new int[3] { 21, 25, 29 });

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Index of 15: " + numbers.IndexOf(15));

            Console.WriteLine("Count of numbers: " + numbers.Count);

            numbers.RemoveAt(2);
            Console.WriteLine("Effect of RemoveAt(2)");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }

            numbers.Clear();
            Console.WriteLine("Count of numbers: " + numbers.Count);
        }
    }
}
