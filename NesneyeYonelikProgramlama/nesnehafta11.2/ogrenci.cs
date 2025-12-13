using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace besaralikornek2
{
    internal class ogrenci: insan
    {
        public string ogrenciAd;
        public string  ogrenciSoyad;
        public int ogrenciNotOrt;
        private string ogrenciNo; //string olarak alıp substring metodu ile kaçıncı yılı olduğunu hesaplayabilirsin 
        public int kacYil;
            public string OgrenciNo{
                get { return ogrenciNo; }
                set {
                ogrenciNo = value;
                kacYil = 26 - int.Parse(ogrenciNo.Substring(0, 2));
            }
        }




    }
}
