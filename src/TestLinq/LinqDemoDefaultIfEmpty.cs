using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoDefaultIfEmpty
    {
        /// <summary>
        /// デフォルト値がわかりにくいときに利用。
        /// </summary>
        [TestMethod]
        public void TestDefaultIfEmpty()
        {
            string[] target = { "apple", "banana", "cargo", "ddd" };
            var result1 = target.Where(s => "www.example.com/index.php".StartsWith(s))
                .DefaultIfEmpty(string.Empty)
                .First();

            Assert.IsTrue(string.IsNullOrEmpty(result1));

            var result2 = target.Where(s => "banana.com".StartsWith(s))
                .DefaultIfEmpty(string.Empty)
                .First();
            Assert.AreEqual(result2, "banana");
        }
    }
}
