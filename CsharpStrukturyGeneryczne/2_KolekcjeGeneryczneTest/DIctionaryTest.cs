using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTest
{
    [TestClass]
    public class DIctionaryTest
    {
        [TestMethod]
        public void UzywamySlownikaJakoMapy()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "Jeden");
            mapa.Add(2, "Dwa");
            mapa.Add(3, "Trzy");

            Assert.AreEqual("Jeden", mapa[1]);
        }

        [TestMethod]
        public void WyszukiwanieWSlowniku()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "Jeden");
            mapa.Add(2, "Dwa");
            mapa.Add(3, "Trzy");

            Assert.IsTrue(mapa.ContainsKey(2));
        }

        [TestMethod]
        public void UsuwanieZeSlownika()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "Jeden");
            mapa.Add(2, "Dwa");
            mapa.Add(3, "Trzy");

            mapa.Remove(1);

            Assert.AreEqual(2, mapa.Count);

        }

        [TestMethod]
        public void CzyszczenieSlownika()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "Jeden");
            mapa.Add(2, "Dwa");
            mapa.Add(3, "Trzy");

            mapa.Clear();

            Assert.AreEqual(0, mapa.Count);

        }
        
        [TestMethod]
        public void SlownikJakoSlownik()
        {
            var mapa = new Dictionary<string, string>();
            mapa.Add("one", "jeden");
            mapa.Add("two", "Dwa");
            mapa.Add("three", "Trzy");

            Assert.AreEqual("Dwa", mapa["two"]);

        }
    }
}
