using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasim21nesne2ornek
{
    internal class laptop:bilgisayar
    {
        public Boolean bluetooth;
        public int pilomru;

        public laptop()
        {
            Console.WriteLine("laptop sınıfının yapıcı metodu çalıştı.");
        }
        public void laptopBilgisi()
        {
            Console.WriteLine("{0} bluetooth, {1} pilomrune sahip bir laptoptur.", bluetooth, pilomru);
        }
    }
}
