using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoLast
    {
        /// <summary>
        /// 基本。要素の末尾にアクセスする。
        /// </summary>
        [TestMethod]
        public void TestLast()
        {
            var source = Enumerable.Range(0, 10);
            Assert.AreEqual(source.Last(), 9);
        }

        /// <summary>
        /// Last の適用条件は空範囲でないこと。
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestLastInvalidOpCase()
        {
            var source = Enumerable.Range(0, 0);
            source.Last();
        }
    }
}
