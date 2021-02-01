using System;

namespace DegerVeReferansTıpler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;//sayi1'in değeri=sayi2'nin değeri. sadece değeri aktarırsın ve sayı2 ile olan irtibartın orada kopar.yani 30u atadın. 
            sayi2 = 65;
            //sayi1 ??

            int[] sayilar1 = new int[] { 10, 20, 30, };// rferans değerler(heap içinde tutulur)
            int[] sayilar2 = new int[] { 100, 200, 300, };
            sayilar1 = sayilar2; //sayilar1'in referans numarası sayilar2'nin referns numarasına eşittir diye okumalıyız.
            sayilar2[0] = 999;
            //sayilar1[0]???


        }
    }
}
