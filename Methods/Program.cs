using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2 = 100;
            //var result2 = Add4(ref number1, number2);
            var result3 = Add4(out number1, number2);  // Ref ile kullanımda number1'e değer atanma zorunluluğu vardır ama out ile kullanımda bu zorunluluk yoktur.

            Add();
            Console.WriteLine(Add2(2, 5));             // 1.yol (7)
            var result = Add2(2, 5);                   // 2.yol
            Console.WriteLine(result);                 // 2.yol (7)
            Console.WriteLine(Add3(2));                // Default parametreli methot ile (7)
            //Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(number1);
            Console.WriteLine(Multiply(2, 4));         // Method Overloading
            Console.WriteLine(Multiply(2, 4, 5));      // Method Overloading
            Console.WriteLine(Add5(2, 5, 8, 4, 6));
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Add3(int n1, int n2 = 5)            // Default verilecek değerler method'un en sonunda olmalıdır.
        {
            return n1 + n2;
        }

        static int Add4(out int number1, int number2)  // Ref keyword ile normalde 20 olarak kalan number1 in değerinin method içerisindeki
                                                       // değişikliklerden etkilenecek hale gelmesini sağlar.
        {
            number1 = 30;                              // out ile gelen değişken method içerisinde set edilmek zorundadır.
            return number1 + number2;
        }

        static int Add5(params int[] numbers)          // Params ile birden fazla parametre girilmesine olanak sağlanır.
        {
            return numbers.Sum();
        }

        static int Multiply(int number1, int number2)  // Aynı method ismi ile birden fazla method tanımlanabilir lakin içerdiği parametre sayısı değişmelidir.
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
    }
}
