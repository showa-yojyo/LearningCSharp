using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoAverage
    {
        /// <summary>
        /// ®””z—ñ‚Ì Average ‚ğ‚Æ‚é‚Æ‚Ç‚¤‚È‚é‚©B
        /// </summary>
        [TestMethod]
        public void TestAverage()
        {
            int[] a = { 0, 1, 2, 3, 4, 5 };

            var mean = a.Average();

            // double “¯m‚Ì”äŠr‚É‚È‚èAAreEqual ‚Å‚¤‚Ü‚­•]‰¿‚µ‚Ä‚­‚ê‚éB
            Assert.AreEqual(mean, 2.5);
        }
    }
}
