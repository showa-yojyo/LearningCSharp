using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoSelectMany
    {
        /// <summary>
        /// Use SelectMany() as flatten() in NumPy.
        /// </summary>
        [TestMethod]
        public void TestSelectMany()
        {
            var source = new[]
            {
                new { Number=1, Word=new List<string>{"one", "��"}, },
                new { Number=10, Word=new List<string>{"ten", "�\"}, },
                new { Number=100, Word=new List<string>{"hundred", "�S"}, },
                new { Number=1000, Word=new List<string>{"thousand", "��"}, },
            };

            // SelectMany returns IEnumerable<string>
            var result = source.SelectMany(item => item.Word);

            Assert.AreEqual(result.Count(), 8);
            Assert.AreEqual(result.ElementAt(0), "one");
            Assert.AreEqual(result.ElementAt(1), "��");
            Assert.AreEqual(result.ElementAt(2), "ten");
            Assert.AreEqual(result.ElementAt(3), "�\");
            Assert.AreEqual(result.ElementAt(4), "hundred");
            Assert.AreEqual(result.ElementAt(5), "�S");
            Assert.AreEqual(result.ElementAt(6), "thousand");
            Assert.AreEqual(result.ElementAt(7), "��");
        }

        /// <summary>
        /// (item, index) version
        /// </summary>
        [TestMethod]
        public void TestSelectManyIndexed()
        {
            var source = new[]
            {
                new { Number=1, Word=new List<string>{"one", "��"}, },
                new { Number=10, Word=new List<string>{"ten", "�\"}, },
                new { Number=100, Word=new List<string>{"hundred", "�S"}, },
                new { Number=1000, Word=new List<string>{"thousand", "��"}, },
            };

            var result = source.SelectMany(
                (item, index) => item.Word.Select(
                    w => string.Format("{0}:{1}.", index, w)));

            Assert.AreEqual(result.Count(), 8);
            Assert.AreEqual(result.ElementAt(0), "0:one.");
            Assert.AreEqual(result.ElementAt(1), "0:��.");
            Assert.AreEqual(result.ElementAt(2), "1:ten.");
            Assert.AreEqual(result.ElementAt(3), "1:�\.");
            Assert.AreEqual(result.ElementAt(4), "2:hundred.");
            Assert.AreEqual(result.ElementAt(5), "2:�S.");
            Assert.AreEqual(result.ElementAt(6), "3:thousand.");
            Assert.AreEqual(result.ElementAt(7), "3:��.");
        }

        /// <summary>
        /// (item, member) version
        /// </summary>
        [TestMethod]
        public void TestSelectManyMember()
        {
            var source = new[]
            {
                new { Number=1, Word=new List<string>{"one", "��"}, },
                new { Number=10, Word=new List<string>{"ten", "�\"}, },
                new { Number=100, Word=new List<string>{"hundred", "�S"}, },
                new { Number=1000, Word=new List<string>{"thousand", "��"}, },
            };

            var result = source.SelectMany(
                item => item.Word,
                (item, word) => string.Format("{1} is {0}.", item.Number, word));

            Assert.AreEqual(result.Count(), 8);
            Assert.AreEqual(result.ElementAt(0), "one is 1.");
            Assert.AreEqual(result.ElementAt(1), "�� is 1.");
            Assert.AreEqual(result.ElementAt(2), "ten is 10.");
            Assert.AreEqual(result.ElementAt(3), "�\ is 10.");
            Assert.AreEqual(result.ElementAt(4), "hundred is 100.");
            Assert.AreEqual(result.ElementAt(5), "�S is 100.");
            Assert.AreEqual(result.ElementAt(6), "thousand is 1000.");
            Assert.AreEqual(result.ElementAt(7), "�� is 1000.");
        }
    }
}
