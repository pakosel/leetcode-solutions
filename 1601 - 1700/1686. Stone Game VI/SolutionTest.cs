using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace StoneGameVI
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] { "[8]", "[8]", 1 },
            new object[] { "[1,3]", "[2,1]", 1 },
            new object[] { "[1,2]", "[3,1]", 0 },
            new object[] { "[2,4,3]", "[1,6,7]", -1 },
            new object[] { "[2,4,3]", "[1,3,7]", 1 },
            new object[] { "[17,34]", "[34,17]", 0 },            
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string strArrA, string strArrB, int expected)
        {
            var aliceVal = ArrayHelper.ArrayFromString<int>(strArrA);
            var bobVal = ArrayHelper.ArrayFromString<int>(strArrB);

            var sol = new Solution();
            var res = sol.StoneGameVI(aliceVal, bobVal);

            Assert.AreEqual(expected, res);
        }
    }
}