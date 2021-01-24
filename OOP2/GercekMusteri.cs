using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2                     // Class larda ya özellik olacak yada operasyon. Aynı anda 2 si birden olmaz.İmplementasyon=Uygulama demektir.
{   //Individual=Bireysel           // Özellik Class ıdır, burası. Musteri, Customer, Employee, Person gibi bir şey varsa bu "varlıktır".(Entities)
                                    // Varlıkların içerisinde ""operasyonlar"" olmaz.                                   
    class GercekMusteri: Musteri     // Tüzel ve Gerçek müşteriyi buraya göndermek istiyoruz.Bunun için "inheritance" yaparız.
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
