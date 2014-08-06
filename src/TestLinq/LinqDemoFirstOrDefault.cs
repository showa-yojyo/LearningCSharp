using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoFirstOrDefault
    {
        [TestMethod]
        public void TestFirstOrDefault()
        {
            var source = Enumerable.Range(0, 10);
            Assert.AreEqual(source.FirstOrDefault(), 0);
        }

        [TestMethod]
        public void TestFirstOrDefaultEmptySeq()
        {
            var source = Enumerable.Range(0, 0);
            Assert.AreEqual(source.FirstOrDefault(), 0);
        }
    }
}
