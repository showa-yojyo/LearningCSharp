using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoTakeWhile
    {
        /// <summary>
        /// TakeWhile ‚Íw’èğŒ‚ğ–‚½‚·—v‘f‚ğæ“ª‚©‚çE‚¤B
        /// </summary>
        [TestMethod]
        public void TestTakeWhile()
        {
            int[] a = { 1, 10, 100, 200, 20, 2, -40, -4 };

            var q = a.SkipWhile(i => i != 100).TakeWhile(i => i != -40);
            Assert.AreEqual(q.First(), 100);
            Assert.AreNotEqual(q.Last(), -40);
        }
    }
}
