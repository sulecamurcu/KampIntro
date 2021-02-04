using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //ürün sınıfı.Bu tip sınıflarda sadece ve sadece özellik olur.Aşağıya olması gereken özelliklerini yazdık.
    {
        public int Id { get; set; } //nesneyi ayırt etmek için kullandığımız alan.Ana anahtarımızdır.
        public int CategoryId { get; set; }//Kategori,referans anahtarı.amaç kod okunurluğunu arttırmak.

        public string ProductName{ get; set; }//ürün adı
        public double UnitPrice  { get; set; }//ürünün birim fiyatı
        public int UnitsInStock { get; set; }//stok adeti

    }
    //CRUD-eklemek,okumak,güncellemek,silmek 
}
