using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    /// <summary>
    /// Max も参照。
    /// </summary>
    [TestClass]
    public class LinqDemoMin
    {
        /// <summary>
        /// 一応動作を見ておく。
        /// </summary>
        [TestMethod]
        public void TestMin()
        {
            var q = Enumerable.Range(0, 6);
            Assert.AreEqual(q.Min(), 0);
        }

        /// <summary>
        /// 空範囲のときの動作は気をつける。
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMinNullSeq()
        {
            var q = Enumerable.Range(0, 0);
            q.Min();
        }
    }
}
