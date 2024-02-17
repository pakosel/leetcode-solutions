using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SortIntegersByTheNumberOf1Bits
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0,1,2,3,4,5,6,7,8]", "[0,1,2,4,8,3,5,6,7]"},
            new object[] {"[1024,512,256,128,64,32,16,8,4,2,1]", "[1,2,4,8,16,32,64,128,256,512,1024]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, string expectedStr)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.SortByBits(arr);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}