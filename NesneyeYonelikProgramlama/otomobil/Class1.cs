using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomobil
{
    internal class Class1
    {

        public string marka, model;//herkes tarafından erişilebilecek 
        public int yil;
        //private int yas;//sadece class ın içinde erişilebilecek

        public void bilgiGoster()
        {
            Console.WriteLine("arabanın markası: " + marka);
            Console.WriteLine("arabanın modeli " + model);
            Console.WriteLine("arabanın üretim yılı:" + yil);
        }

       /* public void gazaBas()
        {
            Console.WriteLine("Gaza basıldı:");
        }

        public int yas
        {
            // private dışa kapalı olduğu için açmak amcıyla kapsül kullanıyoruz.
            //10 yaşından küçük arabaların yaşını 0 almka istiyoruz
            get
            {
                return yas;
            }
            set
            {
                if(value <= 10)
                {
                    yas = 0;
                }
                else
                {
                    yas = value;
                }
            }*/







        }

    }

