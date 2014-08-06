using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoSingleOrDefault
    {
        /// <summary>
        /// �v�f�̌��� 0 �܂��� 1 �ł���
        /// or �q��̏����𖞂����v�f�� 0 �܂��� 1 �ł��邩�𒲂ׂ�B
        /// </summary>
        [TestMethod]
        public void TestSingleOrDefault()
        {
            var source = Enumerable.Range(0, 100);

            // ���݂���ꍇ�� Single �Ɠ��������B
            Assert.AreEqual(source.SingleOrDefault(i => i == 17), 17);
        }

        /// <summary>
        /// �v�f�̌��� 0 �܂��� 1 �ł���
        /// or �q��̏����𖞂����v�f�� 0 �܂��� 1 �ł��邩�𒲂ׂ�B
        /// </summary>
        [TestMethod]
        public void TestSingleOrDefaultEmptyCase()
        {
            var source = Enumerable.Range(0, 0);

            // ���݂��Ȃ��ꍇ�͂�������B
            Assert.AreEqual(source.SingleOrDefault(i => i == -17), 0);
        }

        /// <summary>
        /// SingleOrDefault ���v�f����������Ɨ�O���o�B
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestSingleOrDefaultFailureMultipleCase()
        {
            var source = Enumerable.Range(0, 100);
            source.SingleOrDefault(i => i % 7 == 0);
        }
    }
}
