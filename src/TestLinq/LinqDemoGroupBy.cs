using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoGroupBy
    {
        /// <summary>
        /// GroupBy
        /// </summary>
        [TestMethod]
        public void TestGroupBy()
        {
            var source = new[]
            {
                new { Number=1, Word="one", },
                new { Number=10, Word="ten", },
                new { Number=100, Word="hundred", },
                new { Number=1000, Word="thousand", },
                new { Number=1, Word="ˆê", },
                new { Number=10, Word="\", },
                new { Number=100, Word="•S", },
                new { Number=1000, Word="ç", },
            };

            var result = source.GroupBy(item => item.Number);

            Assert.AreEqual(result.Count(), 4);
            Assert.AreEqual(result.ElementAt(0).Key, 1);
            Assert.AreEqual(result.ElementAt(1).Key, 10);
            Assert.AreEqual(result.ElementAt(2).Key, 100);
            Assert.AreEqual(result.ElementAt(3).Key, 1000);
        }

        /// <summary>
        /// GroupBy with selector version
        /// </summary>
        [TestMethod]
        public void TestGroupByWithSelector()
        {
            var source = new[]
            {
                new { Number=1, Word="one", },
                new { Number=10, Word="ten", },
                new { Number=100, Word="hundred", },
                new { Number=1000, Word="thousand", },
                new { Number=1, Word="ˆê", },
                new { Number=10, Word="\", },
                new { Number=100, Word="•S", },
                new { Number=1000, Word="ç", },
            };

            var result = source.GroupBy(
                item => item.Number,
                item => item.Word);

            Assert.AreEqual(result.Count(), 4);
            Assert.AreEqual(result.ElementAt(0).Key, 1);
            Assert.AreEqual(result.ElementAt(0).Count(), 2);
            Assert.IsTrue(result.ElementAt(0).Contains("one"));
            Assert.IsTrue(result.ElementAt(0).Contains("ˆê"));
            // ...
        }
    }
}
