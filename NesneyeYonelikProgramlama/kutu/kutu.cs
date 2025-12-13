using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutu
{
    internal class kutu
    {
        private int esyasayisi;
        public int Esya
        {
            get
            {
                return esyasayisi;
            }
            set
            {
                if (value >= 0)
                    esyasayisi = value;
                else
                {
                    Console.WriteLine("Kutu boş");
                }
            }
        }

        public int bilgi()
        {
            Console.WriteLine("Kutuda" + esyasayisi + "kadar eşya var");
            return esyasayisi;
        }




    }
}
