using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kutu k = new kutu();
            k.Esya = 5;
            k.bilgi();
            k.Esya = -7;
            k.bilgi();
            Console.ReadLine();
        }
    }
}
