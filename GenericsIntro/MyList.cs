using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //T ile programcı hangi tip verirse onu kullanır.
    class MyList<T>
    {
        //Add fonksiyonu yazmadan önce array oluşturulur.
        T[] items;

        //Constructer : new dediğin anda çalışan class.
        public MyList()
        {
            //Array oluşturulduğunda ona ekleme yapabilmek için önce newlenmesi lazım.
            //burda new ile oluşturuluyor. MyList new dediğinde ilk önce burası çalışıyor ve yeni oluşturulmuş oluyor.
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //geçici dizinin referansı = itemsin referansı
            //aşağıda new dediğin zaman daha önce eklenmiş olan item varsa gider.o yuzden tempArray oluşturuldu.
            items = new T[items.Length+1]; //dizinin eleman sayısını bir atırdı.
            //tempArray elemanları tekrar items a göndermek için for döngüsü
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //items.Length-1: items son elemanı
            items[items.Length - 1] = item;
        }
        public int Length
        {
            get
            {
                return items.Length;
            }
        }

        public T[] Items
        {
            get
            {
                return items;
            }
        }
    }
}
