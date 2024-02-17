using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MissingNumber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0]", 1},
            new object[] {"[1]", 0},
            new object[] {"[3,0,1]", 2},
            new object[] {"[0,1]", 2},
            new object[] {"[9,6,4,2,3,5,7,0,1]", 8},
            new object[] {"[0,1,2,3,4,5,6,7,8,9]", 10},
            new object[] {"[4,3,2,1]", 0},
            new object[] {"[0,4,2,1]", 3},
            new object[] {"[4,2,0,1]", 3},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Math(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution_Math();
            var res = sol.MissingNumber(nums);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Jumps(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution_Jumps();
            var res = sol.MissingNumber(nums);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Naive(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution_Naive();
            var res = sol.MissingNumber(nums);

            Assert.That(expected == res);
        }
    }
}