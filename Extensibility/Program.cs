using System;
using System.IO;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dbMigrator = new DBMigrator(new FileLogger("/tmp/log"));
            dbMigrator.Migrate();
        }
    }

    class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log("ERROR", message);
        }

        public void LogInfo(string message)
        {
            Log("INFO", message);
        }

        private void Log(string message, string messageType)
        {
            using var streamWriter = new StreamWriter(_path, true);
            streamWriter.WriteLine(messageType + ": " + message);
        }
    }
}
