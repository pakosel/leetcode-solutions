using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BoatsToSavePeople
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2]", 3, 1},
            new object[] {"[3,2,2,1]", 3, 3},
            new object[] {"[3,5,3,4]", 5, 4},
            new object[] {"[1,2,3,3,3,5,5,5]", 5, 6},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string peopleStr, int limit, int expected)
        {
            var people = ArrayHelper.ArrayFromString<int>(peopleStr);

            var sol = new Solution();
            var res = sol.NumRescueBoats(people, limit);

            Assert.AreEqual(res, expected);
        }
    }
}