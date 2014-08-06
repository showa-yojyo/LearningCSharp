using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoRepeat
    {
        /// <summary>
        /// Repeat を用いて直接コレクション各要素を new することはできなそう。
        /// </summary>
        [TestMethod]
        public void TestRepeat()
        {
            var count = 10;
            var element = 777;
            var q = Enumerable.Repeat(element, count);

            Assert.IsTrue(q.All(i => i == element));
            Assert.AreEqual(q.Count(), count);
        }

        /// <summary>
        /// Repeat を用いて直接コレクション各要素を new することはできなそう。
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRepeatOutOfRangeException()
        {
            var count = -10;
            var element = 777;
            Enumerable.Repeat(element, count);
        }
    }
}
