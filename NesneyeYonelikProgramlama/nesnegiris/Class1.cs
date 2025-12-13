using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesnegiris
{
    internal class Class1
    {
        public string ogrenciAd;
        private string PersonalAd;
        //private erişimi kısıtlıyor main de göremiyorsun 
        public void yazdir()
        {
            Console.WriteLine("İlk NYP kodu"  + ogrenciAd);

        }
        }
    }

