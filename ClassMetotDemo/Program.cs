using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Yapmak istediğiniz işlem Kullanıcı Ekle-Listele:1, Kullanıcı Sil:2");
            string islem = Console.ReadLine();
            MusteriManager musteriManager = new MusteriManager();
           
            if (islem == "1")
                musteriManager.AddList();

            else if (islem == "2")
                musteriManager.Delete();

            else
                Console.WriteLine("Herhangi bir seçim yapmadınız");
                 
           


        }
    }
}
