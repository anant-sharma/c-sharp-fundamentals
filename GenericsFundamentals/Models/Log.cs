using System;
namespace GenericsFundamentals.Models
{
    public class Log
    {
        public string Message { get; set; }
        public string Timestamp { get; set; } = DateTime.Now.ToString();

    }
}
