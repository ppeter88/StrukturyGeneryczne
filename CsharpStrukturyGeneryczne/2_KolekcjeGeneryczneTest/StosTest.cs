using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace _2_KolekcjeGeneryczneTest
{
    [TestClass]
    public class StosTest
    {
        [TestMethod]
        public void UzycPeek()
        {
            var stos = new Stack<int>();
            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);

            /*Peek pobiera pierwsze następne wystąpienie (LIFO), ale nie usuwa z kolejki*/
            Assert.AreEqual(4, stos.Peek());
        }

        [TestMethod]
        public void UzycContains()
        {
            var stos = new Stack<int>();
            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);

            /*Contains - czy zawiera, analogicznie do kolejki*/
            Assert.IsTrue(stos.Contains(3));
        }

        [TestMethod]
        public void UzycToArray()
        {
            var stos = new Stack<int>();
            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);

            /*Zamiana na tablicę - analogicznie do kolejki*/
            var tablica = stos.ToArray();
            stos.Pop();

            Assert.AreEqual(tablica[0], 4);
            Assert.AreEqual(3, stos.Count);
        }

        [TestMethod]
        public void UzycClear()
        {
            var stos = new Stack<int>();
            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);

            /*Usuwanie sotsu - analogicznie jak do kolejki*/
            stos.Clear();

            Assert.AreEqual(0, stos.Count);
        }
    }
}
