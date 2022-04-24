using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartOyunu
{
    internal class Oyun
    {

        Deste destemiz=new Deste();
        int o1P = 0;
        int o2P = 0;

        public void baslat()
        {
            destemiz.olustur();
            destemiz.karistir();
        }

        public void oyna()
        {
            Kart o1k1 = destemiz.kartCek();
            Kart o1k2 = destemiz.kartCek();

            Kart o2k1 = destemiz.kartCek();
            Kart o2k2 = destemiz.kartCek();

            Console.WriteLine("Oyuncu1'in Eli\n");
            o1k1.bilgiYaz();
            o1k2.bilgiYaz();
            o1P = o1k1.puan + o1k2.puan;
            Console.WriteLine("Oyuncu1 Puan:{0}\n", o1P);
           
            Console.WriteLine("Oyuncu2'in Eli\n");
            o2k1.bilgiYaz();
            o2k2.bilgiYaz();
            o2P= o2k1.puan + o2k2.puan;
            Console.WriteLine("Oyuncu2 Puan:{0}\n", o2P);

            if (o1P > o2P)
            {
                Console.WriteLine("Oyuncu1 Kazandı");
            }
            else if(o1P < o2P)
            {
                Console.WriteLine("Oyuncu2 Kazandı");
            }
            else
            {
                Console.WriteLine("Durum:Berabere");
            }
        }


    }
}
