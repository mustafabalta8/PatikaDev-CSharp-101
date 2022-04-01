using System;

namespace Interface
{
   
   class Program
    {
        static void Main(string[] args)
        {
            Console.Write("asdf");
            
            FileLogger file = new FileLogger();;
            file.writeLog();

            DatabaseLogger database = new DatabaseLogger();
            database.writeLog();

            SmsLogger sms = new();
            sms.writeLog();

            LogManager logger = new LogManager(new FileLogger());
            logger.writeLog();
        }
    }
}
