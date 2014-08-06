using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoAny
    {
        [TestMethod]
        public void TestAny()
        {
            var str = "                ";
            Assert.IsTrue(str.Any(c => c == ' ' || c == '�@'));
        }

        /// <summary>
        /// ��R���N�V�����ɑ΂��� Any �͏�ɋU�B
        /// </summary>
        [TestMethod]
        public void TestAnyEmptySeq()
        {
            Assert.IsFalse("".Any(c => c == ' ' || c == '�@'));
        }
    }
}
