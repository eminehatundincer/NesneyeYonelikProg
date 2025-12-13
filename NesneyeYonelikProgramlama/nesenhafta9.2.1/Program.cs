using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasim21nesne2ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            laptop cihaz = new laptop();
            cihaz.marka = "ASUS";
            cihaz.seriNo = 241560;
            cihaz.islemciTipi = "AMD";
            cihaz.ram = 16;
            cihaz.bluetooth = true;
            cihaz.pilomru = 95;

            //kurucu metotlar çalışırken laptop ->bilgisayar->elektrobik cihaz şeklinde ine ine ilk e.cihaz calısır sonra bilgisayar en son laptop calısır.

            cihaz.cihazbilgisiGoster();
            cihaz.bilgisayarbilgisiGoster();
            cihaz.laptopBilgisi();
        }
    }
}
