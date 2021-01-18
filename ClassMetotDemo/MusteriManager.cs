using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void AddList()
        {
            Console.WriteLine(" Kaç kullanıcı eklemek istiyorsunuz");
            string kullaniciSayisi = Console.ReadLine();
            string[] musteriler = new string[100];
              
            for (int i = 0; i < int.Parse(kullaniciSayisi); i=i+2)
            {
                int j;
                j = i;
                //j = j+2;
                Musteri musteri1 = new Musteri();
                Console.WriteLine(" Adını giriniz");
                musteri1.Ad = Console.ReadLine();
                Console.WriteLine("Soyadınızı giriniz");
                musteri1.Soyad = Console.ReadLine();
                musteri1.Id = j;
                Console.WriteLine("Tebrikler" + " " + musteri1.Ad  + " " + musteri1.Soyad + " " + musteri1.Id + " " + "numaralı yeni kullanıcı eklendi");
                //string[] musteriler = new string[100]; 
                musteriler[i] = musteri1.Ad;
                musteriler[j+1] = musteri1.Soyad;
                Console.WriteLine("--------------------------------------------");
                    
            }
            int y = 0;
            int z = 0;
            for (int x = 0; x < int.Parse(kullaniciSayisi); x++)
            {
                y = y + 1;
                Console.WriteLine(y + " .ci müşteri" + " " +musteriler[z]);
                z = z + 2;
            }

        }



        public void Delete()
        {
            Musteri musteri1 = new Musteri();
            Console.WriteLine("Müsteri numaranızı giriniz");
            musteri1.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( musteri1.Id + " "+ " numaralı hesabınız silindi");
        }

        
        

    }
}
