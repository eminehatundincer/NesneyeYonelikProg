using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisma7kasim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  String kelime;
              Console.WriteLine("Bir kelime giriniz:");
              kelime = Console.ReadLine(); //kelimeyi burada giriyoruz  
              Console.WriteLine(kelime); // kelimeyi ekrana yazdırıyoruz
            */

            /*andom rnd = new Random();
             int a = rnd.Next(10); //0-9 arası sayılardan atar
             int b;
             int c = 1;
             while (true)
             {
                 Console.WriteLine("Bir sayı tahmin ediniz(0-9):");
                 b = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine(c + ".Tahmininiz: " + b);
                 if (a == b) {
                     Console.WriteLine(c + ".tahmin doğru");
                     break;
                 }
                 c++;
             }
            */
            /*
 Toplam tahmin sayısı 5 olan ,1 ile 100 arasında tutulan rastgele sayıyı bulma oyunu yapalım.
5.hakta bilemezse «oyunu kaybettiniz» yazsın ve tutulan sayıyı ekrana yazdırsın.
Eğer tahmin doğruysa «tebrik ederiz 3.tahmininizde buldunuz» yazsın
            */
            Random rnd = new Random();
            int a = rnd.Next(100) + 1;

            int hak = 0;
            int tahmin;

            do
            {
                Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Bakalım bulabilecek misin?");
                tahmin = Convert.ToInt32(Console.ReadLine());
                hak++;

                if (tahmin == a)
                {
                    Console.WriteLine("Tebrikler! " + hak + ". tahmininizde bildiniz.");
                }
               

                else if (tahmin < a)
                {
                    Console.WriteLine("Daha büyük bir sayı söyleyin.");
                }
                else
                {
                    Console.WriteLine("Daha küçük bir sayı söyleyin.");
                }

                if (hak == 5 && tahmin != a)
                {
                    Console.WriteLine("❌ Oyunu kaybettiniz! Tutulan sayı: " + a);
                    break;
                }


            } while ( hak <= 5);

           



        }
    }
}
