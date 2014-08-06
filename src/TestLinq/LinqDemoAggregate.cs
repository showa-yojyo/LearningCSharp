using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoAggregate
    {
        /// <summary>
        /// StringBuilder.AppendLine �� Aggregate ����Ƃǂ��Ȃ邩�B
        /// </summary>
        [TestMethod]
        public void TestAggregate()
        {
            int[] a = { 5, 4, 3, 2, 1 };
            var s = a.Aggregate(
                new StringBuilder(),
                (builder, log) => builder.AppendLine(log.ToString())).ToString();

            Assert.AreEqual(
                s.TrimEnd(),
                string.Join(Environment.NewLine, a));
        }
    }
}
