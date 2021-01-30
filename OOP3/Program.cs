using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //interface(IKrediManager) onu implamente eden class(IhtiyacKrediManager)ın referansını tutabilir.
            //Çok önemli bir bilgidir.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafkrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();//BasvuruYap'ı böyle de yazabilirsin.
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(/*new EsnafKrediManager(), new SmsLoggerService()*/ esnafkrediManager, smsLoggerService/*,new DatabaseLoggerService()*/);
            //Burada databaseLoggferService olduğu için veri tabanına loglandı yazacak.
            //Bu bilgi çok önemli.

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
