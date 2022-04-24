using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  Deste destemiz=new Deste();
            destemiz.olustur();
            destemiz.desteYaz();
            destemiz.desteYaz(); */
            
            Oyun oyunum=new Oyun();
            oyunum.baslat();
            oyunum.oyna();

        }
    }
}
