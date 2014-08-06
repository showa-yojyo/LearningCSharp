using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    /// <summary>
    /// Max ���Q�ƁB
    /// </summary>
    [TestClass]
    public class LinqDemoMin
    {
        /// <summary>
        /// �ꉞ��������Ă����B
        /// </summary>
        [TestMethod]
        public void TestMin()
        {
            var q = Enumerable.Range(0, 6);
            Assert.AreEqual(q.Min(), 0);
        }

        /// <summary>
        /// ��͈͂̂Ƃ��̓���͋C������B
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMinNullSeq()
        {
            var q = Enumerable.Range(0, 0);
            q.Min();
        }
    }
}
