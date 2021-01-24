using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı.");   //Bunu kısayol ile ekledik. Move type to FileLoggerService.cs  ye tıkladık.
        }
    }


}
