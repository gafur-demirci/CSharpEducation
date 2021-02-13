using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfaceIntro();

            // Interface ve abstract lar new lenemez.

            //IPerson person = new IPerson();  diyemeyiz.

            //IPerson person = new Customer(); //diyebiliriz.

            //Demo();

            // Hem SqlServer da hem de Oracle da kayıt yapabilmek için dizi halinde ICustomerDal kullanıldı.

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfaceIntro()
        {
            Customer customer = new Customer { Id = 1, FirstName = "Ali", LastName = "El", Address = "Kilis" };
            Student student = new Student
            {
                Id = 2,
                FirstName = "Ayşe",
                LastName = "Sev",
                Departmant = "Engineering"
            };

            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer());
        }
    }
    //Soyut nesne (tek başına anlamı yoktur.)
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    //Somut nesne
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    // Her class bağlı olduğu interface i implemente etmek zorundadır.
    // Interface ler ile birden fazla class ın içerdiği özellikler tek çatıda toplanabilir daha sonra gelecek  olan manager gibi class larda 
    // verilecek objeyi interface üzerinden vererek hem student hem customer olan kişiyi kullanmamıza olanak sağlamış oluruz.
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
