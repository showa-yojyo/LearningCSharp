using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoFirst
    {
        /// <summary>
        /// ��{�B�v�f�̐擪�ɃA�N�Z�X����B
        /// </summary>
        [TestMethod]
        public void TestFirst()
        {
            var source = Enumerable.Range(0, 10);
            Assert.AreEqual(source.First(), 0);
        }

        /// <summary>
        /// First �̓K�p�����͋�͈͂łȂ����ƁB
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestFirstInvalidOpCase()
        {
            var source = Enumerable.Range(0, 0);
            source.First();
        }
    }
}
