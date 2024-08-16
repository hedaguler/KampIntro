using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //interfaceleri birbirinin alternatifi olan ama kod içeriği farklı olan durumlar için kullanıırız
    // IKrediManager interfaceini kullanılacaksa, public void Hesapla(); metoduNnu ve bu interface içinde bulunan diğer metodları  içermek zorundadır
    interface IKrediManager
    {
        public void Hesapla();
        void BiseyYap();
        
    }
}

