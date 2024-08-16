using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  ---  LOGLAMA (LOGGER SERVİCE)  ---
//logları bir dosyada, database de tutabiliriz.
//logları sms oalrak da atabiliriz.Misal kredi başvurusunda onay/ red mesajı atılması 

namespace OOP3
{
    internal interface ILoggerService
    {
        void Log();

    }
}
