using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoThenBy
    {
        /// <summary>
        /// ThenBy は OrderBy を複数キーに対して適用するためのものでしかない。
        /// </summary>
        [TestMethod]
        public void TestThenBy()
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
                .ThenBy(i => i.Word);

            Assert.AreEqual(q.First().Number, 1);
            Assert.AreEqual(q.First().Word, "one");
            Assert.AreEqual(q.Last().Number, 1000);
            Assert.AreEqual(q.Last().Word, "千");

            q = from i in source
                orderby i.Number, i.Word
                select i;

            Assert.AreEqual(q.First().Number, 1);
            Assert.AreEqual(q.First().Word, "one");
            Assert.AreEqual(q.Last().Number, 1000);
            Assert.AreEqual(q.Last().Word, "千");
        }
    }
}
