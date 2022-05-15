using System;
using System.Collections.Generic;
using System.Text;

namespace GenerericsIntro
{
    class MyList<T>
    {
        T[] items;
        //ctor tab tab diyince bu oluştu. aşağıda oluşana constructor deniyor.Program.cs de class ı yenilediğimizde aşağısı çalışıyor.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // items ın referansını tutuyor.Çünkü new yazunca yeni referans numarsı alıyor ve önceki tuttuklarımız gidiyor.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)

            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }

        public int Length 
        { 
            get { return items.Length;}
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
