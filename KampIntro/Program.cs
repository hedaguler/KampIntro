/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            string kaetgori
        }
    }
}
*/


using System;

class Program
{
    public static void Main(string[] args)
    {

        // type safety
        string kategoriEtiketi = "Kategori";
        //Console.WriteLine (kategoriEtiketi);

        //değişken tanımlamaları ;
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        bool sistemeGirisYapmisMi = true;
        double dolarDun = 7.35;
        double dolarBugun = 7.45;

        // ------------

        if (dolarDun > dolarBugun)
        {
            Console.WriteLine("Azalış Butonu");
        }
        else if (dolarDun < dolarBugun)
        {
            Console.WriteLine("Artış Butonu");
        }
        else
        {
            Console.WriteLine("Değişmedi Butonu");
        }


        // --------------------------------
        if (sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Kullanıcı ayarları butonu");
        }
        else
        {
            Console.WriteLine("Giriş yap butonu");
        }


        Console.WriteLine(kategoriEtiketi);
    }

}