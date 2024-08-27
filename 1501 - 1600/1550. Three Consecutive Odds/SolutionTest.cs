using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ThreeConsecutiveOdds
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,6,4,1]", false},
            new object[] {"[1,2,34,3,4,5,7,23,12]", true},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, bool expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.ThreeConsecutiveOdds(arr);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}