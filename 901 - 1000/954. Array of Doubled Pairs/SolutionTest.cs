using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ArrayOfDoubledPairs
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[]", true},
            new object[] {"[0,0]", true},
            new object[] {"[3,1,3,6]", false},
            new object[] {"[2,1,2,6]", false},
            new object[] {"[4,-2,2,-4]", true},
            new object[] {"[1,2,4,16,8,4]", false},
            new object[] {"[4,-2,2,-4,0,0]", true},
            new object[] {"[4,-2,2,-4,0,0,0,0]", true},
            new object[] {"[2,1,1,4,8,8]", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string arrStr, bool expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.CanReorderDoubled(arr);

            Assert.AreEqual(res, expected);
        }
    }
}