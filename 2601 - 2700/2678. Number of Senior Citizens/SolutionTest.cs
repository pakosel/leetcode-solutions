using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfSeniorCitizens
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[7868190130M7522,5303914400F9211,9273338290F4010]", 2},
            new object[] {"[1313579440F2036,2921522980M5644]", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string detailsStr, int expected)
        {
            var details = ArrayHelper.ArrayFromString<string>(detailsStr);

            var sol = new Solution();
            var res = sol.CountSeniors(details);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}