using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product   // Class lar 2 türlü kullanılır. 1-Özellik barındıran classlar 2-Operasyon fonksiyon(CRUD), Metot barındıran classlar
    {               // Prudoct = Ürün DEMEK
        public int Id { get; set; }   //CRUD operasyonları = ekleme-okuma-Güncelleme-Silme
        public int CategoryId { get; set; }
        public string ProductName { get; set; } //Ürün Adı
        public double UnitPrace { get; set; } //Fiyat
        public int UnitsInStock { get; set; } //Stok



    }
}
