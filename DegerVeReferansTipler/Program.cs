using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //cw yaz 2 kz tab ile hızlı oluşturabilirsin.(Console.WriteLine ı)
            

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ? 30    

            int[] sayilar1 = new int[] { 10, 20, 30 };   //int sayilar1 Stack de oluşur. --//New ile bellekten bir adres numarası oluştur.(Heap te)
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;   //Sayılar1 in referans numarası = Sayılar2 in referans numarası oluyor
            sayilar2[0] = 999;
            //sayilar1[] ? 999
        }
    }              //****Sayısal veri tipleri(İnt,Bool,Float,Double vb..) = +Değer tip,  **** String, Array, Class, İnterface = +Referans Tip
                   // * Bellekte Steak ve Heap alanı vardır. +Değer Tip = *Steak, +Referans Tip = *Heap alanında saklanır.
}
