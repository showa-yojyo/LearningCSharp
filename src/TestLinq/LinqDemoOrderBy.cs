using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoOrderBy
    {
        /// <summary>
        /// 単純な値のコレクションならば Sort メソッドで十分。
        /// </summary>
        [TestMethod]
        public void TestOrderBy()
        {
            var source = new[]
            {
                new { Number=1, English="one", Japanese="一", },
                new { Number=10, English="ten", Japanese="十", },
                new { Number=100, English="hundred", Japanese="百"},
                new { Number=1000, English="thousand", Japanese="千"},
            };

            var q1 = source.OrderBy(i => i.Number);
            Assert.AreEqual(q1.First().Number, 1);
            Assert.AreEqual(q1.Last().Number, 1000);

            var q2 = source.OrderBy(i => i.English);
            Assert.AreEqual(q2.First().English, "hundred");
            Assert.AreEqual(q2.Last().English, "thousand");
        }
    }
}
