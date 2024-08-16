using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOP3
{
    internal class DatabaseLoggerService : ILoggerService   // interface içinde sadece imza metodları olabilir içi dolu olamaz
    {
        public void Log()
        {
            Console.WriteLine("veri tabanına loglandı");
        }
    }

}
