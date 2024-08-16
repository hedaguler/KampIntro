// See https://aka.ms/new-console-template for more information
using OOP3;
//interfacelri referans tutucu olarak kullanırız genelde
Console.WriteLine("Hello, World!");

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

IKrediManager tasitKrediManager = new TasitKrediManager();

IKrediManager konutKrediManager = new KonutKrediManager();

BasvuruManager basvuruManager = new BasvuruManager();


// 2 farklı loglama alternatifim var ; filelogger databaselogger

ILoggerService fileLoggerService = new FileLoggerService();   // file ı newledik sms ve databesi aşağıda 19. satırı kullanorken newleyip kullandım. kullanıcağım zaman nesnesini oluşturup kullandım yani

basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());  //burda da newleyebiliriz  yukardakiler gibi de newleyebiliriz





// IKrediManager bir veri tipidir
List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};


//basvuruManager.KrediOnBilgilendirmesiYap(krediler);










//yukardakiyle aynı şeyi yapar - İnterface onu implemente eden classın refrans numarasını tutabilir.
//IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
//ihtiyacKrediManager.Hesapla();

//TasitKrediManager tasitKrediManager = new TasitKrediManager();
//tasitKrediManager.Hesapla();

//KonutKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();




//SOLİD in O harfi Open close principal sisteme yeni bir özellik eklendiğinde mevcut kodlar bozulmaz



// aynı şeye birden fazla loglama yaptırabiliriz yani hem sms yollayıp hem database e loglayabiliriz
// 
// new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()};
//birden fazla olduğu için liste kullandık