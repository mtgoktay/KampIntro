using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla(); aşağıdaki ile de aynı sonuç olur.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); // ***İnterface lerde, o interface i implemente eden classın 
            //ihtiyacKrediManager.Hesapla();                                //    referans numarasını tutabiliyormuş.

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();

            

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            // basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);
            //                        konutKrediManager, new DatabaseLoggerService() böyle de yollanabilirdi.

            // basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());
            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService()};

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnbilgilendirmesiYap(krediler);

        }
    }
}
