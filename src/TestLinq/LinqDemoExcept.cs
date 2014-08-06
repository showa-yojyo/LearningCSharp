using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoExcept
    {
        /// <summary>
        /// IEnumerable.Except performs as the EXCEPT operator of ANSI SQL.
        /// </summary>
        [TestMethod]
        public void TestExcept()
        {
            var source = Enumerable.Range(0, 100); // [0, 100)
            var result = source.Except(Enumerable.Range(50, 20)); // [50, 70)

            Assert.IsTrue(result.Contains(0));
            Assert.IsFalse(result.Contains(50));
            Assert.IsTrue(result.Contains(70));
            Assert.IsTrue(result.Contains(99));
        }
    }
}
