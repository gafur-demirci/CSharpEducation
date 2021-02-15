using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // customer ve customer1 nesnesi aynı şekilde tanımlanmış demektir bu kullanım ile yani burada default olan parametresiz ctor çalışacaktır.

            Customer customer = new Customer { Id = 1, FirstName = "Ali", LastName = "Demir", City = "Ankara" };
            Customer customer1 = new Customer();

            customer1.Id = 2;
            customer1.FirstName = "Ahmet";
            customer1.LastName = "Düz";
            customer1.City = "Düzce";

            // customer2 ise method olarak parametreli hali çalışacaktır.

            Customer customer2 = new Customer(3, "Ayşe", "Demirel", "Bayburt");

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);


            // Bu ayrım customerManager için de aynıdır.
            // Bir class a birden fazla ctor tanımlanabilir.

            // customerManager da 

            // bu şekilde default ctor çalışır. Ama List metodu çağırıldığında tanımlana default ctor a uygun olduğundan 15 görünür.

            CustomerManager customerManager = new CustomerManager();  
            customerManager.List();

            // bu şekilde method halde parametreli ctor çalışır. List metodu çağırıldığında tanımlanan parametreli ctor a uygun olarak çalıştığından 12 görünür.

            CustomerManager customerManager1 = new CustomerManager(12);
            customerManager1.List();

            Console.ReadLine();
        }
    }

    // Constructor'lar bir class ilk kez çağırıldığında yani new'lendiğinde çalışan methodd'ur. ctor tab tab ile class'ın içerisinde tanımlanabilir.

    class Customer
    {
        // default ctor
        public Customer()
        {
            Console.WriteLine("Customer yapıcı blok çalıştı.");
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            // bu şekilde yazarak oluşturulan customer objesini method olarak tanımladığımızda özelliklerine girilen değerlerin çıktısını görebiliriz.
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

    class CustomerManager
    {
        // default Constructor
        public CustomerManager()
        {
            Console.WriteLine("CustomerManager yapıcı blok çalıştı.");

        }
        private int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public void List()
        {
            Console.WriteLine("Listed! {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
}
