using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumGardenPerimeterToCollectEnoughApples
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, 8},
            new object[] {13, 16},
            new object[] {1000000000, 5040},
            new object[] {692631832592697, 445896},
            new object[] {1000000000000000, 503968},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(long needApples, long expected)
        {
            var sol = new Solution();
            var res = sol.MinimumPerimeter(needApples);

            Assert.That(expected == res);
        }
    }
}