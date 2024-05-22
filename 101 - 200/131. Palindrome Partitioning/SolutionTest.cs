using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PalindromePartitioning
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"a", "[[a]]"},
            new object[] {"aa", "[[a,a],[aa]]"},
            new object[] {"aaa", "[[a,a,a],[a,aa],[aa,a],[aaa]]"},
            new object[] {"aab", "[[a,a,b],[aa,b]]"},
            new object[] {"aabaab", "[[a,a,b,a,a,b],[a,a,b,aa,b],[a,a,baab],[a,aba,a,b],[aa,b,a,a,b],[aa,b,aa,b],[aa,baab],[aabaa,b]]"},
            new object[] {"axa", "[[a,x,a],[axa]]"},
            new object[] {"aaaaaa", "[[a,a,a,a,a,a],[a,a,a,a,aa],[a,a,a,aa,a],[a,a,a,aaa],[a,a,aa,a,a],[a,a,aa,aa],[a,a,aaa,a],[a,a,aaaa],[a,aa,a,a,a],[a,aa,a,aa],[a,aa,aa,a],[a,aa,aaa],[a,aaa,a,a],[a,aaa,aa],[a,aaaa,a],[a,aaaaa],[aa,a,a,a,a],[aa,a,a,aa],[aa,a,aa,a],[aa,a,aaa],[aa,aa,a,a],[aa,aa,aa],[aa,aaa,a],[aa,aaaa],[aaa,a,a,a],[aaa,a,aa],[aaa,aa,a],[aaa,aaa],[aaaa,a,a],[aaaa,aa],[aaaaa,a],[aaaaaa]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_2024(string s, string expectedStr)
        {
            var expected = ArrayHelper.MatrixFromString<string>(expectedStr);

            var sol = new Solution2024();
            var res = sol.Partition(s);

            Assert.That(res, Is.EquivalentTo(expected));
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string expectedStr)
        {
            var expected = ArrayHelper.MatrixFromString<string>(expectedStr);

            var sol = new Solution();
            var res = sol.Partition(s);

            Assert.That(res, Is.EquivalentTo(expected));
        }
    }
}