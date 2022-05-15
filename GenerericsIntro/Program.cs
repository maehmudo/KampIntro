using System;

namespace GenerericsIntro
{
    class Program
    {
        static void Main(string[] args)
        { 
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Mahmut");

            Console.WriteLine(isimler.Length);
            isimler.Add("Barış");

            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);

            }

        }

    }
}
