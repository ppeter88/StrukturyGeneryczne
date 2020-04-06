using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MetodyDelegatyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //ACTION - delegat ogólny
            Action<bool> drukuj = x => Console.WriteLine("Delegaty ogólne " + x);
            Action<int, int, int> test = (a, b, c) => Console.WriteLine(a+b+c);

            //FUNC - delegat ogólny
            Func<double, double> potegowanie = d => d * d;
            Func<double, double, double> dodaj = (x, y) => x + y;

            //PREDICATE - delegat ogólny
            Predicate<double> jestMniejszeOdSto = d => d < 100;

            drukuj(jestMniejszeOdSto(potegowanie(dodaj(3, 4))));

            //CONVERTER - delegat ogólny
            Converter<double, string>   konwerter      = d => d.ToString();

            //CONVERTER 2.0 - przekazany bez zapisywania do zmiennej (określony jako wejście do metody rozszerzeń
            var kolejka = new KolejkaKolowa<double>();      
            WprowadzanieDanych(kolejka);
            var jakoData = kolejka.Mapuj(d => new DateTime(2019, 1, 1).AddDays(d));
            foreach (var item in jakoData)
            {
                Console.WriteLine(item);
            }
            

            //var konsolaWyjscie = new Drukarka<double>(KonsolaWypisz);
            kolejka.Drukuj(d => Console.WriteLine(d));
            PrzetwarzanieDanych(kolejka);

            //EVENT GENERYCZNY - EventHandler
            var kolejka_do_eventu = new KolejkaKolowa<double>(pojemnosc: 3);
            kolejka_do_eventu.elementUsuniety += Kolejka_elementUsuniety;
            WprowadzanieDanych(kolejka_do_eventu);


        }

        private static void Kolejka_elementUsuniety(object sender, KolejkaKolowa<double>.ElementUsunietyEventArgs<double> e)
        {
            Console.WriteLine("Kolejka jest pełna. Element usunięty to: {0} Nowy element to {1}", e.ElementUsuniety, e.ElementNowy);
        }

        private static void PrzetwarzanieDanych(IKolejka<double> kolejka)
        {
            var suma = 0.0;
            Console.WriteLine("W naszej kolejce jest: ");

            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();
            }

            Console.WriteLine(suma);
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0;
                var wartoscwejsciowa = Console.ReadLine();
                if (double.TryParse(wartoscwejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
        }

        static void KonsolaWypisz(double dane)
        {
            Console.WriteLine(dane);
        }
    }
}
