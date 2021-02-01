using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string Aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun(); // Bir class tanımlamam için bu hareketi yapmam gerekiyor.Class örneği oluşturduk.ürün oluşturduk
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            
            Urun[] urunler = new Urun[] {urun1,urun2 };//ürün arrayı oluşturduk.array;bir veri tipinde datayı tutan yapıdır.

            foreach ( Urun urun in urunler) // "in ürünler" dedik.bu demek oluyor ki yukarıdaki urunler dizindeki verileri tek tek gezsin.foreach ile urunlere gelen datayı tek tek ekrana basarız.Yazdığımız "Urun" veri tipidir.Çalışacağı veri tipini bilecek abii...
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------------");



            }

            Console.WriteLine("---------------Metotlar--------------------");
            //instance-örnek
            //encapsulation-Kapsülleme:Sen aslında böyle ayrı ayrı yazacağın ve düzensiz olacak bir yapıyı bir düzenin içine sokuyorsun.
            SepetMenagar sepetMenagar = new SepetMenagar();

            sepetMenagar.Ekle(urun1);
            sepetMenagar.Ekle(urun2);

            sepetMenagar.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetMenagar.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);
            sepetMenagar.Ekle2("Elma", "Yeşil elma", 12,9);

        }
    }
}
