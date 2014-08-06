using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoDistinct
    {
        /// <summary>
        /// C++ �ł����� std::unique �����A�\�[�g�ς݂ł���K�v�͂Ȃ��B
        /// </summary>
        [TestMethod]
        public void TestDistinct()
        {
            var source = Enumerable.Repeat("X", 10)
                .Concat(Enumerable.Repeat("Y", 10))
                .Concat(Enumerable.Repeat("Z", 10))
                .Concat(Enumerable.Repeat("Y", 10))
                .Concat(Enumerable.Repeat("X", 10));
            var result = source.Distinct();

            Assert.AreEqual(result.Count(), 3);
            Assert.IsTrue(result.All(c => c == "X" || c == "Y" || c == "Z"));
        }
    }
}
