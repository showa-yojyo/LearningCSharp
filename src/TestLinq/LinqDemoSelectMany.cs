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
                new { Number=1, Word=new List<string>{"one", "àÍ"}, },
                new { Number=10, Word=new List<string>{"ten", "è\"}, },
                new { Number=100, Word=new List<string>{"hundred", "ïS"}, },
                new { Number=1000, Word=new List<string>{"thousand", "êÁ"}, },
            };

            // SelectMany returns IEnumerable<string>
            var result = source.SelectMany(item => item.Word);

            Assert.AreEqual(result.Count(), 8);
            Assert.AreEqual(result.ElementAt(0), "one");
            Assert.AreEqual(result.ElementAt(1), "àÍ");
            Assert.AreEqual(result.ElementAt(2), "ten");
            Assert.AreEqual(result.ElementAt(3), "è\");
            Assert.AreEqual(result.ElementAt(4), "hundred");
            Assert.AreEqual(result.ElementAt(5), "ïS");
            Assert.AreEqual(result.ElementAt(6), "thousand");
            Assert.AreEqual(result.ElementAt(7), "êÁ");
        }

        /// <summary>
        /// (item, index) version
        /// </summary>
        [TestMethod]
        public void TestSelectManyIndexed()
        {
            var source = new[]
            {
                new { Number=1, Word=new List<string>{"one", "àÍ"}, },
                new { Number=10, Word=new List<string>{"ten", "è\"}, },
                new { Number=100, Word=new List<string>{"hundred", "ïS"}, },
                new { Number=1000, Word=new List<string>{"thousand", "êÁ"}, },
            };

            var result = source.SelectMany(
                (item, index) => item.Word.Select(
                    w => string.Format("{0}:{1}.", index, w)));

            Assert.AreEqual(result.Count(), 8);
            Assert.AreEqual(result.ElementAt(0), "0:one.");
            Assert.AreEqual(result.ElementAt(1), "0:àÍ.");
            Assert.AreEqual(result.ElementAt(2), "1:ten.");
            Assert.AreEqual(result.ElementAt(3), "1:è\.");
            Assert.AreEqual(result.ElementAt(4), "2:hundred.");
            Assert.AreEqual(result.ElementAt(5), "2:ïS.");
            Assert.AreEqual(result.ElementAt(6), "3:thousand.");
            Assert.AreEqual(result.ElementAt(7), "3:êÁ.");
        }

        /// <summary>
        /// (item, member) version
        /// </summary>
        [TestMethod]
        public void TestSelectManyMember()
        {
            var source = new[]
            {
                new { Number=1, Word=new List<string>{"one", "àÍ"}, },
                new { Number=10, Word=new List<string>{"ten", "è\"}, },
                new { Number=100, Word=new List<string>{"hundred", "ïS"}, },
                new { Number=1000, Word=new List<string>{"thousand", "êÁ"}, },
            };

            var result = source.SelectMany(
                item => item.Word,
                (item, word) => string.Format("{1} is {0}.", item.Number, word));

            Assert.AreEqual(result.Count(), 8);
            Assert.AreEqual(result.ElementAt(0), "one is 1.");
            Assert.AreEqual(result.ElementAt(1), "àÍ is 1.");
            Assert.AreEqual(result.ElementAt(2), "ten is 10.");
            Assert.AreEqual(result.ElementAt(3), "è\ is 10.");
            Assert.AreEqual(result.ElementAt(4), "hundred is 100.");
            Assert.AreEqual(result.ElementAt(5), "ïS is 100.");
            Assert.AreEqual(result.ElementAt(6), "thousand is 1000.");
            Assert.AreEqual(result.ElementAt(7), "êÁ is 1000.");
        }
    }
}
