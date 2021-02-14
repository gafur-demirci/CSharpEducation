using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database database = new Database();

            Database database = new SqlServer();
            database.Add();
            database.Delete();
            Database database1 = new Oracle();
            database1.Add();
            database1.Delete();

        }
    }
    // İnterface'ler de olduğu gibi abstract class'lar da new lenemezler.
    // Class'lar inheritance olarak sadece bir tane abstract class alabilir ama birden fazla interface alabilir.
    abstract class Database
    {
        // Tamamlanmış method
        // Her database için Add methodu aynıdır.
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        // Tamamlanmamış method
        // Database lerde farklı delete methodları olsun demek.
        public abstract void Delete();
    }

    class SqlServer : Database                         // SqlServer , database i inheritance edebilir bu sayade sadece delete methodu gelir çünkü abstract  method aynı zamanda virtual olarak 
                                                       // davrandığı içinden implemente ederken override olarak gelir.
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SqlServer");
        }
    }

    class Oracle : Database                            // Oracle , database i inheritance edebilir bu sayade sadece delete methodu gelir çünkü abstract  method aynı zamanda virtual olarak 
                                                       // davrandığı içinden implemente ederken override olarak gelir.
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
