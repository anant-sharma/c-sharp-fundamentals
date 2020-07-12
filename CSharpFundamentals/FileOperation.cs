using System;
using System.IO;
namespace CSharpFundamentals
{
    public class FileOperation
    {
        public static void Init()
        {
            File.Create("/Users/anant/Desktop/projects/file.txt");

            var dirs = Directory.GetDirectories("/Users/anant/Desktop/projects");
            foreach(var dir in dirs)
            {
                Console.WriteLine(dir);
            }
        }

        public static void CountWords()
        {
            string content = File.ReadAllText("/Users/anant/Desktop/projects/file.txt");

            Console.WriteLine("Word Count : " + content.Split(" ").Length);
        }
    }
}
