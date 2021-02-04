using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            ////stack            heap         değerleri alacak.
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil"};  //Eleman sayım 4
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Ilker";
            //Console.WriteLine(isimler[4]); //4.Elemana yer yok onu yazdıramayız.Arrayler biz onu oluşiturduğumuz zaman o sınırlarda takılır o sınırlardan çıkaramayız.
            //Console.WriteLine(isimler[0]);
            ////Şimdi arraylerdeki sabitlik var.Yani biz bir arrayı tanımlayınca 4 elemanlı ya 4 elemanlı bir array tanımladığınızda onu artık 5 elemanlı yapamıyoruz.Yaparız ama eski elemanları kaybederiz .Çünkü unutmayalım new demek yeni referans adresi demek.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            





        }
    }
}
