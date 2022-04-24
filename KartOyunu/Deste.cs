using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartOyunu
{
    internal class Deste
    {
       
        Kart[] kartlar = new Kart[52];
        int cekilenKS = 0;
        public void olustur()
        {
            string[] turler = new string[4] { "Karo", "Kupa", "Maça", "Sinek" };
           string[] sayilar = new string[13] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "K", "Q" };
            int k = 0;
            int[] puanlar = new int[13] { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 15, 20 };
            for(int i = 0; i <4; i++)
            {
                for(int j = 0; j <13; j++)
                {
                    kartlar[k] = new Kart();
                    kartlar[k].turu = turler[i];
                    kartlar[k].sayisi=sayilar[j];
                    kartlar[k].puan = puanlar[j];
                    k++;
                }
            }

        }

        public void desteYaz()
        {
            //test amacli
            for(int i = 0; i < 52; i++)
            {
                kartlar[i].bilgiYaz();
            }
        }


        public void karistir()
        {
            //shuffle
            Random sayiGen = new Random();
           for(int i = 0; i < 52; i++)
            {
                int rIndis = sayiGen.Next(0, 52);
                Kart gecici = kartlar[i];
                kartlar[i] = kartlar[rIndis];
                kartlar[rIndis] = gecici;
            }
        }

        public Kart kartCek()
        {
            return kartlar[cekilenKS++];
        }


    }
}
