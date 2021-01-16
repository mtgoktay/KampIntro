using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun      // class larda bir ürünün bilgileri tutmaktı
    {
        public int Id { get; set; }           //Id bir data yı diğerlerinden ayırt etmek için kullandığımız eşsiz değeri anlatır.TC Kimlik Gibi
        public string Adi { get; set; }
        public double Fiyati { get; set; }    //Property- Ürünün özellikleri-Parametre (Class ların 1.kullanım şekli)-Ürünün detayları, açıklamaları
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}
