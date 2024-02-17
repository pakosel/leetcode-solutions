using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumLengthOfConcatenatedStringWithUniqueCharacters
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[un,iq,ue]", 4},
            new object[] {"[cha,r,act,ers]", 6},
            new object[] {"[abcdefghijklmnopqrstuvwxyz]", 26},
            new object[] {"[unc,iq,ue,ixyzv]", 8},
            new object[] {"[aa,bb]", 0},
            new object[] {"[ab,cd,cde,cdef,efg,fgh,abxyz]", 11},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, int expected)
        {
            var arr = ArrayHelper.ArrayFromString<string>(arrStr);

            var sol = new Solution();
            var res = sol.MaxLength(arr);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}