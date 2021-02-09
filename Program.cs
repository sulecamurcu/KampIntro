using System;

namespace OOP2_
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "123345678910";

            //Kodlama.io olsun.
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.MusteriNo = "Kodlama.io";
            musteri2.VergiNo = "123456789";



            //GerçekMüşteri-Tüzel Müşteri----Bunlar sırf birbirine benziyor diye biribirinin yerine kullanılamazlar.
            //SOLID

            Musteri musteri3 = new GercekMusteri(); //new görürsen referans no diye oku..Müsteri classı hem tüzelin hem de gerçek müşterininreferansını tutabiliyor.
            Musteri musteri4 = new TuzelMusteri();

            MusteriMenager musteriMenager = new MusteriMenager();
            musteriMenager.Ekle(musteri1);
            musteriMenager.Ekle(musteri2);


        }
    }
}
