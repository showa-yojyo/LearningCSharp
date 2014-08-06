using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoAll
    {
        [TestMethod]
        public void TestAll()
        {
            var str = "                ";
            Assert.IsTrue(str.All(c => c == ' ' || c == '　'));
        }

        /// <summary>
        /// 空コレクションに対する All は常に真らしい。
        /// </summary>
        [TestMethod]
        public void TestAllEmptySeq()
        {
            Assert.IsTrue("".All(c => c == ' ' || c == '　'));
        }
    }
}
