using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountOfSmallerNumbersAfterSelf
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", "[0]"},
            new object[] {"[1,1]", "[0,0]"},
            new object[] {"[-1]", "[0]"},
            new object[] {"[-1,-1]", "[0,0]"},
            new object[] {"[1,1,1]", "[0,0,0]"},
            new object[] {"[2,1,1,1]", "[3,0,0,0]"},
            new object[] {"[5,2,6,1]", "[2,1,1,0]"},
            new object[] {"[5,2,1,6,1]", "[3,2,0,1,0]"},
            new object[] {"[1,5,2,1,6,1]", "[0,3,2,0,1,0]"},
            new object[] {"[1,5,2,1,6,1,1]", "[0,4,3,0,2,0,0]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.CountSmaller(nums);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}