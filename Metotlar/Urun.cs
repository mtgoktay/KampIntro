using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun      // class larda bir ürünün bilgileri tutmaktı
    {
        public int Id { get; set; }           //Property- Ürünün özellikleri
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}
