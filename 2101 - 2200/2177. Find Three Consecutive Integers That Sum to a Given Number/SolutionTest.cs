using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindThreeConsecutiveIntegersThatSumToGivenNumber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {33, new long[] {10,11,12}},
            new object[] {4, new long[0]},
            new object[] {0, new long[] {-1,0,1}},
            new object[] {9687354135, new long[] {3229118044,3229118045,3229118046}},
            new object[] {10, new long[0]},
            new object[] {1, new long[0]},
            new object[] {2, new long[0]},
            new object[] {8977353, new long[] {2992450,2992451,2992452}},
            
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(long num, long[] expected)
        {
            var sol = new Solution();
            var res = sol.SumOfThree(num);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}