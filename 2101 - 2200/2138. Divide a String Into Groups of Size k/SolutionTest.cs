using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DivideStringIntoGroupsOfSizek
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"abcdefghi", 3, 'x', new string[] {"abc","def","ghi"}},
            new object[] {"abcdefghij", 3, 'x', new string[] {"abc","def","ghi","jxx"}},
            new object[] {"a", 3, 'x', new string[] {"axx"}},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, int k, char fill, string[] expected)
        {
            var sol = new Solution();
            var res = sol.DivideString(s, k, fill);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}