using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountNumberOfNiceSubarrays
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,1,2,1,1]", 3, 2},
            new object[] {"[2,4,6]", 1, 0},
            new object[] {"[2,2,2,1,2,2,1,2,2,2]", 2, 16},
            new object[] {"[2,2,2,1,2,2,1,2,2,2,1]", 2, 19},
            new object[] {"[1,2,2,2,1,2,2,1,2,2,2,1]", 2, 22},
            new object[] {"[2,2,2,1,2,2,1,2,2,2,1]", 1, 28},
            new object[] {"[1,2,2,2,1,2,2,1,2,2,2,1]", 1, 32},
            new object[] {"[2,2,2,1,2,2,1,2,2,2,1]", 4, 0},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, int k, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            
            var sol = new Solution();
            var res = sol.NumberOfSubarrays(nums, k);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}