﻿using System;

namespace Extensibility
{
    class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine("ERROR: " + message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("INFO: " + message);
        }
    }
}
