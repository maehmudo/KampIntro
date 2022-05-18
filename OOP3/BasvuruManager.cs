
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            //Basvuran bilgilerini degerlendirme 
            //Bütün kredleri bu class ta hesaplayabilirim.
            
            krediManager.Hesapla();
            
        }   

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {

        }


    }
}
