using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoConcat
    {
        /// <summary>
        /// UNION ALL
        /// </summary>
        [TestMethod]
        public void TestConcat()
        {
            var source1 = new[]
            {
                new { Number=1, Word="one", },
                new { Number=10, Word="ten", },
                new { Number=100, Word="hundred", },
                new { Number=1000, Word="thousand", },
            };

            var source2 = new[]
            {
                new { Number=1, Word="àÍ", },
                new { Number=10, Word="è\", },
                new { Number=100, Word="ïS", },
                new { Number=1000, Word="êÁ", },
            };

            var result = source1.Concat(source2);

            Assert.IsTrue(source1.SequenceEqual(result.Take(source1.Length)));
            Assert.IsTrue(source2.SequenceEqual(result.Skip(source1.Length)));
        }
    }
}
