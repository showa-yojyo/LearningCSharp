using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoAll
    {
        [TestMethod]
        public void TestAll()
        {
            var str = "                ";
            Assert.IsTrue(str.All(c => c == ' ' || c == '�@'));
        }

        /// <summary>
        /// ��R���N�V�����ɑ΂��� All �͏�ɐ^�炵���B
        /// </summary>
        [TestMethod]
        public void TestAllEmptySeq()
        {
            Assert.IsTrue("".All(c => c == ' ' || c == '�@'));
        }
    }
}
