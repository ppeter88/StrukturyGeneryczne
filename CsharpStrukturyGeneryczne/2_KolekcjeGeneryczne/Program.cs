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
            //LinkedList();
            //LinkedList2();
            //Dictionary();
            //Dictionary2();
            //SortedDictionary();
            //SortedList();
            //SortedSet();

            return;
        }

        private static void SortedSet()
        {
            var set = new SortedSet<int>();

            set.Add(4);
            set.Add(1);
            set.Add(2);
            set.Add(6);
            set.Add(4);
            set.Add(2);
            set.Add(1);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            var set2 = new SortedSet<string>();

            set2.Add("osiem");
            set2.Add("jeden");
            set2.Add("pięć");
            set2.Add("trzy");
            set2.Add("dwa");
            set2.Add("pięć");
            set2.Add("osiem");

            foreach (var item in set2)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedList()
        {
            var listaPosortowana = new SortedList<int, string>();

            listaPosortowana.Add(6, "sześć");
            listaPosortowana.Add(3, "trzy");
            listaPosortowana.Add(1, "jeden");
            listaPosortowana.Add(4, "cztery");

            foreach (var item in listaPosortowana)
            {
                Console.WriteLine(item.Value);
            }
        }

        private static void SortedDictionary()
        {
            var pracownicy = new SortedDictionary<string, List<Pracownik>>();

            pracownicy.Add("Sprzedaż", new List<Pracownik> { new Pracownik { Imie = "Marian", Nazwisko = "Grzegorczyk" },
                                                             new Pracownik { Imie = "Izabela", Nazwisko = "Kubicka" },
                                                             new Pracownik { Imie = "Marek", Nazwisko = "Domaradzki" } });
            pracownicy.Add("Zakupy", new List<Pracownik>   { new Pracownik { Imie = "Łukasz", Nazwisko = "Koza" },
                                                             new Pracownik { Imie = "Piotr", Nazwisko = "Ogórek" } });
            pracownicy.Add("Magazyn", new List<Pracownik>  { new Pracownik { Imie = "Paweł", Nazwisko = "Łęcka" },
                                                             new Pracownik { Imie = "Łukasz", Nazwisko = "Górski" },
                                                             new Pracownik { Imie = "Michał", Nazwisko = "Cebula" },
                                                             new Pracownik { Imie = "Basia", Nazwisko = "Olejniczak" } });
            foreach (var item in pracownicy)
            {
                Console.WriteLine("Ilość pracowników w dziale {0} wynosi: {1}", item.Key, item.Value.Count);
            }
        }

        private static void Dictionary2()
        {
            /*Słownik, do którego do jednego klucza, przypisanych jest kilka wartości - poprzez podanie typu Lista do wartości*/
            var pracownicy = new Dictionary<string, List<Pracownik>>();
            pracownicy.Add("Ksiegowosc", new List<Pracownik>() { new Pracownik { Imie = "Wojciech", Nazwisko = "Nowak" } });

            pracownicy["Ksiegowosc"].Add(new Pracownik { Imie = "Jan", Nazwisko = "Kowalski" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Imie = "Mariusz", Nazwisko = "Jurczyszyn" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Imie = "Paweł", Nazwisko = "Domagała" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Imie = "Zenek", Nazwisko = "Martyniuk" });

            pracownicy.Add("Informatyka", new List<Pracownik>() { new Pracownik { Imie = "Marcelina", Nazwisko = "Zawadzka" },
                                                                  new Pracownik { Imie = "Janina", Nazwisko = "Szymańska"   } });


            foreach (var item in pracownicy)
            {
                Console.WriteLine("\nDział: " + item.Key + "\n");
                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine("{0} {1}", pracownik.Imie, pracownik.Nazwisko);
                }
            }

            Console.WriteLine("\nPracownicy z księgowości:");

            foreach (var item in pracownicy["Ksiegowosc"])
            {
                Console.WriteLine(item.Imie + " " + item.Nazwisko);
            }
        }

        private static void Dictionary()
        {
            var pracownicy = new Dictionary<string, Pracownik>();
            pracownicy.Add("Nowak", new Pracownik { Nazwisko = "Nowak" });
            pracownicy.Add("Kowal", new Pracownik { Nazwisko = "Kowal" });
            pracownicy.Add("Kaczor", new Pracownik { Nazwisko = "Kaczor" });
            pracownicy.Add("Nowak", new Pracownik { Nazwisko = "Nowak" });

            var kowal = pracownicy["Kowal"];

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine("{0}:{1}", pracownik.Key, pracownik.Value.Nazwisko);
            }
        }

        private static void LinkedList2()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);

            var elementPierwszy = lista.First;
            var elementOstatni = lista.Last;

            lista.AddAfter(elementPierwszy, 10);
            lista.AddBefore(elementPierwszy, 20);

            var wezel = lista.First;

            while (wezel != null)
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }

        private static void LinkedList()
        {
            /*Kolekcja, gdzie pojedyncza pozycja, zawiera wskaźnik do obiektu przed i po niej w całej kolekcji*/
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);
            lista.AddLast(1);
            lista.AddLast(2);


            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
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
