using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FourSumII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[]","[]","[]","[]", 0 },
            new object[] { "[1]","[1]","[0]","[-2]", 1 },
            new object[] { "[1,2]","[-2,-1]","[-1,2]","[0,2]", 2 },
            new object[] { "[1,2,5,4,9,-12]","[-2,-1,-4,5,-11,-9]","[-1,2,-1,-2,-5,6]","[0,2,6,-2,-4,7]", 50 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string arrStrA, string arrStrB, string arrStrC, string arrStrD, int expected)
        {
            var A = ArrayHelper.ArrayFromString<int>(arrStrA);
            var B = ArrayHelper.ArrayFromString<int>(arrStrB);
            var C = ArrayHelper.ArrayFromString<int>(arrStrC);
            var D = ArrayHelper.ArrayFromString<int>(arrStrD);

            var sol = new Solution();
            var res = sol.FourSumCount(A, B, C, D);

            Assert.AreEqual(expected, res);
        }
    }
}