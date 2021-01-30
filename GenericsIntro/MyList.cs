using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor = bir class new'lendiğinde çalıştığı blok
        //array new'lenmek zorunda
        public MyList()
        {
            items = new T[0];
         }
        public void Add(T item)
        {
            T[] tempArray = items;  // geçici dizinin referansı, items'ın referansı
            items = new T[items.Length + 1];  //eleman sayısı 1 arttırılır 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }
}
