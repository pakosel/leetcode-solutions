using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace StoneGameII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,7,9,4,4]", 10},
            new object[] {"[1,2,3,4,5,100]", 104},
            new object[] {"[4056,2873,3404,3663,3484,1325,895,1866,5854,2861,5695,8409,1658,9346,5527,4725,139,8833,4577,7183,7789,4974,9808,4073,3360,8318,8413,2095,9343,5509,7355,2647,7622,718,5356,6804,427,7378,8104,5121,2313,7290,3216,7277,8614,6715,626,1177,4740,3423,4783,7214,8448,5692,4586,4866,6625,1025,13,7988,829,2605,306,169,3709,6752,1596,7944,378,6983,4302,358,7558,6347,6018,7724,8932,8025,3469,5256,979,891,6521,7005,1096,9913,4406,1579,3100,9289,9271,2195,6922,2625,4557,4742,9872,2980,9420,1356]", 243687},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string pilesStr, int expected)
        {
            var piles = ArrayHelper.ArrayFromString<int>(pilesStr);

            var sol = new Solution();
            var res = sol.StoneGameII(piles);

            Assert.That(expected == res);
        }
    }
}