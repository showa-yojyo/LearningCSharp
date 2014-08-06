using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoLast
    {
        /// <summary>
        /// ��{�B�v�f�̖����ɃA�N�Z�X����B
        /// </summary>
        [TestMethod]
        public void TestLast()
        {
            var source = Enumerable.Range(0, 10);
            Assert.AreEqual(source.Last(), 9);
        }

        /// <summary>
        /// Last �̓K�p�����͋�͈͂łȂ����ƁB
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestLastInvalidOpCase()
        {
            var source = Enumerable.Range(0, 0);
            source.Last();
        }
    }
}
