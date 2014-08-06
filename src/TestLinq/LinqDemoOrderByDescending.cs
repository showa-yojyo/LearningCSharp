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
        /// ByDescending �͎�Ń^�C�v����̂��ʓ|�B
        /// </summary>
        [TestMethod]
        public void TestOrderByDescending()
        {
            var source = new[]
            {
                new { Number=1, English="one", Japanese="��", },
                new { Number=10, English="ten", Japanese="�\", },
                new { Number=100, English="hundred", Japanese="�S"},
                new { Number=1000, English="thousand", Japanese="��"},
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
