using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args) 
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; // 2-Mobilya ya karşılık gelir.
            product1.ProductName = "Masa "; //101 // ***Bu veriler kullanıcının girdiği veriler.
            product1.UnitPrace = 500;
            product1.UnitsInStock = 3;
                                       // Class a yukarıdan farklı veri girişi örneği.
            Product product2 = new Product { Id =2, CategoryId =5, UnitsInStock = 5, ProductName ="Kalem", UnitPrace =35};

          //PascalCase     //camelCase
            ProductManager productManager = new ProductManager(); //**Class ın örneği kullanmak için, Heap te oluşması için "new" leriz.Referans almak için
            // Steak te oluşur.             // Heap te oluşur.
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);   // Product Name = ""Kamera"" oldu; Referans Tiplerde, adress değeri gider //Yukarıdaki 101 gibi 
                                                       //  product.ProductName = "Kamera"; ile değeri değişir.
            //int sayi = 100;

            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi);             // 100, Değer tiplerde atamalar tamamen değeri üzerinden olur ve bağlantı kopar.*****



        }
    }
}
