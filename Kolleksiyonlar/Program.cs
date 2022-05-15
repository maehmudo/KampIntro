using System;
using System.Collections.Generic;

namespace Kolleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi oluşturduk
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //Burda olan şey ilk başta oluşan dizi yazılıyor ekrana daha sonra new string dediğimiz5 elemanlı yeni bir dizi oluşuyor ve biz onun 4. elemanı olarak ilker koyuyoruz onu da ekrana yazıyor tekrar 0. elemanı yazdırmaya çalışıınca yazıyor ama boş yazıyor bir şey görmğyoruz biz.

            //LİSTELERE GEÇİŞ List yazıp soldan ampule tıklayıp using yazana basıyoruz listleri eklemek için

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            //Listeler değerleri kaybetmemizi engelleyen altyapılara sahiptir. 

        }
    }
}
