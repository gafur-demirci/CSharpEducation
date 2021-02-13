using System;

namespace InterfacesDemo
{
    class Program
    {
        // Bir class birden fazla interface i implemente edebilir. ( Bu sayede bir interface içerisinde ki imzayı kullanmayan class a da implemente etmeye gerek kalmamış olur.)
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eat!");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager get Salary!");
        }

        public void Work()
        {
            Console.WriteLine("Manager Work!");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eat!");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker get Salary!");
        }

        public void Work()
        {
            Console.WriteLine("Worker Work!");
        }
    }

    class Robot : IWorker
    {

        public void Work()
        {
            Console.WriteLine("Robot Work!");
        }
    }
}
