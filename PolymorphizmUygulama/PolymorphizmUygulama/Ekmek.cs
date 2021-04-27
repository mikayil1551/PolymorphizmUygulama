using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmUygulama
{
    class Ekmek:Urun
    {
        public string EkmekTipi { get; set; }
        public double Gramaj { get; set; }
        public override decimal KdvliFiyatHesapla()
        {
            return Fiyat+(Fiyat*0.01m);
        }

    }
}
