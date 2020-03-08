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
            //ListaPracowników();
            //ListaLiczb();
            //Kolejka();
            //Stos();
            //HashSet();

            return;
        }

        private static void HashSet()
        {
            //---------------------------------------------------------------------HashSet---------------------------------------------------------------------------------------
            HashSet<Pracownik> set = new HashSet<Pracownik>();

            /*Odwołując się do tego samego obiektu, HS nie zapisze ponownie wartości*/
            var pracownik = new Pracownik { Imie = "Paweł" };
            set.Add(pracownik);
            set.Add(pracownik);

            /*W poniższym przypadku, HS pozwoli wpisać Wartość ponownie - są to odrębne obiekty, HS nie potrafi sprawdzićw prosty sposób czy się różnią*/
            set.Add(new Pracownik { Imie = "Marcin" });
            set.Add(new Pracownik { Imie = "Marcin" });

            Console.WriteLine();

            foreach (var item in set)
            {
                Console.WriteLine(item.Imie);
            }
        }

        private static void ListaPracowników()
        {
            //------------------------------------------------------------------------ LISTA - pracowników --------------------------------------------------------------------------------------
            var pracownicy = new List<Pracownik>
            {
                /*Inicjalizator tablicy - tablica będzie przechowywać tyle elelemntów, jakie zdefiniujemy w klamrach*/
                new Pracownik {Imie = "Marcin", Nazwisko = "Nowak"},
                new Pracownik {Imie = "Łukasz", Nazwisko = "Domaradzki"},
                new Pracownik {Imie = "Paweł", Nazwisko = "Igaweł"},
            };

            pracownicy.Add(new Pracownik { Imie = "Ania", Nazwisko = "ZZielonegoWzgórza" }); /*Uproszczone dodawania kolejnych pozycji - lista automatycznie zwiększa swój rozmiar*/

            Console.WriteLine("LISTA - pracowników");
            Console.WriteLine();
            Console.WriteLine("Foreach");
            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }

            Console.WriteLine();
            Console.WriteLine("For");
            for (int i = 0; i < pracownicy.Count; i++) /*Do określania wielkości Listy, służy Count a nie Length*/
            {
                Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
            }
        }

        private static void ListaLiczb()
        {
            //------------------------------------------------------------------------- LISTA - liczb -----------------------------------------------------------------------------------------
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

        private static void Stos()
        {
            //----------------------------------------------------------------------------- STOS -------------------------------------------------------------------------------------------------
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Paweł", Nazwisko = "Domagała" });
            stos.Push(new Pracownik { Imie = "Zenek", Nazwisko = "Martyniuk" });
            stos.Push(new Pracownik { Imie = "Damian", Nazwisko = "Krauze" });

            Console.WriteLine();
            Console.WriteLine("Stos");

            while (stos.Count > 0)
            {
                var pracownik = stos.Pop();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }

        private static void Kolejka()
        {
            ////-------------------------------------------------------------------------- KOLEJKA ----------------------------------------------------------------------------------------------
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Paweł", Nazwisko = "Domagała" });
            kolejka.Enqueue(new Pracownik { Imie = "Zenek", Nazwisko = "Martyniuk" });
            kolejka.Enqueue(new Pracownik { Imie = "Damian", Nazwisko = "Krauze" });

            Console.WriteLine();
            Console.WriteLine("Kolejka");

            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}
