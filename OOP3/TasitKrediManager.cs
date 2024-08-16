using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{ //Interfacee gel ampulden implement interface de
    internal class TasitKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
