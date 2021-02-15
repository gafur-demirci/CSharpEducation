using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Customer
    {
        //int Id;  // Bu şekilde tanımlamak private olduğunu gösterir ve private lar sadece bulunduğu class'ın içerisinde çalışır.
        // üstteki gibi kullanılırsa ya da private int Id {get; set;} olarak Customer class ının içerisinde tanımlanırsa Customer içerisindeki methodlarda kullanılabilir 
        // ama Customer class ı dışına çıkamaz. (Çünkü private)

        protected int Id { get; set; }
        public void Save()
        {
            //int Id;   // Burada da aynı kural geçerli blok dışında kullanılamaz.
        }

        public void Delete()
        {

        }

    }

    class Student : Customer
    {
        public void Save2()
        {
            Id = 4;   // Protected olduğu için yazıldığı class ı inheritance eden class lar da da kullanılabilir ama privete da inheritance etse bile kullanılamaz. 
        }
    }

    internal class Course
    {
        public string Name { get; set; }
    }
}

// kapsama sıralaması : public > internal > protected > private

// default olarak class lar internal etiketi taşırlar.
// internal bir class aynı proje içerisinde açılan farklı class larda kullanım erişim iznine sahip olmasını sağlar.
// ana class public ya da internal olabilir ama iç içe class larda private olarak class da tanımlanabilir.
// public bir class aynı solution içerisinde farklı projelerde kullanıma açılmasını sağlar.
// minimum erişime göre projeler tasarlanmalı kod okunurluğu için.