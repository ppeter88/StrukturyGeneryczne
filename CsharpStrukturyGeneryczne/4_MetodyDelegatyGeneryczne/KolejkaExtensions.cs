using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _4_MetodyDelegatyGeneryczne
{
    public delegate void Drukarka<T>(T dane);

    public static class KolejkaExtensions
    {

        //Metoda, która pozwala na skonwertowanie dowolnego podanego typu w implementacji, na dowolny typ, danej klasy (nie obsługuje wszystkich przypadków.
        public static IEnumerable<Twyjscie> ElementJako<T, Twyjscie>(this IKolejka<T> kolejka)
        {
            var konwerter = TypeDescriptor.GetConverter(typeof(T));

            foreach (var item in kolejka)
            {
                var wynik = konwerter.ConvertTo(item, typeof(Twyjscie));
                yield return (Twyjscie)wynik;
            }

        }

        //Metoda konwertująca - lepsza - z wykorzystaniem delegata ogólnego Converter
        public static IEnumerable<Twyjscie> Mapuj<T, Twyjscie>(this IKolejka<T> kolejka, Converter<T, Twyjscie> konwerter)
        {
            return kolejka.Select(i => konwerter(i));     
        }

        public static void Drukuj<T>(this IKolejka<T> kolejka, Action<T> wydruk)
        {
            foreach (var item in kolejka)
            {
                wydruk(item);
            }
        }
    }
}
