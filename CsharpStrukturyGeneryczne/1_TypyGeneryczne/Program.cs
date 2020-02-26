using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            KolejkaKolowa kolejka = new KolejkaKolowa(5);

            kolejka.Zapisz(1);
            kolejka.Zapisz(2);
            kolejka.Zapisz(3);
            kolejka.Zapisz(4);
            kolejka.Zapisz(5);
            kolejka.Zapisz(6);
            kolejka.Zapisz(7);
            kolejka.Zapisz(8);
            kolejka.Zapisz(9);
            kolejka.Zapisz(10);
            kolejka.Zapisz(11);
            kolejka.Zapisz(12);
            kolejka.Zapisz(13);
            kolejka.Zapisz(14);

            foreach (var item in kolejka.bufor)
            {
                Console.WriteLine(item);
            }

        }
    }
}
