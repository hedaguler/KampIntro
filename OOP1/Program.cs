// See https://aka.ms/new-console-template for more information

//CLASSLAR 2 YE AYRILIR ->içinde özellik barındıran , operasyon(method) barındıran

using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitInStock = 3;

Product product2= new Product {Id = 2 , CategoryId =5, UnitInStock=5 ,ProductName="Kalem" ,UnitPrice=35};

ProductManager productManager =new ProductManager () ;
productManager.Add(product1);
Console.WriteLine (product1.ProductName);
// product1.ProductName = "Masa";   BAŞTA MASA ATAMIŞTIK
//AMA SONRA ProductManager ICINDE kamera ATADIK outputumuz kamera oldu










//ProductManager productmanager ;
//String         isim ;
// PascalCase    camelCase
//Class          değişkenAdı
//Classların adları Pascal Case ile yazılır.


// referans tiplerinin heapte oluşabilmesi için NEW lenmesi gerekir.


// Stack de oluşturulan kısım = new heapte oluşturulan kısım;