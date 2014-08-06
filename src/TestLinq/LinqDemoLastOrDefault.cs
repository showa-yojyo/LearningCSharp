using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoLastOrDefault
    {
        [TestMethod]
        public void TestLastOrDefault()
        {
            var source = Enumerable.Range(0, 10);
            Assert.AreEqual(source.LastOrDefault(), 9);
        }

        [TestMethod]
        public void TestLastOrDefaultEmptySeqCase()
        {
            var source = Enumerable.Range(0, 0);
            Assert.AreEqual(source.LastOrDefault(), 0);
        }
    }
}
