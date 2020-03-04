using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik[] pracownicy = new Pracownik[]
            {
                /*Inicjalizator tablicy - tablica będzie przechowywać tyle elelemntów, jakie zdefiniujemy w klamrach*/
                new Pracownik {Imie = "Marcin", Nazwisko = "Nowak"},
                new Pracownik {Imie = "Łukasz", Nazwisko = "Domaradzki"},
                new Pracownik {Imie = "Paweł", Nazwisko = "Igaweł"},
            };

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }

            /*Poniżej, możliwość zmiany wielkości tablicy*/
            Array.Resize(ref pracownicy, 10);
            pracownicy[9] = new Pracownik { Imie = "Anatol", Nazwisko = "Kołodziej" };
        }
    }
}
