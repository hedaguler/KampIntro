using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Heda";
            int yas = 23;

            //CLASS DEĞİŞKENİNİ(kurs1) OLUŞTURMAK VE DEĞERLERİNİ ATAMAK;
            Kurs kurs1 = new Kurs() ; // kurs1 değikeninin tipi Kurs   
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs(); // kurs1 in tipi Kurs   
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "kerem";
            kurs2.IzlenmeOranı = 64;
            
            Kurs kurs3 = new Kurs(); // kurs1 in tipi Kurs   
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "Berkay";
            kurs3.IzlenmeOranı = 88;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 , kurs3 };
            // Kurs[] dizisini oluşturduk
            //içine kurs1, kurs2 , kurs3 değişkenlerini tanımladık
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);

            }

           // Console.WriteLine("Hello World");

        }
    }
    //Kurs içinde birden fazla tipte eleman içeriyor int gibi string gibi

    //CLASS TANIMLAMA;
    class Kurs
    { //prop yaz tab tab yap property=özellik
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }


    }
}
