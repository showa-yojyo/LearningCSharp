using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoAverage
    {
        /// <summary>
        /// �����z��� Average ���Ƃ�Ƃǂ��Ȃ邩�B
        /// </summary>
        [TestMethod]
        public void TestAverage()
        {
            int[] a = { 0, 1, 2, 3, 4, 5 };

            var mean = a.Average();

            // double ���m�̔�r�ɂȂ�AAreEqual �ł��܂��]�����Ă����B
            Assert.AreEqual(mean, 2.5);
        }
    }
}
