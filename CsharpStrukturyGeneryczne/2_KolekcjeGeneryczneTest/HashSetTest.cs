using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTest
{
    [TestClass]
    public class HashSetTest
    {
        [TestMethod]
        public void IntersectSets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            /*Scalanie koelekcji, tylko wspólnych elementów między HS - odpowiednik JOIN*/

            set1.IntersectWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] {2, 3}));
        }

        [TestMethod]
        public void UnionSets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            /*Łączenie elementów z obu setów - odpowiednik UNION. Części wspólne kosnoliduje w jedną - nie ma powtórzeń*/

            set1.UnionWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void SymetricExceptSets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            /*Wykazywanie elementów, którymi sety się różnią*/
            set1.SymmetricExceptWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 1, 4 }));

        }

        [TestMethod]
        public void RemoveSets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            /*Z HS, można usuwać wybrany element*/
            set1.Remove(1);

            Assert.AreEqual(2, set1.Count);

        }

        [TestMethod]
        public void RemoveWhereSets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            /*Usuwanie elementów, spełniających określony warunek - wykorzystanie wyrażeń Lambda*/
            set1.RemoveWhere(x => x > 1);

            Assert.AreEqual(1, set1.Count);

        }

        [TestMethod]
        public void ContainsSets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };

            /*Sprawdzanie czy kolekcja zawiera dany element*/
            set1.Contains(3);

            Assert.IsTrue(set1.Contains(3));

        }

    }
}
