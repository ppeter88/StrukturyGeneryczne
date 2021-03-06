﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace _4_MetodyDelegatyGeneryczne
{
    public class DuzaKolejka<T> : IKolejka<T>
    {
        protected Queue<T> kolejka;

        public DuzaKolejka()
        {
            kolejka = new Queue<T>();
        }

        public virtual bool JestPelny { get; }

        public virtual bool JestPusty
        {
            get
            {
                return kolejka.Count == 0;
            }
        }

        public virtual T Czytaj()
        {
            return kolejka.Dequeue();
        }

        public virtual void Zapisz(T wartosc)
        {
            kolejka.Enqueue(wartosc);
        }

        ////Metoda, która pozwala na skonwertowanie dowolnego podanego typu w implementacji, na dowolny typ, danej klasy.              PRZENIESIONE DO METODY EXTENSION
        //public IEnumerable<Twyjscie> ElementJako<Twyjscie>()
        //{
        //    var konwerter = TypeDescriptor.GetConverter(typeof(T));

        //    foreach (var item in kolejka)
        //    {
        //        var wynik = konwerter.ConvertTo(item, typeof(Twyjscie));
        //        yield return (Twyjscie)wynik;
        //    }

        //}

        //Dodana metoda, zwracająca typ, któty umożliwia używanie foreacha dla całej kolekcji
        public IEnumerator<T> GetEnumerator()
        {
            //return kolejka.GetEnumerator();

            foreach (var item in kolejka)
            {
                //filtrowanie

                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
