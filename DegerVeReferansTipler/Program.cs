// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//DEĞER TİPLİ
int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
Console.WriteLine(sayi1);
// sayi1 in değeri ne olur ?? cevap 30 olur BCS int,decimal,double,bool değer tipli değişkenlerdir değer tutar
//değer tipli değişkenler stackde tutulur


//REFERANS TİPLİ
int[] sayilar3=new int[] {10,20,30};
int[] sayilar4 = new int[] { 100, 200, 300};
sayilar3 = sayilar4;
sayilar4[0] = 999;
Console.WriteLine(sayilar3[0]);
//sayilar 3 ün sıfırıncı elemanı ne olur?? cevap 999 because Array,Class,Interface REFERANS türündedir adres tutar
// new heap de yer tutar



