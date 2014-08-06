using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoSum
    {
        [TestMethod]
        public void TestSum()
        {
            var q = Enumerable.Range(0, 100);

            Assert.AreEqual(q.Sum(), 5050 - 100);
        }

        /// <summary>
        /// ‹ó”ÍˆÍ‚Ì˜a‚Íƒ[ƒB
        /// </summary>
        [TestMethod]
        public void TestSumNullSeq()
        {
            var q = Enumerable.Range(0, 0);

            Assert.AreEqual(q.Sum(), 0);
        }
    }
}
