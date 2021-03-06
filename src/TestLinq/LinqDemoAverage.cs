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
        /// 整数配列の Average をとるとどうなるか。
        /// </summary>
        [TestMethod]
        public void TestAverage()
        {
            int[] a = { 0, 1, 2, 3, 4, 5 };

            var mean = a.Average();

            // double 同士の比較になり、AreEqual でうまく評価してくれる。
            Assert.AreEqual(mean, 2.5);
        }
    }
}
