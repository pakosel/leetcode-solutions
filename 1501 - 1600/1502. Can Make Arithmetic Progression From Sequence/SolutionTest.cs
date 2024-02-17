using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CanMakeArithmeticProgressionFromSequence
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[3,5,1]", true},
            new object[] {"[1,2,4]", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, bool expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.CanMakeArithmeticProgression(arr);

            Assert.That(expected == res);
        }
    }
}