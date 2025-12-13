using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasim21nesne2ornek
{
    internal class elektronikcihaz
    {
        public string marka;
        public int seriNo;

        public elektronikcihaz()
        {
            Console.WriteLine("Elektronik cihaz sınıfının yapıcı metodu çalıştı.");
        }
        public void cihazbilgisiGoster()
        {
            Console.WriteLine("{0} marka , {1} seriNo bilgisine sahip bir cihazdır.", marka, seriNo);
        }
    }
}
