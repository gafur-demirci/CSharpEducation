using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Merve";
            customer.LastName = "Olçun";
            customer.City = "Eskişehir";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Eda Nur",
                LastName = "Kara",
                City = "Trabzon"
            };

            Console.WriteLine(customer2.FirstName);

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
        }
    }
}
