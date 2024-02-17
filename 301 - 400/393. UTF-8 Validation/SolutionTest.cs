using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace UTF8Validation
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0]", true},
            new object[] {"[0,0]", true},
            new object[] {"[1,1]", true},
            new object[] {"[197,130,1]", true},
            new object[] {"[197,197,1]", false},
            new object[] {"[130]", false},
            new object[] {"[235,140,4]", false},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string dataStr, bool expected)
        {
            var data = ArrayHelper.ArrayFromString<int>(dataStr);

            var sol = new Solution();
            var res = sol.ValidUtf8(data);

            Assert.That(expected == res);
        }
    }
}