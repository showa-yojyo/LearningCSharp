using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoToList
    {
        /// <summary>
        /// �P�� List �ɃR���o�[�g���邾���B
        /// </summary>
        [TestMethod]
        public void TestToList()
        {
            var source = Enumerable.Range(0, 10);
            var result = source.ToList();

            Assert.IsTrue(source.SequenceEqual(result));
        }

        /// <summary>
        /// ��͈̔͂� ToList ����ƁA�����[���� List �𓾂���B
        /// </summary>
        [TestMethod]
        public void TestToListEmptySeq()
        {
            var source = Enumerable.Repeat(0, 0);
            var result = source.ToList();

            Assert.AreEqual(result.Count, 0);
        }
    }
}
