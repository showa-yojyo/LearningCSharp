using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoSingle
    {
        /// <summary>
        /// 要素の個数が 1 である or 述語の条件を満たす要素が 1 であるかを調べる。
        /// </summary>
        [TestMethod]
        public void TestSingle()
        {
            var source = Enumerable.Range(0, 100);

            Assert.AreEqual(source.Single(i => i == 17), 17);
        }

        /// <summary>
        /// 空コレクションに対する Single は例外送出。
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestSingleFailureEmptyCase()
        {
            var source = Enumerable.Range(0, 0);
            source.Single(i => i == 17);
        }

        /// <summary>
        /// Single は要素が複数個あると例外送出。
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestSingleFailureMultipleCase()
        {
            var source = Enumerable.Range(0, 100);
            source.Single();
        }
    }
}
