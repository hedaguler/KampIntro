using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {

        // --- METHOD INJECTION ---   
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //başvuran bilgilerini değerlendirme
          krediManager.Hesapla();
            loggerService.Log(); //hangi loglayıcı service gönderilmişse onu logla
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)  //<veri türü> ,  eleman ksııtlaması yok birden fazla kredinin hesaplamasını yapabiliriz
                                                                             
        {
             foreach(var kredi in krediler)
            {
                kredi.Hesapla();    
            }
        }
    }
}
