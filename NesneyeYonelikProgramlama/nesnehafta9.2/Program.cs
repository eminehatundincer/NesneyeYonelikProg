using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasım21nesne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            otomobil ot = new otomobil();
            ot.marka = "Ford";
            ot.renk = "Beyaz";
            ot.calistir();
            ot.tekerlekSayisi = 4;
            Console.WriteLine("Tekerlek Sayisi = {0}" , ot.tekerlekSayisi);
           
        }
    }
}
