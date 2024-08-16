using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //classlar özellik(property) ve operasyon tutar
    //özellik tuttuğumuz yerde operasyon tutmuyoruz
    //operasyon tuttuğumuz yerde özellik tutmuyoruz

    // *** Eğer ki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsan yada  o nesneye ait değilmiş gibi duruyorsa SOYUTLAMA HATASI yapmış olabilirsin
    internal class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }


    }
}
