using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    /// <summary>
    /// Min ���Q�ƁB
    /// </summary>
    [TestClass]
    public class LinqDemoMax
    {
        /// <summary>
        /// �ꉞ��������Ă����B
        /// </summary>
        [TestMethod]
        public void TestMax()
        {
            var q = Enumerable.Range(0, 6);
            Assert.AreEqual(q.Max(), 5);
        }

        /// <summary>
        /// ��͈͂̂Ƃ��̓���͋C������B
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMaxNullSeq()
        {
            var q = Enumerable.Range(0, 0);
            q.Max();
        }
    }
}
