using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoOrderBy
    {
        /// <summary>
        /// �P���Ȓl�̃R���N�V�����Ȃ�� Sort ���\�b�h�ŏ\���B
        /// </summary>
        [TestMethod]
        public void TestOrderBy()
        {
            var source = new[]
            {
                new { Number=1, English="one", Japanese="��", },
                new { Number=10, English="ten", Japanese="�\", },
                new { Number=100, English="hundred", Japanese="�S"},
                new { Number=1000, English="thousand", Japanese="��"},
            };

            var q1 = source.OrderBy(i => i.Number);
            Assert.AreEqual(q1.First().Number, 1);
            Assert.AreEqual(q1.Last().Number, 1000);

            var q2 = source.OrderBy(i => i.English);
            Assert.AreEqual(q2.First().English, "hundred");
            Assert.AreEqual(q2.Last().English, "thousand");
        }
    }
}
