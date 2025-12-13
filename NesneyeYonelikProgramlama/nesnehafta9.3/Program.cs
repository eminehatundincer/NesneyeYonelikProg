using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasim21nesneornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bolum bl = new bolum();
            bl.bolumadi= "Bilgisayar Muhendisligi";
            bl.bolumkurulusyili = 1992;
            bl.Fakulteadi = "Mühendislik Fak";
            bl.kampusadi= "Batı Kampusu";
            bl.bilgileriGoster();



        }
    }
}
