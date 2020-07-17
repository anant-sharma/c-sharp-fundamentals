using System;
using System.Collections.Generic;

namespace GenericsFundamentals
{
    public class FileProcessor
    {
        public static List<T> ReadFile<T>(string filePath) where T: class, new()
        {

            return new List<T>();
        }

        public static void WriteFile<T>(string filePath, List<T> data) where T : class
        {

        }
    }
}
