using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Mehmet";
            //musteri1.Adi = "Göktay";
            //musteri1.Id = 1;
            //musteri1.TcNo = "2222222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";   // Bu alan benimle alakalı değildir Hatalı kullanım. Ben kişiyim :,
                   // Bu tarz kullanımlarda veri ler karmaşa olur. Tüzel ve Kişisel verilerde.

         // Gerçek Müşteri ve Tüzel 2 Müşterim var. Bunlar sırf birbirine benziyor diye birbirlerinin yerlerine ASLA!!! kullanımazlar.SirketAdi gibi
            //Burada SOLID tekniğini kullanırız = Yazılım Geliştirme prensiblerinden "L" harfi bize bunu söyler. 

            //Mehmet GÖKTAY
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mehmet";
            musteri1.Soyadi = "Göktay";
            musteri1.TcNo = "12345678910";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.VergiNo = "123456890";
            musteri2.SirketAdi = "kodlama.io";

            Musteri musteri3 = new GercekMusteri(); //Müşteri class ı hem "Tüzel" hem de "gerçek" müşterinin referans numarasını tutuyor.
            Musteri musteri4 = new TuzelMusteri();      //Opp2 nin amacı://Base sınıf varsa, o base sınıf referans tutucudur.(İnheritance ların adresi)

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);



        }
    }
}
