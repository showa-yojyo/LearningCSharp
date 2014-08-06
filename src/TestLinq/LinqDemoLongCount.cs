using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoLongCount
    {
        /// <summary>
        /// LongCount �� Count �̑�e�ʃR���N�V�����ŁH
        /// </summary>
        //[TestMethod]
        //public void TestLongCountDangerous()
        //{
        //    var source = Enumerable.Repeat(0, Int32.MaxValue);
        //    var result = source.Concat(source);

        //    Assert.AreEqual(result.LongCount(), (long)Int32.MaxValue * 2);
        //}

        /// <summary>
        /// LongCount �� Count �̑�e�ʃR���N�V�����ŁH
        /// </summary>
        [TestMethod]
        public void TestLongCount()
        {
            var source = Enumerable.Repeat(0, 3);
            Assert.AreEqual(source.LongCount(), 3L);
        }
    }
}
