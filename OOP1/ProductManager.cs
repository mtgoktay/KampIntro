using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //Ürünle ilgili operastonlar var demektir. ***CRUD gibi ==>> **Create, Read, Update, Delete**
    {                   //encapsulation
        public void Add(Product product) // Bana bir tane product ver.
        {
            //product.ProductName = "Kamera";      //product.ProductName = "Kamera"; //101 numaralı adres gibi
            Console.WriteLine(product.ProductName + " ekledi");  

        }
        //public void BiseyYap(int sayi)
        //{
        //    sayi = 90;
        //}
        public void Update(Product product) // void anahtar kelimesi-metotLARI = emir kipi ile git sil ,ekle, güncelle gibi işlemlerini yapar. 
        {                                              
            Console.WriteLine(product.ProductName + " güncellendi.");        

        }

        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;           //Program akışında  dönüşte kullanabiliriz(return değeri verir), Program.cs de.
        //}                                    //Program.cs de,    int toplamaSonucu = productManager.Topla(3,6); 
                                               //                  Consol.WriteLine(toplamasonucu * 2); örneği gibi

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1+sayi2);  // git yap bitir bağlantı koptu. dönüşte kullanamayız!!!!!!, Program.cs de.
        //                                     //        Program.cs de productManager.Topla2(3,6); örneği gibi
        //}



    }
}
