using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoAny
    {
        [TestMethod]
        public void TestAny()
        {
            var str = "                ";
            Assert.IsTrue(str.Any(c => c == ' ' || c == '　'));
        }

        /// <summary>
        /// 空コレクションに対する Any は常に偽。
        /// </summary>
        [TestMethod]
        public void TestAnyEmptySeq()
        {
            Assert.IsFalse("".Any(c => c == ' ' || c == '　'));
        }
    }
}
