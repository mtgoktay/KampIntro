using System;
using System.Collections.Generic; //using System.Collections.Generic **Ben içerisindeki sınıfları kullanmak için ekledik.

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" }; //101
            //  Console.WriteLine(isimler[0]);
            //  Console.WriteLine(isimler[1]);
            //  Console.WriteLine(isimler[2]);
            //  Console.WriteLine(isimler[3]);
            // Aşağıda İsimler adresi ile yeni bir adres oluşturmuş oluruz, 5 elemanlı.Yukarıdaki adresteki bilgiler kaybolur.
            //  isimler = new string[5]; // 102 //**yeni bir dizi tanımlanmış olduk, yukarıdaki dizideki değerler gider. (Referans Adresi değiştiği için)
            //  isimler[4] = "ilker";     //Yukarıdaki dizide 4 elmanlı bir arry tanımladığımızda, onu artık 5 elamanlı yapamıyoruz. Yapsak bile eski
            //                             // değerleri kaybolur. Sebebi 101-102 referans tip adres değeri mantığı. 
            //  Console.WriteLine(isimler[4]);
            //  Console.WriteLine(isimler[0]);
            //**Genellikle "Array" yerine "Koleksiyon" kullanırız.Yukarıdaki problemden dolayı.(Dizileri genişletemiyoruz, genişletsek değerler kayboluyor.)
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" }; // isimler2 isminde Koleksiyon tanımladık.
            //isimler2.Add("Engin"), Bu işlem ile "isimler 2" ye Add fonksiyonu ile Engin ekler.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");              // List i kullanmak için "using System.Collections.Generic; " ekledik!!!!!!!!!!!!!!!
            Console.WriteLine(isimler2[4]); //İlker  Sonuç: //Koleksiyonlarda array ler gibi değerleri kaybetmemizi engelleyecek *alt yapı var*.
            Console.WriteLine(isimler2[0]); // Engin  // Koleksiyondaki <> yapısına Generic yapı denir.

            //Koleksiyonların, List lerin bir sürü fonksiyonları var.
            // isimler2.AddRange; isimler2.Count, isimler2.Clear
        }
    }
}
