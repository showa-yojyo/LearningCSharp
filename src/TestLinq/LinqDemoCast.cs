using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoCast
    {
        /// <summary>
        /// OfType êÑèßÅB
        /// </summary>
        [TestMethod]
        public void TestCast()
        {
            var source = new List<object>
            {
                0.0, 0.1, 0.2, 0.3, 0.4,
            };

            var result = source.Cast<double>()
                .Zip(source, (first, second) => Math.Abs(first - (double)second));
            Assert.IsTrue(result.All(i => i < 1e-8));
        }

        /// <summary>
        /// OfType êÑèßÅB
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void TestCastException()
        {
            var source1 = Enumerable.Range(0, 10).Cast<double>();

            source1.First();
        }
    }
}
