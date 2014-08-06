using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoElementAtOrDefault
    {
        [TestMethod]
        public void TestElementAtOrDefault()
        {
            var source = Enumerable.Range(0, 100);
            Assert.AreEqual(source.ElementAtOrDefault(44), 44);
        }

        [TestMethod]
        public void TestElementAtOrDefaultOutOfRangeCase()
        {
            var source = Enumerable.Range(0, 100);
            Assert.AreEqual(source.ElementAtOrDefault(-44), default(int));
        }
    }
}
