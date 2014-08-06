using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoThenByDescending
    {
        /// <summary>
        /// ByDescending とタイプするのは面倒。
        /// </summary>
        [TestMethod]
        public void TestThenByDescending()
        {
            var source = new[]
            {
                new { Number=1, Word="one", },
                new { Number=10, Word="ten", },
                new { Number=100, Word="hundred", },
                new { Number=1000, Word="thousand", },
                new { Number=1, Word="一", },
                new { Number=10, Word="十", },
                new { Number=100, Word="百", },
                new { Number=1000, Word="千", },
            };

            var q = source
                .OrderBy(i => i.Number)
                .ThenByDescending(i => i.Word);

            Assert.AreEqual(q.First().Number, 1);
            Assert.AreEqual(q.First().Word, "一");
            Assert.AreEqual(q.Last().Number, 1000);
            Assert.AreEqual(q.Last().Word, "thousand");

            q = from i in source
                orderby i.Number, i.Word descending
                select i;

            Assert.AreEqual(q.First().Number, 1);
            Assert.AreEqual(q.First().Word, "一");
            Assert.AreEqual(q.Last().Number, 1000);
            Assert.AreEqual(q.Last().Word, "thousand");
        }
    }
}
