using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    /// <summary>
    /// Where ���t�B���^�[�Ƃ��ė��p����B
    /// </summary>
    [TestClass]
    public class LinqDemoWhere
    {
        /// <summary>
        /// ��{���̊�{�B
        /// </summary>
        [TestMethod]
        public void TestWhere()
        {
            var source = Enumerable.Range(0, 100);
            var even = source.Where(i => i % 2 == 0);

            Assert.IsTrue(even.All(i => i % 2 == 0));
        }

        /// <summary>
        /// �Y���t���o�[�W�����B
        /// </summary>
        [TestMethod]
        public void TestWhereIndexed()
        {
            var source = Enumerable.Repeat(50, 100);
            var result = source.Where(
                (val, i) => i < val);

            Assert.AreEqual(result.Count(), 50); // [50, 100)
            Assert.IsTrue(result.All(i => i == 50));
        }
    }
}
