﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {   // İçinde ürün ile ilgili operasyonlar var
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
        
        //public int Topla(int sayi1,int sayi2)
        //{
        //    return sayi1 + sayi1;
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine( sayi1 + sayi2);
        //}

        // void kullandığımızda emir veriyoruz.Çıkan sonucu tekrar kullanamıyoruz.
        // int - return kullandığımızda returnden gelen sonucu tekrar tekrar kullanıyoruz

    }

}
