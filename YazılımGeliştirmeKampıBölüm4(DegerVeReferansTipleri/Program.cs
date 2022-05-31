using System;

namespace YazılımGeliştirmeKampıBölüm4_DegerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = 30 değer tip oldugu için stackda işlem gerçekleşiyor.


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 999 referans tipi oldugu için heap içinde işlem gerçekleşiyor.
        }
    }
}
