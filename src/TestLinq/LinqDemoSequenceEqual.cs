using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoSequenceEqual
    {
        /// <summary>
        /// C++ STL ÇÃ std::equal ÇÃÇÊÇ§Ç»Ç‡ÇÃÅB
        /// </summary>
        [TestMethod]
        public void TestSequenceEqual()
        {
            var source = Enumerable.Range(0, 100);

            Assert.IsTrue(source.SequenceEqual(source));
            Assert.IsFalse(source.SequenceEqual(source.Reverse()));
            Assert.IsTrue(source.SequenceEqual(source.Reverse().Reverse()));
        }
    }
}
