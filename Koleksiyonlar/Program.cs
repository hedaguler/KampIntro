// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

//string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);
//Console.WriteLine(isimler[3]);
//isimler = new string[5]; // diziye ilkeri ekleyebilmek için yeniden boyutlandırmamız gerekti(5 elemanlı yaptık) 
//isimler[4] = "ilker"; //
//Console.WriteLine(isimler[0]);//sıfırıncı elemanı getirmeyecek because arrayin adresi değişti 5 elemanlı yaparken aslında getiridi sıfırıncı elemanı ama boş geldi bcs adresi değişmişti

//Console.WriteLine(isimler[4]);


List<string> isimler2 = new List<string> { "Engin", "Murat","Kerem","Halil"};
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("İlker");  //koleksiyonlardan Add i çağırdık
Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);

