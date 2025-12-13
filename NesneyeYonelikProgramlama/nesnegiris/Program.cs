using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesnegiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1(); // class1 adında class oluşturuyoruz 
            o.yazdir();
            o.ogrenciAd = "emine";
            Console.WriteLine(o.ogrenciAd);
           
        }
    }
}
