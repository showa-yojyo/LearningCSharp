using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoTake
    {
        /// <summary>
        /// Take ‚Í Skip ‚Æ‹tBæ“ª N ŒÂ‚ğE‚¤B
        /// </summary>
        [TestMethod]
        public void TestTake()
        {
            var source = Enumerable.Range(0, 10);
            var start = 3;
            var end = 8;
            var query = from i in source.Skip(start).Take(end - start + 1)
                        select i * 10;

            Assert.AreEqual(query.First(), 3 * 10);
            Assert.AreEqual(query.Last(), 8 * 10);
        }
    }
}
