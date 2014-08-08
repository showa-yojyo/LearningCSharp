using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoToArray
    {
        /// <summary>
        /// �P�ɔz��ɃR���o�[�g���邾���B
        /// </summary>
        [TestMethod]
        public void TestToArray()
        {
            var source = Enumerable.Range(0, 10);
            var result = source.ToArray();

            Assert.IsTrue(source.SequenceEqual(result));
        }

        /// <summary>
        /// ��͈̔͂� ToArray ����ƁA�����[���̔z��𓾂���B
        /// </summary>
        [TestMethod]
        public void TestToArrayEmptySeq()
        {
            var source = Enumerable.Repeat(0, 0);
            var result = source.ToArray();

            Assert.AreEqual(result.Length, 0);
        }
    }
}
