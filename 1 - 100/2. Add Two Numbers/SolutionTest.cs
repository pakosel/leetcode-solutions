using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AddTwoNumbers
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[9,9,9,9,9,9]", "[9,9,9,9,9,9,9,9,9]", "[8,9,9,9,9,9,0,0,0,1]"},
            new object[] {"[2,4,3]", "[5,6,4]", "[7,0,8]"},
            new object[] {"[0]", "[0]", "[0]"},
            new object[] {"[9,9,9,9,9,9,9]", "[9,9,9,9]", "[8,9,9,9,0,0,0,1]"},
            new object[] {"[3,0,9,4,8,1,4,6,5,1]", "[6]", "[9,0,9,4,8,1,4,6,5,1]"},
            new object[] {"[8,6]", "[6,4,8]", "[4,1,9]"},
            new object[] {"[3,0,9,4,8,1,4,6,5,1]", "[6,5,3,7,7,8,8,6,5,1]", "[9,5,2,2,6,0,3,3,1,3]"},
            new object[] {"[1,8]", "[0]", "[1,8]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string l1Str, string l2Str, string expectedStr)
        {
            var l1 = ListNodeHelper.BuildList(l1Str);
            var l2 = ListNodeHelper.BuildList(l2Str);
            var expected = ListNodeHelper.BuildList(expectedStr);

            var sol = new Solution();
            var res = sol.AddTwoNumbers(l1, l2);

            ClassicAssert.IsTrue(ListNodeHelper.AreEqual(res, expected));
        }
    }
}