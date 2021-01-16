using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar      //Metotlar, Bizim için tekrar tekrar kullanılabilirliği sağlayan kod yapılardır. Biz ortak kullanacağımız kodları
                            // Class ların içerisine yazarız
{
    class SepetManager                //Bir class ın isminde sonunda Manager, Service, date access, controller gibi ifadeler var ise
                                       // bunlar bir operasyon tutuyor demektir. 
    {
        public void Ekle(Urun urun)    //Metot-ekledik-python da def ile yaptık. *naming convention: yazım kuralı-isimlendirme                                  
        {                               // () var ise metot çalışıyordur demektir.
            Console.WriteLine("Tebrikler. Sepete eklendi :" + urun.Adi); 
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi :" + urunAdi);

        }
    
    }

}
