namespace Interface;

class Program
{
    static void Main(string[] args)
    {
        DatabaseLogger databaseLogger = new DatabaseLogger();
        // databaseLogger.WriteLog();

        FileLogger fileLogger = new FileLogger();
        // fileLogger.WriteLog();

        SmsLogger smsLogger = new SmsLogger();
        // smsLogger.WriteLog();

        // LogManager logManager = new LogManager(new DatabaseLogger());
        // LogManager logManager = new LogManager(databaseLogger);
        LogManager logManager;
        
        logManager = new LogManager(databaseLogger);
        logManager.WriteLog();

        logManager = new LogManager(fileLogger);
        logManager.WriteLog();

        logManager = new LogManager(smsLogger);
        logManager.WriteLog();
        
        if (Console.ReadLine() == "clear") Console.Clear();
    }
}
