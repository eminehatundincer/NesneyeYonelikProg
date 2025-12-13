using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasim21nesneornek3
{
    internal class bolum:fakulte
    {
        private string bolumadi;
        private int bolumkurulusyili;

        public string bolumadi //dışarıdan kullanımlar olacak
        {
            get { return bolumadi; }
            set { bolumadi = value; }
        }

        public int bolumkurulusyili //dışarıdan kullanımlar olacak
        {
            get { return bolumkurulusyili; }
            set { bolumkurulusyili = value; }
        }

        public bolum()  //kurucu metot çalıştırdığımızda üst sınıfı varsa ilk oranın kurucu metodu çalışır 
        {
            Console.WriteLine("Üniversite adı: " + universiteadi + "Şehir bilgisi" + sehiradi);
        }

        public void bilgileriGoster()
        {
            Console.WriteLine("{0}{1}\n{2}{3} ", bolumadi, bolumkurulusyili, Fakulteadi , kampusadi);  //fakulteadinda F büyük kurucu metottan alıyoruz
        }

    }
}
