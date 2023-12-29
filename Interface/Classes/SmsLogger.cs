using System;

namespace Interface;

class SmsLogger : ILogger
{
    public void WriteLog()
    {
        // throw new NotImplementedException();
        Console.WriteLine("Sms yoluyla loglandı.");
    }
}