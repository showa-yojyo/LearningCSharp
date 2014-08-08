using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoToDictionary
    {
        /// <summary>
        /// ToDictionary �͏��X����������B
        /// </summary>
        [TestMethod]
        public void TestToDictionary()
        {
            var source = new[]
            {
                new { Id=570, Name="apple",},
                new { Id=773, Name="banana",},
            };

            var result = source.ToDictionary(i => i.Id);

            Assert.AreEqual(result[570].Name, "apple");
            Assert.AreEqual(result[773].Name, "banana");
        }

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
        /// ��̗�� ToDictionary ���Ă����Ȃ��B
        /// </summary>
        [TestMethod]
        public void TestToDictionaryEmptySeq()
        {
            var source = Enumerable.Repeat(new Dummy
            {
                Id = 0,
                Name = "",
            }, 0);
            var result = source.ToDictionary(i => i.Id);

            Assert.IsFalse(result.Any());
        }

        /// <summary>
        /// �L�[�d���������N�����̂͗�O�B
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestToDictionaryArgumentException()
        {
            var source = Enumerable.Repeat(new Dummy
            {
                Id = 0,
                Name = "",
            }, 10);
            
            source.ToDictionary(i => i.Id);
        }
    }
}
