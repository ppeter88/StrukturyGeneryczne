using System;
using _1_TypyGeneryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1_TypyGeneryczneTest
{
    [TestClass]
    public class KolejkaKolowaTests
    {
        [TestMethod]
        public void NowaKolejkaJestPusta()
        {
            var kolejka = new KolejkaKolowa<double>();

            Assert.IsTrue(kolejka.JestPusty);
        }

        [TestMethod]
        public void KolejkaTrzyElementowaJestPelnaPoTrzechZapisach()
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            kolejka.Zapisz(3.8);
            kolejka.Zapisz(4.3);
            kolejka.Zapisz(3.5);

            Assert.IsTrue(kolejka.JestPelny);
        }

        [TestMethod]
        public void PierwszyWychodziPierwszyWchodzi()
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            var wartosc1 = 4.6;
            var wartosc2 = 3.7;

            kolejka.Zapisz(wartosc1);
            kolejka.Zapisz(wartosc2);

            Assert.AreEqual(wartosc1, kolejka.Czytaj());
            Assert.AreEqual(wartosc2, kolejka.Czytaj());
            Assert.IsTrue(kolejka.JestPusty);
        }

        [TestMethod]
        public void NadpisujeGdyJestWiekszaNizPojemnos()
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            var wartosci = new[] { 1.3, 12.3, 3.2, 5.21, 12.4, 33.2 };

            foreach (var wartosc in wartosci)
            { 
                kolejka.Zapisz(wartosc);
            }

            Assert.IsTrue(kolejka.JestPelny);
            Assert.AreEqual(wartosci[3], kolejka.Czytaj());
            Assert.AreEqual(wartosci[4], kolejka.Czytaj());
            Assert.AreEqual(wartosci[5], kolejka.Czytaj());
        }

    }
}
