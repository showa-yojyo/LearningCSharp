using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoToArray
    {
        /// <summary>
        /// 単に配列にコンバートするだけ。
        /// </summary>
        [TestMethod]
        public void TestToArray()
        {
            var source = Enumerable.Range(0, 10);
            var result = source.ToArray();

            Assert.IsTrue(source.SequenceEqual(result));
        }

        /// <summary>
        /// 空の範囲を ToArray すると、長さゼロの配列を得られる。
        /// </summary>
        [TestMethod]
        public void TestToArrayEmptySeq()
        {
            var source = Enumerable.Repeat(0, 0);
            var result = source.ToArray();

            Assert.AreEqual(result.Length, 0);
        }
    }
}
