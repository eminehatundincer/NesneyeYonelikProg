using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Class1
    {
        //private string sicilNo;
        public int yetkiID;
        public string sicilNo
        {
            get
            {
                if (yetkiID == 4)
                {
                    return SicilNo;
                }
                set
            {
                    if (yetkiID == 4)
                    {


                    }
                }

        private string OgrAd;
        private string OgrSoyad;
        private string OgrNo;
        private int sinif;


        //kurucu metotları çalıştırıyoruz
        public ogrenci()
        {
            Console.WriteLine("Kurucu Metot Çalıştı.");
        }
        public ogrenci(string id)
        {

        }
        public ogrenci(int k1, int k2)
        {

        }

        //private ile tanımladıklarımızı public'e çeviriyoruz.
        public string OgrAd
        {
            get
            {
                return Ograd;
            }
            set
            {
                ad = value;
            }
        }
        public string OgrSoyad
        {
            get
            {
                return OgrSoyad;
            }
            set
            {
                soyad = value;
            }
        }

        public int sinif
        {
            get
            {
                return sinif;
            }
            set
            {
                sinif = value;
            }
        }

        public string OgrNo
        {
            get
            {
                return OgrNo;
            }
            set
            {
                if (value.Length == 10)
                {
                    OgrNo = value;
                    sinif = 26 - Convert.ToInt32(OgrNo.Substring(0, 2));
                }
                else
                {
                    OgrNo = "2211012001";
                    sinif = 26 - Convert.ToInt32(OgrNo.Substring(0, 2));

                }
            }
        }
    }
}
