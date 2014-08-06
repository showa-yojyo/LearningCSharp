using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoSkipWhile
    {
        /// <summary>
        /// SkipWhile �͎w������𖞂����v�f��擪����̂ĂĂ����B
        /// </summary>
        [TestMethod]
        public void TestSkipWhile()
        {
            int[] a = { 1, 10, 100, 200, 20, 2, -40, -4 };

            var q = a.SkipWhile(i => i != 100);
            Assert.AreEqual(q.First(), 100);
            Assert.AreEqual(q.Last(), -4);
        }
    }
}
