using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace Base7
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { 0, "0" },
            new object[] { 3, "3" },
            new object[] { -5, "-5" },
            new object[] { -7, "-10" },
            new object[] { 100, "202" },
            new object[] { 10000000, "150666343" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int num, string expected)
        {
            var sol = new Solution();
            var res = sol.ConvertToBase7(num);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}