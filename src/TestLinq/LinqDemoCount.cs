using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoCount
    {
        /// <summary>
        /// Count �͒P�ɗv�f����Ԃ����̂ƁA�q��w��ł�����B
        /// </summary>
        [TestMethod]
        public void TestCount()
        {
            int[] a = { 0, 1, 2, 3, 4, 5 };

            Assert.AreEqual(a.Count(), a.Length);
            Assert.AreEqual(a.Count(i => i % 3 == 0), 2);
        }
    }
}
