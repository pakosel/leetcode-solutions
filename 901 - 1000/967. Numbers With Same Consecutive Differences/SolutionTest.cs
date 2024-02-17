using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumbersWithSameConsecutiveDifferences
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {3, 7, "[181,292,707,818,929]"},
            new object[] {2, 0, "[11,22,33,44,55,66,77,88,99]"},
            new object[] {2, 1, "[12,10,23,21,34,32,45,43,56,54,67,65,78,76,89,87,98]"},
            new object[] {9, 9, "[909090909]"},
            new object[] {2, 9, "[90]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, int k, string expectedStr)
        {
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.NumsSameConsecDiff(n, k);

            CollectionAssert.AreEquivalent(expected, res);
        }
    }
}