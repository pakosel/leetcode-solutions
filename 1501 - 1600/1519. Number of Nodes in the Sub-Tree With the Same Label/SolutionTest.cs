using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfNodesInTheSubTreeWithTheSameLabel
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, "[]", "x", "[1]"},
            new object[] {2, "[[0,1]]", "xx", "[2,1]"},
            new object[] {2, "[[1,0]]", "xy", "[1,1]"},
            new object[] {7, "[[0,1],[0,2],[1,4],[1,5],[2,3],[2,6]]", "abaedcd", "[2,1,1,1,1,1,1]"},
            new object[] {4, "[[0,1],[1,2],[0,3]]", "bbbb", "[4,2,1,1]"},
            new object[] {5, "[[0,1],[0,2],[1,3],[0,4]]", "aabab", "[3,2,1,1,1]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int n, string edgesStr, string labels, string expectedStr)
        {
            var edges = ArrayHelper.MatrixFromString<int>(edgesStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            Assert.That(n == expected.Length);
            Assert.That(n == labels.Length);

            var sol = new Solution();
            var res = sol.CountSubTrees(n, edges, labels);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}