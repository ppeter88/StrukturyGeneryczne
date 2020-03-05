using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTest
{
    [TestClass]
    public class ListaTest
    {
        [TestMethod]
        public void ListaMozemyDodawacNaKoniec()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };

            /*Dodawanie wartości na ostatniej pozycji listy*/
            listaLiczb.Add(4);

            Assert.AreEqual(4, listaLiczb[3]);
        }

        [TestMethod]
        public void ListaMozemyDodacNaPozycji()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };

            /*Dodawanie wartości, na określonej pozycji listy (indeks, wartość)*/
            listaLiczb.Insert(1, 8);

            Assert.AreEqual(8, listaLiczb[1]);
        }

        [TestMethod]
        public void ListaMozemyUsuwacElement()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };

            /*Usuwanie określonej wartości z pozycji listy (wartość)*/
            listaLiczb.Remove(2);

            //Assert.IsTrue(listaLiczb.SequenceEqual(new[] { 1, 3 }));

        }

        [TestMethod]
        public void ListaMozemyUsuwacElementNaPozycji()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };

            /*Usuwanie wartości z określonej pozycji listy (indeks)*/
            listaLiczb.RemoveAt(2);

            //Assert.IsTrue(listaLiczb.SequenceEqual(new[] { 1, 2 }));

        }

        [TestMethod]
        public void ListaMozemyWyszukiwacIndeksElementu()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };

            /*Wyszukiwanie numeru indeksu, danej wartości z listy*/
            Assert.AreEqual(listaLiczb.IndexOf(3), 2);

        }

        [TestMethod]
        public void ListaMozemyWyszukiwacCzyZawiera()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };

            /*Sprawdzanie, czy lista zawiera w sobie jakiś element*/   
            Assert.IsTrue(listaLiczb.Contains(3));

        }

        [TestMethod]
        public void ListaMozemyDodawacNaKoniecZakresLiczb()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };

            var zakres = new List<int> { 4, 5, 6, 7 };

            /*Dodawanie zakresu liczb do tablicy*/
            listaLiczb.AddRange(zakres);

            Assert.AreEqual(7, listaLiczb[6]);
        }


    }
}
