using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager   //Base : Ebeveyn dir. // İmzanın aynı olduğu ama içerisinin farklı olduğu durumlarda base de 
    {                        // oluşturduğumuz class ı class olarak değil de, İnterface olarak oluştururuz. = Şablon(Arayüz) görevi görüyor.//
        void Hesapla();     // ****İnterface ler I harfi ile başlar.  Şu şablona uymak zorundasın demek, diğer krediler(Taşıt, konut, vb..)
        void BiseyYap();    //!!!!!!!!!İnterface leri birbirinin alternatifleri olan ama "kod içerikleri farklı" olan durumlar için kullanırız.

    }
        
           
        
        
    
}
