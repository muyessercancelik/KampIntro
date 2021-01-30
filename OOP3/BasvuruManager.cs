using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection - Bu metodun hangi kredi türü olacağını enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran Bilgilerini değerlendirme.
            //bir sürü kod çalıştırırız.
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //Bu şekilde yaparsak çalışır ancak tüm başvurular Konut kredisi üzerinden çalışır.
            //Ancak BasvuruYap kısmına (IKrediManager krediManager) olarak güncellersek
            // ve hesaplamayı şu şekilde çağırırsak;
            //Hem veri tabanına loglayalım hem müşteriye sms atalım denebilir.O zaman ILoggerService i List<> olarak yazmalısın. Bir tane değil çok yollamak istediğin için.
            //public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
            //foreach (var loggerService in loggerServices)
            //{
            //         loggerService.Log(); Artık tek değil çoklu loggerla çalışıyoruz.Program.csde de ona göre düzenleme yaparsın.
            //}


            krediManager.Hesapla();
            loggerService.Log();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)//Birden fazla kredinin hesabını yapmak için.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
