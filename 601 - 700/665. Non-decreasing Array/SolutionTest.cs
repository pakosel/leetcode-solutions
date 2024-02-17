using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NondecreasingArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", true},
            new object[] {"[1,2]", true},
            new object[] {"[2,1]", true},
            new object[] {"[4,2,3]", true},
            new object[] {"[4,2,3]", true},
            new object[] {"[1,1,1,1]", true},
            new object[] {"[3,4,2,3]", false},
            new object[] {"[3,4,3,3]", true},
            new object[] {"[1,5,4,6,7,10,8,9]", false},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, bool expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.CheckPossibility(nums);

            Assert.That(expected == res);
        }
    }
}