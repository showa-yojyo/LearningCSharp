using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoRange
    {
        /// <summary>
        /// Range �͊�{�B
        /// </summary>
        [TestMethod]
        public void TestRange()
        {
            int start = 0;
            int count = 10;

            var source = Enumerable.Range(start, count);
            Assert.AreEqual(source.Count(), count);
            Assert.AreEqual(source.First(), start);
            Assert.AreEqual(source.Last(), count - start - 1);
        }

        /// <summary>
        /// count �p�����[�^�[��ςȒl�ɂ��邭�炢������O�𓊂���������@�͂Ȃ��B
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRangeException()
        {
            Enumerable.Range(0, -10);
        }
    }
}
