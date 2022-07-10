using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace JumpGameII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[0]", 0 },
            new object[] { "[1,0]", 1 },
            new object[] { "[2,3,1,1,4]", 2 },
            new object[] { "[2,3,0,1,4]", 2 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            
            var sol = new Solution();
            var res = sol.Jump(nums);

            Assert.AreEqual(expected, res);
        }
    }
}