using System;
using System.Collections.Generic;  //listi kullanmak için bu kütüphane eklenmeli
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace besaraliknesneyeyonelik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimListesi = new List<string>();
            isimListesi.Add("Arda");
            isimListesi.Add("Büşra");
            isimListesi.Add("Cem");
            isimListesi.Add("Ali");

            List<string> isimListesi2 = new List<string>() { "Emine", "Büşra", "Cem", "Ali" };


            for (int i = 0;i< isimListesi.Count; i++)
            {
                Console.WriteLine(isimListesi[i]);
            }

            foreach(var isim in isimListesi) //var değişkeni string tutuyor. var yerinde string var gibi düşün.
            {
                Console.WriteLine(isim);
            }

            foreach(var isim in isimListesi2) 
            {
                Console.WriteLine(isim);
            }
           */

            List<personel> PersonelListesi = new List<personel>();
            for (int i = 0; i <= 2; i++)
            { 
                /*PersonelListesi.Add(new personel());
                PersonelListesi[i].ad = "Emine";
                PersonelListesi[i].soyad = "Dinçer";
                PersonelListesi[i].maas = 1000;*/ }

                string girilenAd;
                string girilenSoyad;
                int girilenMaas;

                Console.Write("Personel Adı: ");
                girilenAd = Console.ReadLine();
                Console.Write("Personel Soyadı: ");
                girilenSoyad = Console.ReadLine();
                Console.Write("Personel Maaşı: ");  
                girilenMaas = Convert.ToInt32(Console.ReadLine()); //int.Parse(Console.ReadLine());

                PersonelListesi.Add(new personel { ad = girilenAd, soyad = girilenSoyad, maas = girilenMaas});
            
            Console.WriteLine("===============Personel Listesi=================");

             foreach (personel p in PersonelListesi)
                {
                Console.WriteLine(p.ad + " " + p.soyad + " " + p.maas);

            }

             for(int i = 0; i< PersonelListesi.Count; i++)
            {
                Console.WriteLine(PersonelListesi[i].ad);
                Console.WriteLine(PersonelListesi[i].soyad);
                Console.WriteLine(PersonelListesi[i].maas);
            }
        }
    }
}
