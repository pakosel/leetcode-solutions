using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FrogJump
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0,1,3,5,6,8,12,17]", true},
            new object[] {"[0,1,2,3,4,8,9,11]", false},
            new object[] {"[0,1,3,6,10,15,19,21,24,26,30,33]", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string stonesStr, bool expected)
        {
            var stones = ArrayHelper.ArrayFromString<int>(stonesStr);

            var sol = new Solution();
            var res = sol.CanCross(stones);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}