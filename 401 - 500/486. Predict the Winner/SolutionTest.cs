using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PredictTheWinner
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,5,2]", false},
            new object[] {"[1,5,233,7]", true},
            new object[] {"[1,3,1]", false},
            new object[] {"[1,706,2,157,1,840,14,223,78,494,103,513,262,944,751,650,454,404,289,1]", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, bool expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.PredictTheWinner(nums);

            Assert.That(expected == res);
        }
    }
}