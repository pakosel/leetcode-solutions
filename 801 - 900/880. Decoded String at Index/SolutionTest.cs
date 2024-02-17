using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace DecodedStringAtIndex
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"a", 1, "a"},
            new object[] {"ab", 2, "b"},
            new object[] {"abc3", 9, "c"},
            new object[] {"leet2code3", 10, "o"},
            new object[] {"ha22", 5, "h"},
            new object[] {"a2345678999999999999999", 1, "a"},
            new object[] {"y959q969u3hb22odq595", 222280369, "y"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Memoization(string S, int K, string expected)
        {
            var sol = new Solution();
            var res = sol.DecodeAtIndex(S, K);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}