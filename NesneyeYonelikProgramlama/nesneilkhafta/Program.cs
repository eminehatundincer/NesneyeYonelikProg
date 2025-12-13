using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneilkhafta
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //HAFTA 1//
                /*Console.WriteLine("Adı \t\t SOYADI \t\t  OGRNO \t\t");
                 Console.WriteLine("***********************************************");
                 Console.WriteLine("ARDA \t\t CANKAYA \t\t 39123123");
                 Console.WriteLine("CEM \t\t CITE \t\t 312312123132");
                 Console.ReadKey();*/




                /*int sayi1=10;
                double sayi2=5.2;  
                //String kelime;
                Console.WriteLine("Girilen Sayı: " + sayi1 + "");
                Console.WriteLine(sayi2);
                Console.WriteLine("girilen sayı : {0}{1} dır." , sayi1 , sayi2);
                Console.ReadKey();


                String kelime;
                kelime = Console.ReadLine();  //ASCII 

                int sayi11;
                sayi11 = Convert.ToInt32(Console.ReadLine());*/


                /* int a, b, toplam;
                 Console.WriteLine("1. Sayı: ");
                 a = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("2. sayı : ");
                 b = Convert.ToInt32(Console.ReadLine());
                 toplam = a + b;
                 Console.WriteLine("Toplam = {0} ", toplam);
                 Console.WriteLine(toplam);
                 Console.WriteLine("Toplam = " + toplam);
                 Console.ReadKey();*/


                /* //vize final notları + ortalama 
                  int vize, final;
                   double ortalama;
                  Console.WriteLine("Vize notlarını giriniz:");
                  vize = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Final notlarını giriniz:");
                  final = Convert.ToInt32(Console.ReadLine());
                  ortalama = ( vize * 0.4 ) + (final * 0.6 );
                  Console.WriteLine("Ortalama:" + ortalama );
                  Console.ReadKey();  */

                /*if () 
                {

                }
                else if()
                {

                }
                else 
                {

                }*/


                  /*int not1, not2 , deger;
                  double ort , sonuc;
                  Console.WriteLine("Dersin öğrenim çıktısına katkısını giriniz:");
                  deger = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Vize notunu giriniz:");
                  not1 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Final notunu giriniz:");
                  not2 = Convert.ToInt32(Console.ReadLine());
                  ort = ((not1 * 0.4) + (not2 * 0.6)) * 0.1;
                  sonuc = ort * deger;
                  Console.WriteLine("Sonuç:" + sonuc);
                  Console.ReadKey();*/
                




                 /*int saat, sayi;
                 Console.WriteLine("Kaç saattir soru sormadın ?");
                 saat = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Kaç tane sayı sormak istiyorsun ?");
                 sayi = Convert.ToInt32(Console.ReadLine());
                 if((saat* 4) - sayi > 0  )
                 {
                     Console.WriteLine( (saat* 4) - sayi  + " kadar daha soru sorma hakkın var ");
                 }
                 else if ( (saat*4) - sayi == 0){
                     Console.WriteLine(" Kadar soruyu cevaplayabilirim");

                 }
                  else {
                     Console.WriteLine("Geriye kalan " + "5" + "Kadar soruyu cevaplamam için beklemen gerekiyor");
                 }*/


            /* int degisken;
             switch (degisken) {
                 case1:
             break;
             default:
                 break;

             } */

            // bitcoin sorusunu yap 
            //Bitcoin şirketindeki kişilerin tecrübe durumuna göre alım satım lşmştlerş bulunmakta.
            //tecrübeler azdan çok a doğru 1-2 arasındadır. 
            // 1 tecrübesi ilehesaba 1000 tl ve daha az ise hepsini, üstündeyse yüzde 4* ını
            // hesaptaki para 5000 tl ve daha az ise hepsini , üstünde %60 ını herhangi bir coine yatırılabilir. 
            // Buna göre kişi tecrübe seviyesi ve hesabındaki parayı girdikten sonra kişiye kaç paralık alım yapabileceğini 
            //söyleyen programı yapın.

            /* int tecrube;
             double para;
             Console.WriteLine("Tecrübe seviyenizi giriniz (1-2) :");
             tecrube = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Hesabınızdaki parayı giriniz :");
             para = Convert.ToInt32(Console.ReadLine());
             switch (tecrube)
             {
                 case 1:
                     if (para <= 1000)
                     {
                         Console.WriteLine("Tüm paranızı yatırıma ayırabilirsiniz.");
                     }
                     else 
                     {
                         Console.WriteLine("Yatırıma ayırabileceğiniz miktar: " + (para * 0.04) + " TL");
                     }
                     break;
                 case 2:
                     if (para <= 5000)
                     {
                         Console.WriteLine("Tüm paranızı yatırıma ayırabilirsiniz.");
                     }
                     else 
                     {
                         Console.WriteLine("Yatırıma ayırabileceğiniz miktar: " + (para * 0.6) + " TL");
                     }
                     break;
                 default:
                     Console.WriteLine("Geçersiz tecrübe seviyesi girdiniz.");
                     break;
             }*/


        }
    }
}
