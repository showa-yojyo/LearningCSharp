using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoZip
    {
        /// <summary>
        /// Zip ÇÕñ îíÇ¢ó·Ç™ïÇÇ©ÇŒÇ»Ç¢ÅB
        /// </summary>
        [TestMethod]
        public void TestZip()
        {
            var source1 = Enumerable.Range(0, 10);
            var source2 = Enumerable.Repeat(-1, 20);

            var result = source1.Zip(source2, (first, second) => first * second);

            Assert.AreEqual(result.Count(), Math.Min(source1.Count(), source2.Count()));
            Assert.AreEqual(result.First(), 0);
            Assert.AreEqual(result.Last(), -9);
        }
    }
}
