using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PairsOfSongsDivisibleBy60
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[60]", 0},
            new object[] {"[20,40]", 1},
            new object[] {"[30,20,150,100,40]", 3},
            new object[] {"[60,60,60]", 3},
            new object[] {"[15,63,451,213,37,209,343,319]", 1},
            
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string strArr, int expected)
        {
            var time = ArrayHelper.ArrayFromString<int>(strArr);

            var sol = new Solution();
            var res = sol.NumPairsDivisibleBy60(time);

            Assert.AreEqual(res, expected);
        }
    }
}