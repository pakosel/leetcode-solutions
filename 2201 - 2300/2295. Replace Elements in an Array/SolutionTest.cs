using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReplaceElementsInAnArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,4,6]", "[[1,3],[4,7],[6,1]]", "[3,2,7,1]"},
            new object[] {"[1,2]", "[[1,3],[2,1],[3,2]]", "[2,1]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string operationsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var operations = ArrayHelper.MatrixFromString<int>(operationsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.ArrayChange(nums, operations);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}