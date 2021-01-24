using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); //T=String class türünde gönderdik//****"Koleksiyonlar" arka planda bir "array" yönetir. 
            isimler.Add("Mehmet");                         //" <> " Class tanımı.    //Sınıflar yeşil renktedir.

        }
    }
}
