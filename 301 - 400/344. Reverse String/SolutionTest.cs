using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReverseString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[a]", "[a]"},
            new object[] {"[a,b]", "[b,a]"},
            new object[] {"[a,b,c]", "[c,b,a]"},
            new object[] {"[h,e,l,l,o]", "[o,l,l,e,h]"},
            new object[] {"[H,a,n,n,a,h]", "[h,a,n,n,a,H]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string arrStr, string expectedStr)
        {
            var arr = ArrayHelper.ArrayFromString<char>(arrStr);
            var expected = ArrayHelper.ArrayFromString<char>(expectedStr);

            var sol = new Solution();
            sol.ReverseString(arr);

            CollectionAssert.AreEqual(arr, expected);
        }
    }
}