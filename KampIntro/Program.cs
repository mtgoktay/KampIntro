using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //C# type safety - tip güvenlipi ön planda olan(daha katı) bir programlama dilidir.
            //Örn:Değişken tanımlarken önünne veri türünü yazman ve
            // sonuna ; koyman gerekiyor. 
            //Do not repeat yourself - Kendini tekrarlama 
            //(Sayfalardaki string ifadeler, değişken kullanmadan)
            
            string kategoriEtiketi = "Kategori";  //Metinsel
            int ogrenciSayisi = 32000;  //Tam sayı
            double faizOrani = 1.45;    //Ondalıklı
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            char giris = 'e';    // C#=>>>>>ta tek tırnak(') sadece tek karakter tutulabilir.
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu Göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu Göster");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu Göster");
            }




            if (sistemeGirisYapmisMi == true) // if ten sonra 2 tane tab a basınca otomatik bloğu açar.
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi); //Değer tutucu, Alias
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
