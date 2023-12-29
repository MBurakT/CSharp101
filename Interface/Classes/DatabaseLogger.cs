using System;

namespace Interface;

class DatabaseLogger : ILogger
{
    public void WriteLog()
    {
        Console.WriteLine("Database yoluyla loglandı.");
    }
}