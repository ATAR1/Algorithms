using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sort.Tests
{
    [TestClass()]
    public class InsertionSorterTests
    {
        [TestMethod()]
        public void ShiftTest()
        {
            int[] mass = new[] { 1, 2, 3 };
            InsertionSorter.Shift(mass, 2, 0);
            Assert.IsTrue(Enumerable.SequenceEqual(mass, new[] { 1, 1, 2 }));
        }

        [TestMethod()]
        public void FindPositionTest()
        {
            var actual =  InsertionSorter.FindPosition(new[] { 1, 4, 6}, 3, 2);
            Assert.AreEqual(1, actual);
            actual = InsertionSorter.FindPosition(new[] { 1, 4, 6, 5 }, 3, 7);
            Assert.AreEqual(3, actual);
        }
    }
}