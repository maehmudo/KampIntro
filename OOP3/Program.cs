using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Burda interface'lari test etmiş olduk
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            
            IKrediManager tasitKrediManager = new TasitKrediManager();
            
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager);

            

        }
    }
}
