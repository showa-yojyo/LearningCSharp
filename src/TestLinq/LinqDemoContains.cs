using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoContains
    {
        /// <summary>
        /// äÓñ{íÜÇÃäÓñ{ÅB
        /// </summary>
        [TestMethod]
        public void TestContains()
        {
            var q = Enumerable.Range(0, 100);
            Assert.IsTrue(q.Contains(17));
            Assert.IsFalse(q.Contains(-17));
        }
    }
}
