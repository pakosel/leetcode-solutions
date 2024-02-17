using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PeakIndexInMountainArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0,1,0]", 1},
            new object[] {"[0,2,1,0]", 1},
            new object[] {"[0,10,5,2]", 1},
            new object[] {"[0,5,10,5,2]", 2},
            new object[] {"[0,5,6,10,5,2]", 3},
            new object[] {"[0,5,10,6,5,2]", 2},
            new object[] {"[0,5,6,10,6,2]", 3},
            new object[] {"[3,5,3,2,0]", 1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string arrStr, int expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.PeakIndexInMountainArray(arr);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}