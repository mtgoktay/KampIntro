using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs(); // Class tanımlama, kullanımı         kurs1 değişkenim var ve birden fazla eleman içerir. int string vb.. gibi 
            kurs1.KursAdi = "c#";                                       // kurs1 i Kurs class türünde tanımladık.
            kurs1.Egitmen = "Engin Demiroğ";   //Tanımladığımız class lara değer atıyoruz. (Bir sürü değeri var, biz 3 tane özellik tanımladık.)
            kurs1.İzlenmeOrani = 68;
            
            Kurs kurs2 = new Kurs();                    //2.ci değişken
            kurs2.KursAdi = "Java";    
            kurs2.Egitmen = "Kerem Varış";
            kurs2.İzlenmeOrani = 64;
            

            Kurs kurs3 = new Kurs();                    //3.cü değişken
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.İzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};   // Dizi tanımladık. String yerine "Kurs" class ımızdaki diziyi tanımladık. 
                                      //içerisinde önceden string tutardık şimdi kurs tutuyoruz. 
            foreach (var kurs in kurslar)   //kurs alias takma ad
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

            Console.WriteLine("Hello World!");
        }
    }

    class Kurs        // Class lar birden fazla veri tuttuğumuz yapılardır.(Kurs diye bir değişken tanımladık bir nevi.=Veri Tipi))
    {
        public string KursAdi { get; set; } //prop yaz 2 tane Tab a bas. Prop=Property den gelir.
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; } // Kursta(değişkende) 3 tane özellik tanımladık.
    }
}
