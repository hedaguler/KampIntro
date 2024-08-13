using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    //Geneeric classta <tip> belirtmek zorunlu
    internal class MyList<T>
    {
        T[] items;

        //ctor yaz tab tab constructor oluşturdun
        //constructorla classın ismi aynıdır(MyList)
        //classı newlediğinde constructorı otomatik çalışır
        public MyList() 
        {
                items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];   //dizinin eleman saysını 1 arttırdık. dizinin eleman sayısında işlem yapabilmek için newlemek gerekiyor.
            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i];    
            }

            items[items.Length - 1]=item;   //arrayin son elemanı Length-1 demektir.
        }

    }
}
