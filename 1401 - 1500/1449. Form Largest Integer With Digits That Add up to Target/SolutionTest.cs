using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace FormLargestInteger
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[4,3,2,5,6,7,2,5,5]", 9, "7772"},
            new object[] {"[7,6,5,5,5,6,8,7,8]", 12, "85"},
            new object[] {"[2,4,6,2,4,6,4,4,4]", 5, "0"},
            new object[] {"[6,10,15,40,40,40,40,40,40]", 47, "32211"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, int target, string expected)
        {
            var arr = arrStr.TrimStart('[').TrimEnd(']').Split(",")
                .Select(s => int.Parse(s)).ToArray();

            var sol = new Solution();
            var res = sol.LargestNumber(arr, target);

            Assert.That(expected == res);
        }
    }
}