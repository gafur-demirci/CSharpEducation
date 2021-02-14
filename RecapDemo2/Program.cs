using System;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.Logger = new DatabaseLogger();
            customerManager.Logger = new SmsLogger();                // Bu şekilde gibi gibi.
            customerManager.Add();
            
        }
    }
    // Bu sayade yeni gelen Log lama türünde sadece class ı kopyalayıp new olarak isimini değiştirmek yeterli olacaktır.
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added.");
        }
    }

    // İnterface kullanma sebebimiz Database,File ve Sms için loglama kodları farklı olması.
    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms!");
        }
    }


}
