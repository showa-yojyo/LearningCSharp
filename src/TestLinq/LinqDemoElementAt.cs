using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoElementAt
    {
        /// <summary>
        /// 利用することはないと思われる。
        /// </summary>
        [TestMethod]
        public void TestElementAt()
        {
            var source = Enumerable.Range(0, 100);
            Assert.AreEqual(source.ElementAt(44), 44);
        }

        /// <summary>
        /// 利用することはないと思われる。
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestElementAtOutOfRangeCase()
        {
            var source = Enumerable.Range(0, 100);
            source.ElementAt(-44);
        }
    }
}
