using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoSingleOrDefault
    {
        /// <summary>
        /// 要素の個数が 0 または 1 である
        /// or 述語の条件を満たす要素が 0 または 1 であるかを調べる。
        /// </summary>
        [TestMethod]
        public void TestSingleOrDefault()
        {
            var source = Enumerable.Range(0, 100);

            // 存在する場合は Single と同じ挙動。
            Assert.AreEqual(source.SingleOrDefault(i => i == 17), 17);
        }

        /// <summary>
        /// 要素の個数が 0 または 1 である
        /// or 述語の条件を満たす要素が 0 または 1 であるかを調べる。
        /// </summary>
        [TestMethod]
        public void TestSingleOrDefaultEmptyCase()
        {
            var source = Enumerable.Range(0, 0);

            // 存在しない場合はこうする。
            Assert.AreEqual(source.SingleOrDefault(i => i == -17), 0);
        }

        /// <summary>
        /// SingleOrDefault も要素が複数個あると例外送出。
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestSingleOrDefaultFailureMultipleCase()
        {
            var source = Enumerable.Range(0, 100);
            source.SingleOrDefault(i => i % 7 == 0);
        }
    }
}
