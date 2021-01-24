using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri                   // Class larda ya özellik olacak yada operasyon. Aynı anda 2 si birden aynı sayfada olmaz. 
    {                               // İmplementasyon=Uygulama demektir.
        public int Id { get; set; }      //Müşteri de olanlar Gerçektede Tüzel de de vardır deriz. Ortakları buraya atarız.
        public string MusteriNo { get; set; }   //Herhangi bir matematiksel bir işlem uygulamayacağımız için "string" olarak tanımladık.
                                //***Eğer ki bir nesne de bir değeri kullanmak zorunda gibi görünmüyorsam, o nesneye ait değilmiş gibi duruyorsa o alanda
                                 // demek ki orada hata yapıyorsun, Soyutlama hatası yapıyorsun demektir.!!!!!!!
      
    }
}
