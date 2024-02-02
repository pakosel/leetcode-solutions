using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DivideArrayIntoArraysWithMaxDifference
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,3,4,8,7,9,3,5,1]", 2, "[[1,1,3],[3,4,5],[7,8,9]]"},
            new object[] {"[1,3,3,2,7,3]", 3, "[]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int k, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);
            
            var sol = new Solution();
            var res = sol.DivideArray(nums, k);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}