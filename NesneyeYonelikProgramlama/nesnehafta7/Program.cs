using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci o = new ogrenci();
            // ogrenci o = new ogrenci("Emine");
            Console.WriteLine("Ogrenci no:");
            o.OgrNo = Console.ReadLine();
            Console.WriteLine("Ogrenci ad:");
            o.OgrAd = Console.ReadLine();
            Console.WriteLine("Ogrenci soyad:");
            o.OgrSoyad = Console.ReadLine();
            Console.WriteLine("\n\n Ogrenci Bilgileri: \n\n");

            Console.WriteLine(o.OgrNo);
            Console.WriteLine(o.OgrAd);
            Console.WriteLine(o.OgrSoyad);
            Console.WriteLine(o.Sinif);
            Console.ReadKey();
        }
    }
}
