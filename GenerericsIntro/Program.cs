using System;

namespace GenerericsIntro
{
    class Program
    {
        static void Main(string[] args)
        { 
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Mahmut");

            Console.WriteLine("Hello World!");
        }
    }
}
