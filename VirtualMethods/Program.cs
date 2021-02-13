using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();
        }
    }

    class Database
    {                                                      // bu işlem interface lerde yapılmaz bu yüzden inheritance lar kullanılır. (ayrım yapma konusundan etkili neden)     
        public virtual void Add()                          // yalnızca void ile yazıldığında içerik ezilemez içeriği ana yapı olan Database class ın dan kalıtılan class lar için kullanabilmek için
                                                           // void den önce virtual yazarız ve inheritance olan class içerisinde override ederek ana class daki methodu ezeriz (değiştirmeye izin veririz.)
        {
            Console.WriteLine("Added by default!");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();                                    // bu kullanılırsa gene base yapı olan Database class ındaki Add() methodu çalışacaktır. Bunun yerine kendi işlemimizi yapmalıyız.
        }

    }
    class MySql:Database
    {

    }
}
