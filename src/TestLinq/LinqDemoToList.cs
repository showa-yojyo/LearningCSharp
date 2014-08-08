using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoToList
    {
        /// <summary>
        /// 単に List にコンバートするだけ。
        /// </summary>
        [TestMethod]
        public void TestToList()
        {
            var source = Enumerable.Range(0, 10);
            var result = source.ToList();

            Assert.IsTrue(source.SequenceEqual(result));
        }

        /// <summary>
        /// 空の範囲を ToList すると、長さゼロの List を得られる。
        /// </summary>
        [TestMethod]
        public void TestToListEmptySeq()
        {
            var source = Enumerable.Repeat(0, 0);
            var result = source.ToList();

            Assert.AreEqual(result.Count, 0);
        }
    }
}
