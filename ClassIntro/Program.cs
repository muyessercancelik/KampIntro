using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Müyesser";
            int yas = 28;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Yazılım";
            kurs2.Egitmen = "Atınç Hoca";
            kurs2.IzlenmeOrani = 30;
        }
    }
}
