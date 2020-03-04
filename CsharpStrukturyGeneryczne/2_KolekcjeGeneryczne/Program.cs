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
            /* Lista pracowników */
            var pracownicy = new List<Pracownik>
            {
                /*Inicjalizator tablicy - tablica będzie przechowywać tyle elelemntów, jakie zdefiniujemy w klamrach*/
                new Pracownik {Imie = "Marcin", Nazwisko = "Nowak"},
                new Pracownik {Imie = "Łukasz", Nazwisko = "Domaradzki"},
                new Pracownik {Imie = "Paweł", Nazwisko = "Igaweł"},
            };

            pracownicy.Add(new Pracownik { Imie = "Ania", Nazwisko = "ZZielonegoWzgórza" }); /*Uproszczone dodawania kolejnych pozycji - lista automatycznie zwiększa swój rozmiar*/

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }

            for (int i = 0; i < pracownicy.Count; i++) /*Do określania wielkości Listy, służy Count a nie Length*/
            {
                Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
            }

            /* Lista liczb */
            var liczby = new List<int>();
            var pojemnosc = -1;

            while (true) 
            {
                if (liczby.Capacity != pojemnosc)
                {
                    pojemnosc = liczby.Capacity;
                    Console.WriteLine(pojemnosc);
                }

                liczby.Add(1);                               
            }

        }
    }
}
