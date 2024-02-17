using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountingBits
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {0, "[0]"},
            new object[] {1, "[0,1]"},
            new object[] {2, "[0,1,1]"},
            new object[] {13, "[0,1,1,2,1,2,2,3,1,2,2,3,2,3]"},
            new object[] {14, "[0,1,1,2,1,2,2,3,1,2,2,3,2,3,3]"},
            new object[] {15, "[0,1,1,2,1,2,2,3,1,2,2,3,2,3,3,4]"},
            new object[] {16, "[0,1,1,2,1,2,2,3,1,2,2,3,2,3,3,4,1]"},
            new object[] {21, "[0,1,1,2,1,2,2,3,1,2,2,3,2,3,3,4,1,2,2,3,2,3]"},
            new object[] {24, "[0,1,1,2,1,2,2,3,1,2,2,3,2,3,3,4,1,2,2,3,2,3,3,4,2]"},
            new object[] {31, "[0,1,1,2,1,2,2,3,1,2,2,3,2,3,3,4,1,2,2,3,2,3,3,4,2,3,3,4,3,4,4,5]"},
            new object[] {32, "[0,1,1,2,1,2,2,3,1,2,2,3,2,3,3,4,1,2,2,3,2,3,3,4,2,3,3,4,3,4,4,5,1]"},
            new object[] {33, "[0,1,1,2,1,2,2,3,1,2,2,3,2,3,3,4,1,2,2,3,2,3,3,4,2,3,3,4,3,4,4,5,1,2]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(int n, string expectedStr)
        {
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.CountBits(n);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}