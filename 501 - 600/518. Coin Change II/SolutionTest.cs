using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CoinChangeII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {0, "[1,2,3]", 1},
            new object[] {5, "[1,2,5]", 4},
            new object[] {3, "[2]", 0},
            new object[] {10, "[10]", 1},
            new object[] {500, "[3,5,7,13,17]", 133697},
            new object[] {67, "[3,5,7,13,17]", 111},
            new object[] {19, "[3,5,7,13,17]", 4},
            new object[] {11, "[3,5,7,13,17]", 1},
            new object[] {11, "[5,7,13,17]", 0},
            new object[] {1000, "[1452,1307,4981,3545,622,4264,3696,1532,1639,2647,3035,3975,1217,2916,487,18,399,1491,3942,1214,1190,1228,3978,5,4084,2799,3111,1151,3068,4389,279,1894,2577,2025,2751,4880,3412,2346,2318,4307,4596,3965,3691,3826,4754,1702,4726,3513,3665,3255,1636,3002,4772,1412,4207,4792,4823,855,1697,2244,3729,2686,1500,2270,2712,1760,4659,1640,2811,1269,728,2261,3789,1194,2496,1182,4206,648,4256,3352,1298,1925,715,2498,2870,4678,258,3543,864,1907,2826,3963,3843,1575,67,4191,3566,4587,2918,693,1928,4445,2521,840,1348,4140,723,961,4399,3211,1514,3653,59,3472,1242,2989,3072,334,4904,4717,1231,1154,1953,3541,3322,2003,273,1385,1422,4255,3247,2692,3378,3252,932,3529,327,235,3938,4048,260,1793,1104,3816,981,2093,2001,3492,861,1915,765,3813,4724,4606,1258,2092,531,643,4321,3623,4716,3878,147,2035,3129,1289,4583,2373,4447,3285,1923,2777,3357,2774,3198,1161,4674,3065,4634,4510,1596,853,2512,4071,4797,1227,4146,707,4705,4096,796,4351,996,4817,3907,4234,2300,2148,3685,949,3811,4142,1858,2578,4865,4432,398,3912,309,1090,3310,131,519,928,4821,1060,3941,4994,2510,803,4464,155,1587,1584,2567,3684,4858,3837,1519,4922,4083,3439,40,3728,3456,2994,2243,1171,4652,1048,4259,98,466,3573,3891,4377,4416,199,2414,4798,2309,1107,1063,3049,4898,3292,3481,2669,547,3660,4272,1476,1383,709,4559,2167,4129,4584,993,4853,822,2232,1047,403,4997,280,4114,1297,221,2086,2708,2868,74,2960,3560,756,3973,2155,2259,4653,629,4044,2495,192,1744,4267,2966,2844,1594,1872]", 701197},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int amount, string coinsStr, int expected)
        {
            var coins = ArrayHelper.ArrayFromString<int>(coinsStr);

            var sol = new Solution();
            var res = sol.Change(amount, coins);

            Assert.AreEqual(expected, res);
        }
    }
}