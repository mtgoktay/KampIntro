using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro    //Generics Class demek, çalışacağımız özel bir tip var demektir. -Vereceğimizi tipe göre çalışır.
{
    class MyList<T>//T=tip(type) tipinde Class, çalışacağımız özel bir tip olacağı için bu şekilde tanımladık. (Bana bir tip ver demek, int, string vb...)
    {
        T[] items; // Methodun dışında, direkt Class ın içerisinde dizi tanımladığımız için(en üstte) *bu sayfadaki(class ta) diğer tüm  fonk-metot* ve 
                        //erişebiliriz.!!!!!! -*******Dizi tanımladık.

        public MyList() //Bu bloğa constructor(Aslında Metottur) denir = ctor 2 kere tab==>> Class ı new lersek otomatik olarak başlangıçta çalışır.        {               // MyList Class ile aynı isimdedir, void yoktur.(**Constructor olduğunu bu şekilde anlarız.)-******Diziyi new lemek zorundayız.
        {                        //new lemek = Bellekte Referans değer al, örnek oluştur. New lemez isek referans hatası alırız!!!!
            items = new T[0];     //Yukarıdaki diziyi kullanabilmek için bu bloğu yazdık. Diziyi kullanabilmek için new ledik.
        }
        public void Add(T item)      //item = Eleman, T= Program.cs de T ye hangi tip veririsek olacaktır.
        {
            T[] tempArray = items;               // tempArray = Geçici Dizi
            items = new T[items.Length+1];     //  Bir üst satırda buradaki dizinin referansını tutturuyoruz. Yoksa değerler gider(101-102 örn. gibi) 
            // Eleman sayısını +1 artırdık.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];       // Burada tempArray deki eski değerleri, items a aktardık.(Yoksa kaybolurdu-101-102 gibi)

            }

            items[items.Length - 1] = item;    //İnterface ve Abstrack sınıfları ==>> gerçek hayat uygulamalarını daha iyi anlamak için 
                                               // bu yapıları işliyoruz.
        }

    }
}
