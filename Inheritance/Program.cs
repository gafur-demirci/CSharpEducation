using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "At"
            };
            Student student = new Student
            {
                Id = 2,
                FirstName = "Ayşe",
                LastName = "Ay",
                Departmant = "Engeenring"
            };

            Person[] people = new Person[3]
            {
                new Student{ FirstName="Engin"},
                new Customer{ FirstName="Ahmet"},
                new Person{FirstName="Derin"}
            };

            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
    // Bir class sadece bir tane ana class yani kalıtımsal olarak sadece tek bir class ile bağ kurabilir ( her çocuğun tek babası olduğu gibi) 
    // Ama interfaceler de birden fazla olabilir. (inheritance ile interface arasındaki önemli fark)
    // Bir class önce inheritance olmak üzere bir class ile ilişkilendirilebilir ardından istenilen kadar interface eklenebilir.
    // Class ların tek başlarına anlamı vardır (ana class özellikle) ama interfacelerin yoktur bu nedenle her class new lenebilir ama interfaceler new lenemez.
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Departmant { get; set; }
    }
}
