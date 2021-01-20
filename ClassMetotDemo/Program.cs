using System;
//https://github.com/msarigul20/BootCampCodes/tree/master/3DayHomework3-ClassMetotDemo
//https://github.com/Emrecakir9535/Ders3Odev3/tree/master/Ders3Odev3
namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Banka Uygulamasına Hoşgeldiniz---");


            Musteri musteri1 = new Musteri();
            musteri1.MusteriID = 1;
            musteri1.MusteriTcNo = "12345678910";
            musteri1.MusteriAdi = "Ali";
            musteri1.MusteriSoyadi = "Kaya";
            musteri1.MusteriYas = 24;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriID = 2;
            musteri2.MusteriTcNo = "01987654321";
            musteri2.MusteriAdi = "Ayşe";
            musteri2.MusteriSoyadi = "Bulut";
            musteri2.MusteriYas = 40;

            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            musteriManager.AddMusteri(musteri1);
            musteriManager.AddMusteri(musteri2);
            musteriManager.PrintMusteri(musteri1);
            musteriManager.PrintMusteri(musteriler);
            musteriManager.DeleteMusteri(musteri2);


        }
    }
}