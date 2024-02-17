using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindOriginalArrayFromDoubledArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,3,4,2,6,8]", "[4,3,1]"},
            new object[] {"[6,3,0,1]", "[]"},
            new object[] {"[1]", "[]"},
            new object[] {"[1,3,4,2,6]", "[]"},
            new object[] {"[4,4]", "[]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string changedStr, string expectedStr)
        {
            var changed = ArrayHelper.ArrayFromString<int>(changedStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.FindOriginalArray(changed);

            CollectionAssert.AreEquivalent(expected, res);
        }
    }
}