using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoOrderByDescending
    {
        /// <summary>
        /// ByDescending は手でタイプするのが面倒。
        /// </summary>
        [TestMethod]
        public void TestOrderByDescending()
        {
            var source = new[]
            {
                new { Number=1, English="one", Japanese="一", },
                new { Number=10, English="ten", Japanese="十", },
                new { Number=100, English="hundred", Japanese="百"},
                new { Number=1000, English="thousand", Japanese="千"},
            };

            var q1 = source.OrderByDescending(i => i.Number);
            Assert.AreEqual(q1.First().Number, 1000);
            Assert.AreEqual(q1.Last().Number, 1);

            var q2 = source.OrderByDescending(i => i.English);
            Assert.AreEqual(q2.First().English, "thousand");
            Assert.AreEqual(q2.Last().English, "hundred");
        }
    }
}
