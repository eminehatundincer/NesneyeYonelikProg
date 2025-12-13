using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomobil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //gaza basildi , lastik değişti ,ford, carraro

            Class1 o = new Class1(); //otomobil adında nesne oluşturuyoruz
            o.marka = "ford";
            o.model = "fiesta"; //set işlemi
            //o.gazaBas();
            o.yil = 1992;
            o.bilgiGoster();

            /*Class2 b = new Class2(); //bisiklet adında nesne oluşturuyoruz
            b.marka = "carraro;";
            b.degistir();

            Console.WriteLine(o.marka); //get işlemi
            Console.WriteLine(b.marka);
            o.yas = 15; //SET */



        }
    }
}
