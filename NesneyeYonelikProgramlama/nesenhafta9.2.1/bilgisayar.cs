using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasim21nesne2ornek
{
    internal class bilgisayar:elektronikcihaz
    {
        public string islemciTipi;
        public int ram;
        public bilgisayar()
        {
            Console.WriteLine("Bilgisayar sınıfının yapıcı metodu çalıştı.");
        }
        public void bilgisayarbilgisiGoster() 
        {
            Console.WriteLine("{0} işlemci tipi, {1} ram bilgisine sahip bir bilgisayardır", islemciTipi, ram);
        }
    }
}
