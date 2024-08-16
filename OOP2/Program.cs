// See https://aka.ms/new-console-template for more information
using OOP2; //our class name

Console.WriteLine("Hello, World!");

//engin demiroğ -  indivudual
GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id=1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "engin";
musteri1.Soyadi = "Demiroğ";
musteri1.TcNo = "12345678920";

//kodlama.io - tüzel
TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "54321";
musteri2.SirketAdi = "Kodlama.io";
musteri2.VergiNo = "1234567890";


//Musteri classı hem GercekMusteri nin hem de TuzelMusterinin referansını tutabiliyor
Musteri musteri3 = new GercekMusteri();
Musteri musteri4= new TuzelMusteri();




// Musteri musteri1 = new Musteri(); //classın instanceını oluşturduk.


//Gerçek Müşteri - Tüzel Müşteri 
// SOLİD in "L" si birbirine benziyo diye birbirinin yerine kullanma.. Gerçek Müşteri - Tüzel Müşteri  are not same thing
