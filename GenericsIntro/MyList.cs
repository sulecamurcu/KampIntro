using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
       T[] items; //metodun dışında yazdık..classın bütün elemanlarına ulaşılabilecek bir dizi tanımladık.T items  arrayini classı newlediğimde oluşturmam gerekiyor.
        //constructor
        public MyList()
        {
            items = new T[0]; // 0 elemanlı bir dizim var artık diiziye eleman ekleyebilirim.
;       }
        
        public void Add(T item)//arka planda bu string oluyor.program.cs de string yazdğımız için.

        {
            T[] tempArray = items;//Geçici dizinin referansı, items'in referansı
            items = new T[items.Length+1];//Dizinin eleman sayısını 1 arttırıyorum.
            for (int i  = 0; i  < tempArray.Length; i ++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;//aslında eklenmek istenilen elemanı şu an ekleyebildim.
        }

        public int Length 
        {
            get { return items.Length; }
        }
    }
}
