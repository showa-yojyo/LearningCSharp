using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoReverse
    {
        /// <summary>
        /// ã´äEílíçà”ÅB
        /// </summary>
        [TestMethod]
        public void TestReverse()
        {
            int start = 0;
            int count = 10;
            var source = Enumerable.Range(start, count).Reverse();

            Assert.AreEqual(source.First(), count - start - 1);
            Assert.AreEqual(source.Last(), start);
        }
    }
}
