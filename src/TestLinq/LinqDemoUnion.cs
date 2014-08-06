using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoUnion
    {
        /// <summary>
        /// IEnumerable.Union performs as the UNION operator of ANSI SQL.
        /// </summary>
        [TestMethod]
        public void TestUnion()
        {
            var source1 = Enumerable.Repeat(0, 10); // 0 * 10
            var source2 = Enumerable.Repeat(1, 100); // 1 * 100
            var result = source1.Union(source2);

            Assert.AreEqual(result.Count(), 2);
            Assert.IsTrue(result.Contains(0));
            Assert.IsTrue(result.Contains(1));
        }
    }
}
