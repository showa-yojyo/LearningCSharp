using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoOfType
    {
        /// <summary>
        /// OfType êÑèßÅB
        /// </summary>
        [TestMethod]
        public void TestOfType()
        {
            var source = new List<object>
            {
                0.0, 0.1, 0.2, 0.3, 0.4,
                "a", "b", "c",
            };

            var result = source.OfType<double>()
                .Zip(source, (first, second) => Math.Abs(first - (double)second));
            Assert.IsTrue(result.All(i => i < 1e-8));
        }

        /// <summary>
        /// OfType êÑèßÅB
        /// </summary>
        [TestMethod]
        public void TestOfTypeSafe()
        {
            var source = Enumerable.Range(0, 10).OfType<double>();

            Assert.IsFalse(source.Any());
        }
    }
}