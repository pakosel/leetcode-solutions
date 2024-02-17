using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace MaximumRepeatingSubstring
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"a", "a", 1},
            new object[] {"a", "b", 0},
            new object[] {"ababc", "ab", 2},
            new object[] {"ababc", "ba", 1},
            new object[] {"ababc", "ac", 0},
            new object[] {"bbaa", "ba", 1},
            new object[] {"bbbaa", "bba", 1},
            new object[] {"baba", "b", 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string sequence, string word, int expected)
        {
            var sol = new Solution();
            var res = sol.MaxRepeating(sequence, word);

            ClassicAssert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic_BF(string sequence, string word, int expected)
        {
            var sol = new Solution_BF();
            var res = sol.MaxRepeating(sequence, word);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}