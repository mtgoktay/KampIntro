using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";         // Statik programlamaya örnektir.

            //Array - Dizi, Yukarıdaki gibi tek tek değişkenlerde tutmak yerine dizileri kullanırız. Birden fazla değer tutmak için
            // dizilerde çoğul isimler kullanırız.(İçerisinde birde fazla değer tuttuğu için)
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs",
                "Java", "Python"};         // Dinamik programlamaya örnektir.


            for (int i = 0; i < kurslar.Length; i++) // i sayaçtır, i++ = Birer artır(i=i+2 ile 2 şer de artırabiliriz yada i+=2 ile yapabiliriz.)
            {                                        //Length dizideki uzunluğu verir. Yukarıdaki dizi de 4 tür.
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar) // Dizi temelli yapıları tek tek dönmeye yarar(Dizi elemanlarını).(foreach dizilere uygulanır.)
            {                                                       // kurs = Alias ' tır, takma isim
                Console.WriteLine(kurs);                            // Foreach dizileri kolay dolaşmak için kullanırız.(Alias ile çok kolay)
            }                                                          // başlangıç bitiş ve artış ile uğraşmıyoruz.

            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
