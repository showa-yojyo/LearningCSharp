using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoJoin
    {
        private class ClassDerivation
        {
            public string Name
            {
                get;
                set;
            }

            public string BaseClassName
            {
                get;
                set;
            }
        };

        private class ClassAuthor
        {
            public string Name
            {
                get;
                set;
            }

            public string AuthorName
            {
                get;
                set;
            }
        };

        /// <summary>
        /// GroupJoin から型をコピーしてテスト。
        /// </summary>
        [TestMethod]
        public void TestJoin()
        {
            var source1 = new[]
            {
                new ClassDerivation
                {
                    Name = "FilterDialog",
                    BaseClassName = "OTBaseForm",
                },
                new ClassDerivation
                {
                    Name = "InputDialog",
                    BaseClassName = "OTBaseForm",
                },
                new ClassDerivation
                {
                    Name = "UserInfoDialog",
                    BaseClassName = "OTBaseForm",
                },
                new ClassDerivation
                {
                    Name = "IntervalChangedEventArgs",
                    BaseClassName = "EventArgs",
                },
                new ClassDerivation
                {
                    Name = "NotifyCallbackEventArgs",
                    BaseClassName = "EventArgs",
                },
                new ClassDerivation
                {
                    Name = "ThumbnailDoubleClickEventArgs",
                    BaseClassName = "EventArgs",
                },
                new ClassDerivation
                {
                    Name = "InvalidImageException",
                    BaseClassName = "Exception",
                },
                new ClassDerivation
                {
                    Name = "TabException",
                    BaseClassName = "Exception",
                },
                new ClassDerivation
                {
                    Name = "WebApiException",
                    BaseClassName = "Exception",
                },
            };

            var source2 = new[]
            {
                new ClassAuthor
                {
                    Name = "Exception",
                    AuthorName = ".NET",
                },
                new ClassAuthor
                {
                    Name = "OTBaseForm",
                    AuthorName = "OpenTween",
                },
                new ClassAuthor
                {
                    Name = "ICommand",
                    AuthorName = "unknown",
                },
                new ClassAuthor
                {
                    Name = "IDisposable",
                    AuthorName = "unknown",
                },
                new ClassAuthor
                {
                    Name = "IObservable",
                    AuthorName = "unknown",
                },
                new ClassAuthor
                {
                    Name = "EventArgs",
                    AuthorName = ".NET",
                },
            };

            var result = source2.Join(
                source1,
                authorInfo => authorInfo.Name,
                classInfo => classInfo.BaseClassName,
                (a, c) => new
                {
                    Author = a.AuthorName,
                    BaseClass = a.Name, // == c.BaseClassName
                    Child = c.Name,
                });

            Assert.IsFalse(result.Any(i => i.Author == "unknown"));
            Assert.AreEqual(result.Count(i => i.Author == ".NET" && i.BaseClass == "Exception"), 3);
            Assert.AreEqual(result.Count(i => i.Author == ".NET" && i.BaseClass == "EventArgs"), 3);
            Assert.AreEqual(result.Count(i => i.Author == "OpenTween" && i.BaseClass == "OTBaseForm"), 3);
        }
    }
}
