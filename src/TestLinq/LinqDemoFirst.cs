using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoFirst
    {
        /// <summary>
        /// 基本。要素の先頭にアクセスする。
        /// </summary>
        [TestMethod]
        public void TestFirst()
        {
            var source = Enumerable.Range(0, 10);
            Assert.AreEqual(source.First(), 0);
        }

        /// <summary>
        /// First の適用条件は空範囲でないこと。
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestFirstInvalidOpCase()
        {
            var source = Enumerable.Range(0, 0);
            source.First();
        }
    }
}
