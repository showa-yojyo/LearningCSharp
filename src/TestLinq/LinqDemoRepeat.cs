using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoRepeat
    {
        /// <summary>
        /// Repeat ��p���Ē��ڃR���N�V�����e�v�f�� new ���邱�Ƃ͂ł��Ȃ����B
        /// </summary>
        [TestMethod]
        public void TestRepeat()
        {
            var count = 10;
            var element = 777;
            var q = Enumerable.Repeat(element, count);

            Assert.IsTrue(q.All(i => i == element));
            Assert.AreEqual(q.Count(), count);
        }

        /// <summary>
        /// Repeat ��p���Ē��ڃR���N�V�����e�v�f�� new ���邱�Ƃ͂ł��Ȃ����B
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRepeatOutOfRangeException()
        {
            var count = -10;
            var element = 777;
            Enumerable.Repeat(element, count);
        }
    }
}
