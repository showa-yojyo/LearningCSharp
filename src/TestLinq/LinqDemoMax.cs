using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    /// <summary>
    /// Min も参照。
    /// </summary>
    [TestClass]
    public class LinqDemoMax
    {
        /// <summary>
        /// 一応動作を見ておく。
        /// </summary>
        [TestMethod]
        public void TestMax()
        {
            var q = Enumerable.Range(0, 6);
            Assert.AreEqual(q.Max(), 5);
        }

        /// <summary>
        /// 空範囲のときの動作は気をつける。
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMaxNullSeq()
        {
            var q = Enumerable.Range(0, 0);
            q.Max();
        }
    }
}
