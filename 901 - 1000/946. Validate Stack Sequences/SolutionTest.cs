using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ValidateStackSequences
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0]", "[0]", true},
            new object[] {"[1,2,3,4,5]", "[4,5,3,2,1]", true},
            new object[] {"[1,2,3,4,5]", "[4,3,5,1,2]", false},
            new object[] {"[1,2,3,4,5]", "[3,5,4,2,1]", true},
            new object[] {"[1,2,3]", "[1,2,3]", true},
            new object[] {"[1,2,3]", "[2,1,3]", true},
            new object[] {"[1,2,3]", "[2,3,1]", true},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Memoization(string pushedStr, string poppedStr, bool expected)
        {
            var pushed = ArrayHelper.ArrayFromString<int>(pushedStr);
            var popped = ArrayHelper.ArrayFromString<int>(poppedStr);

            var sol = new Solution();
            var res = sol.ValidateStackSequences(pushed, popped);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}