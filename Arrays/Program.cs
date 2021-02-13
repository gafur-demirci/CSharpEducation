using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[5];                                 // İki kullanım da aynıdır. Bu kullanımda altta ki gibi tek tek tanımlanır.
            string[] studentss = new string[3] { "Engin", "Derin", "Ali" };    // İki kullanım da aynıdır. Bu kullanımda {} içerisine tanımlanır.
            students[0] = "Ali";
            students[1] = "Veli";
            students[2] = "Bahar";
            students[3] = "Merve";
            students[4] = "Eda";

            // Arrayler yalnızca tek bir veri türü ile çalışır yani string bir array'e sadece string değerler atanabilir.
            // Arrayler de belirtilen sınırı aşmak mümkün değildir çünkü bellekte belirtilen sınır kadar yer tutar.

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[] students2 = new[] { "Engin", "Derin", "Ali" };  // İki kullanım da aynıdır fark yoktur. Bu kullanımın üsttekinden farkı bir adet belirtme zorunluluğu olmaması.
            string[] students3 = { "Engin", "Derin", "Ali" };        // İki kullanım da aynıdır fark yoktur. Bu kullanımın üsttekinden farkı bir adet belirtme zorunluluğu olmaması.

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            // Multidimensional Arrays

            string[,] region = new string[7, 3]                      // 7 satır 3 sütunluk alan oluşturur.
            {
                {"İstanbul","Tekirdağ","Kocaeli" },                  // Her bir satırı temsil eder.
                {"Zonguldak","Trabzon","Artvin" },
                { "Ankara","Kayseri","Sivas"},
                { "Antalya","Adana","Mersin"},
                { "İzmir","Manisa","Muş"},
                {"Erzurum","Van","Ağrı" },
                { "Diyarbakır","Hatay","Gaziantep"},
            };

            for (int i = 0; i <= region.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= region.GetUpperBound(1); j++)
                {
                    Console.WriteLine(region[i,j] );
                }
                Console.WriteLine("*****************");
            }

        }
    }
}
