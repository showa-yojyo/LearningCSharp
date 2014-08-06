using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoSkip
    {
        /// <summary>
        /// Skip ‚Í—ñ‚Ìæ“ª‚©‚ç n ŒÂ‚ğÌ‚Ä‚éB
        /// </summary>
        [TestMethod]
        public void TestSkip()
        {
            var source = Enumerable.Range(0, 10);
            var start = 3;
            var query = from i in source.Skip(start)
                        select i * 10;

            Assert.AreEqual(query.First(), 3 * 10);
            Assert.AreEqual(query.Last(), 9 * 10);
        }
    }
}
