using System;

namespace Metotlar
{                       //C#, java gibi programlama dillerinde her şey Class lardan oluşur.
    class Program      //Temel yapıların çoğu classların içerisinde olur. (O nesneyi(bir ürünü) tanımlayan birden fazla özellik barındıran yapıdır.
                            //Class larda pascal case uygulanır. İlk harf büyük :). Class lar bir veri tipidir aslında(int, string vb. gibi)
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };   //Meyveler Dizisi tanımladık, Arrays. Diziler çoğul isimlendirilir.

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler) //Urun=veri tip, urun=      urunler=dizi
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("-----------------------------Metotlar---------------------------");
            //instance - örneği // o class ı kullanmak için örneğini oluşturduk.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); //Metot-Fonksiyon çağırma
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyar Karpuz", 12, 15);

        }
    }
}

        // Metotlar, Bizim için tekrar tekrar kullanılabilirliği sağlayan kod yapılardır.
        //Dont repeat yourself DRY - Kendini tekrar etmeye denir. Clean Code: Temiz kod yazmaya denir.
        // Best Practice : Doğru uygulama teknikleri.-En iyi uygulama teknikleri