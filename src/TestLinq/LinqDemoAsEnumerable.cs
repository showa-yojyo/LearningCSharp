using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoAsEnumerable
    {
        /// <summary>
        /// AsEnumerable はこういう使われ方は想定していないはず。
        /// </summary>
        [TestMethod]
        public void TestAsEnumerable()
        {
            int[] source = { 0, 1, 2, 3, 4, 5 };
            var result = source.AsEnumerable();

            Assert.IsTrue(source.SequenceEqual(result));
        }
    }
}
