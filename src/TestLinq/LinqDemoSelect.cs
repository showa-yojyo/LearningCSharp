using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoSelect
    {
        /// <summary>
        /// 基本中の基本。
        /// </summary>
        [TestMethod]
        public void TestSelect()
        {
            var source = "ABC";
            var result = source.Select(c => char.ToLower(c));

            Assert.AreEqual(result.ElementAt(0), 'a');
            Assert.AreEqual(result.ElementAt(1), 'b');
            Assert.AreEqual(result.ElementAt(2), 'c');
        }

        /// <summary>
        /// Select も添字版がある。
        /// </summary>
        [TestMethod]
        public void TestSelectIndexed()
        {
            var source = "ABC";
            var result = source.Select(
                (c, i) => new string(c, i));

            Assert.AreEqual(result.ElementAt(0), "");
            Assert.AreEqual(result.ElementAt(1), "B");
            Assert.AreEqual(result.ElementAt(2), "CC");
        }
    }
}