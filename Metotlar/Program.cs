using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); //class tanımladık
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};
            
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);

                Console.WriteLine(urun.Fiyati);

                Console.WriteLine(urun.Aciklama);

                Console.WriteLine("----------------");


            }

            Console.WriteLine("-------Metotlar--------");
            // instance = class örneği
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

        }
    }
}

// Metotlar, bizim için tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır. 
//'Dont repeat yourself.'
// DRY - Clean Code - Best Practice