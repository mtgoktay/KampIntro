using System;

namespace Odevler
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();   //Urun tipinde "urun1" Class ını tanımladık. 
            urun1.PcMarka = "Asus";    //Prop-Parametreleri girdik.
            urun1.Ozellik = "i7, 8GB, 256SSD";
            urun1.Fiyat = 6500;

            Urun urun2 = new Urun();   
            urun2.PcMarka = "Dell";    
            urun2.Ozellik = "i5, 4GB, 128SSD";
            urun2.Fiyat = 4500;

            Urun[] urunler = new Urun[] {urun1, urun2}; //Urun tipinde "urunler" diye dizi tanımladık.

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Pc Markası :" + urun.PcMarka);
                Console.WriteLine("Pc Özellikleri:" + urun.Ozellik);
                Console.WriteLine("Pc Fiyat :" + urun.Fiyat);
            }


           
        }
    }
}
