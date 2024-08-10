// See https://aka.ms/new-console-template for more information


namespace Metotlar;

class Program
{
    static void Main(string[] args)
    {//aşağıdaki AÇIKLAMA gibi yazmaktansa ,daha alttakiler gibi classlar oluşturmak daha mantıklı classı çağırmak yeterli o ürünle ilgili özelliklere erişmek için
        /*  string urunAdi1 = "Elma";
       double fiyati1 = 15;
       string aciklama1 = "Amasya elması";

     string urunAdi2 = "Çilek";
       double fiyati2 = 10;
       string aciklama2 = "Beyşehir Çileği";  */

        string[] meyveler = new string[] { };


        Urun urun1 =new Urun();     //CLASSIN ÖRNEĞİ 
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya elması";

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 80;
        urun2.Aciklama = "Diyarbakır karpuzu";

        Urun urun3 = new Urun();
        urun3.Adi = "Nar";
        urun3.Fiyati = 70;
        urun3.Aciklama = "Antalya narı";




        Urun[] urunler = new Urun[] {urun1,urun2,urun3};


        foreach (Urun urun in urunler)    //TEK FOREACH İLE Urun CLASSINDAKİ TÜM ÜRNLERİN ÖZELİKLERİNİ EKRANA YAZDIRABİLDİK
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("--------------");
        }

        Console.WriteLine("--------------------METODLAR--------------");
        // metodlar  reusability (tekrar kullanılabilirlik) sağlar.

        //encapsulatıon

        SepetManager sepetManager = new SepetManager(); // class ı çağırmak için önce bir class örneği oluşturuyoruz(INSTANCE)
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);
        sepetManager.Ekle(urun3);

        sepetManager.Ekle2("Armut", "Yeşil armut", 12);
        sepetManager.Ekle2("elma", "Yeşil elma" , 12);
        sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu ", 12);



    }
}


 // Tekrar tekrar kullanılabilriliği sağlayan kod bloklarıdır.
 //DRY - Dont Repeat Yourself - Clean Code - Best Practice
