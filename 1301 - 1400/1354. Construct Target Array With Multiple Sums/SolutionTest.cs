using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ConstructTargetArrayWithMultipleSums
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1]", true},
            new object[] {"[1,1]", true},
            new object[] {"[1,2]", true},
            new object[] {"[1,3]", true},
            new object[] {"[2,13]", true},
            new object[] {"[9,3,5]", true},
            new object[] {"[1,1,1,2]", false},
            new object[] {"[8,5]", true},
            new object[] {"[17,3,5]", true},
            new object[] {"[8,13]", true},
            new object[] {"[7,1]", true},
            new object[] {"[7,2]", true},
            new object[] {"[7,3]", true},
            new object[] {"[7,4]", true},
            new object[] {"[7,5]", true},
            new object[] {"[8,4]", false},
            new object[] {"[8,7]", true},
            new object[] {"[2,90002]", false},
            new object[] {"[2,900000001]", true},
            new object[] {"[1,1000000000]", true},
            new object[] {"[1,1,999999999]", true},
            new object[] {"[86,94,39,66,9,22]", false},
            new object[] {"[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,999999999,999999999,999999999,999999999,999999999,999999999,999999999,999999999,999999999,999999999,999999999,999999999,999999999,999999999,999999999,999999999]", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string tragetStr, bool expected)
        {
            var target = ArrayHelper.ArrayFromString<int>(tragetStr);

            var sol = new Solution();
            var res = sol.IsPossible(target);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}