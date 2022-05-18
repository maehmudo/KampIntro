using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mahmut";
            musteri1.Soyadi = "ALP";
            musteri1.TcNo = "1231414141";

            //Taban ŞİRKETİ
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "ALP Taban";
            musteri2.VergiNo = "432432535235";

            //Sol tarafa tuzel veya gercek yazmadan da gerçek ve tuzeli aynı musteri ile tutabiliyoruz inheritance sayesinde
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CostumerManager musteriManager = new CostumerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);



            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Mahmut";
            //musteri1.Soyadi = "Alp";
            //musteri1.Id = 1;
            //musteri1.TcNo = "222222222";
            //musteri1.MudteriNo = "12345";
            //musteri1.SirketAdi = "?";

            //Gerçek Müşteri - Tüzel Müşteri farklı şeylerdir bunun iiçin yukarsı hatalı kod yazımıdır
            //SOLİD
        }
    }
}
