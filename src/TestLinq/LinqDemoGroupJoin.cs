using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqDemo
{
    [TestClass]
    public class LinqDemoGroupJoin
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
        /// GroupJoin ÇÕó·ÇçlÇ¶ÇÈÇÃÇ™ìÔÇµÇ¢ÅB
        /// </summary>
        [TestMethod]
        public void TestGroupJoin()
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

            var source2 = new []
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

            var result = source2.GroupJoin(
                source1,
                authorInfo => authorInfo.Name,
                classInfo => classInfo.BaseClassName,
                (a, classes) => new
                {
                    Author = a.AuthorName,
                    BaseClass = a.Name,
                    //Children = classes,
                });

            Assert.IsTrue(result.Any(i => i.Author == "unknown"));
            Assert.AreEqual(result.Count(i => i.Author == ".NET" && i.BaseClass == "Exception"), 1);
            Assert.AreEqual(result.Count(i => i.Author == ".NET" && i.BaseClass == "EventArgs"), 1);
            Assert.AreEqual(result.Count(i => i.Author == "OpenTween" && i.BaseClass == "OTBaseForm"), 1);
        }
    }
}
