using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoIntersect
    {
        /// <summary>
        /// IEnumerable.Union performs as the INTERSECT operator of ANSI SQL.
        /// </summary>
        [TestMethod]
        public void TestIntersect()
        {
            var source1 = Enumerable.Range(0, 1000).Where(i => i % 5 == 0);
            var source2 = Enumerable.Range(0, 1000).Where(i => i % 7 == 0);
            var result = source1.Intersect(source2);

            Assert.IsTrue(result.All(i => i % 5 == 0));
            Assert.IsTrue(result.All(i => i % 7 == 0));

            // Test if the result is a subset of two sources.
            Assert.IsFalse(result.Except(source1).Any());
            Assert.IsFalse(result.Except(source2).Any());
        }
    }
}
