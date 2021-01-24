using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{      //Coorporate = Tüzel,   // Tüzel müşteri miras alır, =>>>>> Müşteriden
    class TuzelMusteri:Musteri //Ebeveyn i(Musteri)     // ===>>>>>>>   Bu olaya "Miras" yada "inheritance" diyoruz.
    {                                        // Tüzel ve Gerçek müşteriyi buraya göndermek istiyoruz.Bunun için "inheritance" yaparız.
        public string SirketAdi { get; set; }    // Tamamen kendine has özellikleri bıraktık.
        public string VergiNo { get; set; }
    }
}
