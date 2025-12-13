using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesnehafta4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a, b, toplam;
            double ortalama;

            Console.WriteLine("Vize Notu:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final Notu:");
            b = Convert.ToInt32(Console.ReadLine());

            toplam = a + b;
            Console.WriteLine("Toplam:" + toplam);

            ortalama = toplam / 2;
            Console.WriteLine("Ortalama: " + ortalama);

            Console.ReadKey();*/

            /* double not1,not2,ortalama,katki,sonuc;
             Console.WriteLine("Vize notu:");
             not1= Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Final notu:");
             not2 = Convert.ToDouble(Console.ReadLine());
             ortalama = (not1 * 0.4) + (not2 * 0.6);
             katki = Convert.ToDouble(Console.ReadLine());
             sonuc = katki * ortalama;
             Console.WriteLine(sonuc);
             Console.ReadKey();*/

            /*  double saat, istek, hak, artan, bekleme;
              Console.WriteLine("Kaç saattir soru sormuyorsun:");
              saat = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Kaç soru soracaksın:");
              istek = Convert.ToInt32(Console.ReadLine());
              hak = saat * 4;  //saat başına 4 soru hakkı
              bekleme = (istek - hak) / 4; //yetersiz hak varsa bekleme süresi 
              artan = hak - istek;
              Console.WriteLine(hak + "tane soru hakkınız vardır.");
              if (istek > hak){
                  Console.WriteLine("Yeterli soru sorma hakkınız yok." + bekleme + "saat daha beklemeniz gerek.");
              }
              else if(istek < hak)
              {
                  Console.WriteLine("Soru sorma hakkınız var. " + artan + "tane hakkınız daha bulunuyor.");
              }
              else if(istek  == hak){
                   Console.WriteLine("Soru sorma hakkınız tam olarak doldu.");
              }   */


            /* //Girilen iki sayı arasındaki çift sayıların toplamını bulan program:
             int sayi1, sayi2, toplam = 0;
             Console.WriteLine("1. sayıyı giriniz:");
             sayi1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("2. sayıyı giriniz:");
             sayi2 = Convert.ToInt32(Console.ReadLine());

             for(int i = sayi1; i<= sayi2; i++)
             {
                 if(i %2 == 0)
                 {
                     toplam = toplam + i;
                 }
                 else
                 {
                     continue;
                 }
             }

             Console.WriteLine("Toplam:" + toplam);
             Console.ReadKey();
          */
            /*
            Random rnd = new Random();
            int sayi = rnd.Next(0, 10); //0 ile 10 arasında random sayı üretiyoruz 
            int i = 0, girilenSayi;
            while (true)
            {
                Console.WriteLine("Sayı giriniz");
                girilenSayi = Convert.ToInt32(Console.ReadLine());
                i++;
                                if (girilenSayi == sayi)
                {
                    Console.WriteLine("Girilen sayıbulundu" + i + " kez denemede");
                    break;
                }
    
            } */ 




        }
    }
}
