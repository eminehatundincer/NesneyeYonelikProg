using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace besaralikornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // ogrenci oo = new ogrenci(); ogrenci sınıfından nesne oluşturduk

            insan ii = new ogrenci(); //upcast yaptık, sadece üst sınıf özelliklerini kullanabiliriz.
            ii.boy = 180;

            ogrenci oo = (ogrenci)ii; //downcast yaptık, artık alt sınıfın özelliklerini de kullanabiliriz.
            oo.ogrenciNotOrt = 85;





            List<ogrenci> ogrenciler = new List<ogrenci>(); //ogrenci sınıfının listesini oluşuşturduk
            
     
            for(int i = 0; i <= 3; i++)
            {

                string girilenogrno;
                string girilenad;
                string girilensoyad;
                int girilennotortalama;

                Console.WriteLine("Öğrenci Nosunu giriniz:");
                 girilenogrno = Console.ReadLine();
                Console.WriteLine("Öğrenci Adı Giriniz: ");
                 girilenad = Console.ReadLine();
                Console.WriteLine("Öğrenci Soyadı Giriniz: ");
                 girilensoyad = Console.ReadLine();
                Console.WriteLine("Öğrenci Not Ortalaması Giriniz: ");
                 girilennotortalama = Convert.ToInt32(Console.ReadLine());
               
                ogrenciler.Add(new ogrenci { 
                    ogrenciAd = girilenad, 
                    ogrenciSoyad = girilensoyad ,
                    ogrenciNotOrt = girilennotortalama, 
                    OgrenciNo = girilenogrno});

            }

            double toplam=0;
            ogrenci enEskiOgrenci = ogrenciler[0];

            foreach(ogrenci o in ogrenciler)
            {
                toplam += o.ogrenciNotOrt;
                if (o.kacYil > enEskiOgrenci.kacYil)
                {
                    enEskiOgrenci = o;
                }
            }
          Console.WriteLine("--------SONUÇLAR--------");
          Console.WriteLine("Sınıfın Not Ortalaması: {0} ",(toplam / 4));
          Console.WriteLine("En Eski Öğrenci: {0} {1}  {2} {3} {4}  "
              ,enEskiOgrenci.ogrenciAd,
              enEskiOgrenci.ogrenciSoyad, 
              enEskiOgrenci.ogrenciNotOrt, 
              enEskiOgrenci.OgrenciNo,
              enEskiOgrenci.kacYil);
        }
    }
}
