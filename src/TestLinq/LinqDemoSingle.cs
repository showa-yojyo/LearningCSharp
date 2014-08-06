using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoSingle
    {
        /// <summary>
        /// �v�f�̌��� 1 �ł��� or �q��̏����𖞂����v�f�� 1 �ł��邩�𒲂ׂ�B
        /// </summary>
        [TestMethod]
        public void TestSingle()
        {
            var source = Enumerable.Range(0, 100);

            Assert.AreEqual(source.Single(i => i == 17), 17);
        }

        /// <summary>
        /// ��R���N�V�����ɑ΂��� Single �͗�O���o�B
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestSingleFailureEmptyCase()
        {
            var source = Enumerable.Range(0, 0);
            source.Single(i => i == 17);
        }

        /// <summary>
        /// Single �͗v�f����������Ɨ�O���o�B
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestSingleFailureMultipleCase()
        {
            var source = Enumerable.Range(0, 100);
            source.Single();
        }
    }
}
