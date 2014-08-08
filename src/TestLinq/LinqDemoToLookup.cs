using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoToLookup
    {
        private class Dummy
        {
            public int Id
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }
        };

        /// <summary>
        /// ToLookup は少々くせがある。
        /// </summary>
        [TestMethod]
        public void TestToLookup()
        {
            var source = new[]
            {
                new Dummy{ Id=570, Name="apple",},
                new Dummy{ Id=773, Name="banana",},
            };

            var result = source.ToLookup(i => i.Id);

            Assert.IsNotNull(result[570].Single(i => i.Name == "apple"));
            Assert.IsNotNull(result[773].Single(i => i.Name == "banana"));
        }

        /// <summary>
        /// 空の列を ToLookup しても問題ない。
        /// </summary>
        [TestMethod]
        public void TestToLookupEmptySeq()
        {
            var source = Enumerable.Repeat(new Dummy
            {
                Id = 0,
                Name = "",
            }, 0);
            var result = source.ToLookup(i => i.Id);

            Assert.IsFalse(result.Any());
        }

        /// <summary>
        /// キー重複を引き起こすのも問題ない。
        /// </summary>
        [TestMethod]
        public void TestToLookupMultiset()
        {
            var source = Enumerable.Repeat(new Dummy
            {
                Id = 0,
                Name = "",
            }, 10);

            var result = source.ToLookup(i => i.Id);
            Assert.AreEqual(result[0].Count(), source.Count());
        }
    }
}
