using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasim21nesneornek3
{
    internal class fakulte:universite
    {
        private string fakulteadi;
        private string kampusadi;

        public fakulte()
        {
            universiteadi = "ABC Üniversitesi";
            sehiradi = "Istanbul";
        }
        public string Fakulteadi //dışarıdan kullanımlar olacak
        {
            get { return fakulteadi; }
            set { fakulteadi = value; }
        }

        public string kampusadi //dışarıdan kullanımlar olacak
        {
            get { return kampusadi; }
            set { kampusadi = value; }
        }   

     

    }
}
