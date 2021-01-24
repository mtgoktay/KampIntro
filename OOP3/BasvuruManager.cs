using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {                                                  // ILoggerService loggerService
            //Başvuranların bilgilerini değerlendirme

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();   ===>>>>Bütün başvuranlar konut kredisi üzerinden hesaplanır. Yanlıştır.
            krediManager.Hesapla();
            //loggerService.Log();            //Method İnjection
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnbilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }

    }
}
