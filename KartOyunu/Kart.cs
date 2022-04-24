using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartOyunu
{
    internal class Kart
    {
        public string turu;
        public string sayisi;
        public int puan;


        public void bilgiYaz()
        {
            Console.WriteLine("{0}-{1}:puan:{2}", turu, sayisi, puan);

        }


    }
}
