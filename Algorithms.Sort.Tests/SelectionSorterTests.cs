using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sort.Tests
{
    [TestClass()]
    public class SelectionSorterTests
    {
        [TestMethod()]
        public void ChangeTest()
        {
            var actual = new[] { 0, 1 };
            SelectionSorter.Change(actual, 0, 1);

            Assert.IsTrue(actual.SequenceEqual(new[] { 1, 0 }));
        }

        [TestMethod()]
        public void FindSmalestTest()
        {
            int actual = SelectionSorter.FindSmalest(new[] { 2, 1, 0 }, 0);
            Assert.AreEqual(2, actual);
        }
    }
}