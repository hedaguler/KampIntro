using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // değişkenleri bu şekil tek tek tanımlamak amele mantığı 
            //bunu yerine aşağıdaki gibi kurslar dizisinin içinde tanımlamalıyız
            string kurs1 = "yazılım geliştirici kursu";
            string kurs2 = "programlamaya giriş";
            string kurs3 = "java";

            // array
            string[] kurslar = new string[] { "yazılım geliştirici kursu", "programlamaya giriş","java" };
            //ilerde bunları yukardaki gibi kod içinde tanımlamayacağız  veri setimdem çekip kullanacağız.

            for (int i =0 ; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            // foreach dizilere uygulanır
            // kurs alias olarak kullanılmış burada kurs dışında herhangi bir takma ad da olur 
            // diziyi genelde foreachle dolaşırız forla da dolaşabiliriz ama
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {Console.WriteLine(kurs);
            }


            Console.WriteLine("SAYFA SONU");

        }
    }
}
