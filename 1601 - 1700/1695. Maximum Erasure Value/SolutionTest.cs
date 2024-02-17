using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumErasureValue
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1]", 1},
            new object[] {"[1,1,1,1,1]", 1},
            new object[] {"[4,2,4,5,6]", 17},
            new object[] {"[5,2,1,2,5,2,1,2,5]", 8},
            new object[] {"[9201,7239,9204,9394,4221,282,4295,2528,2381,1685,3905,3357,4776,3564,754,3585,8257,6564,8026,4921,1058,8761,3436,2525,2704,8032,5270,8715,4850,8136,2017,7172,2347,6760,3449,3650,9674,250,2224,8796,4491,595,2565,8343,382,7939,6487,736,4058,2180,7405,8094,2663,6848,3199,3647,3027,4200,1931,2688,9484,2269,2828,5406,1690,8709,6330,3121,5199,7358,4389,6526,740,8737,6098,7290,7909,467,3874,6385,9243,30,3239,5049,6988,3108,4424,2511,5667,5965,61,2307,3370,8742,9270,669,6371,277,2702,7522,6966,7027,7968,9228,8530,3216,9517,3726,2517,6046,4614,6915,3327,7023,8348,1613,1993,5876,4967,4106,944,497,5929,3559,1660,4854,3492,5744,9230,3993,329,8755,8722,3289,9235,9685,2431,363,8314,1126,7903,2673,1802,3335,5294,2601,5370,1561,6066,1463,8111,6165,5612,149,9419,3196,3447,2774,768,1945,182,2734,7572,7814,6512,6298,5417,3716,9969,138,8544,6035,1838,6196,1599,6337,1930,2192,82,3625,5754,9162,9756,1524,1650,3718,4896,4226,7520,6439,2053,6480,8663,9784,8695,9678,5167,2066,398,6997,4377,3700,8253,7222,9077,8708,7924,426,6630,3348,6074,9688,5788,2015,2274,8508,8502,3523,9969,6085,533,2815,5118,6020,2355,5504,2942,223,9678,6144,662,5402,5135,2419,9744,5939,9953,7095,8041,6360,5842,6301,5175,3749,7507,6859,4560,2757,6032,1184,7284,3370,5915,4620,3566,7844,4520,6497,8854,1583,6723,6065,9407,2551,444,78,4554,6238,4670,532,4870,6503,7169,4596,3148,4722,6433,5456,3205,5701,2181,6286,6518,4077,7298,796,9747,7151,1373,3481,9374,2727,9417,1684,6505,5713,9316,9481,4181,3689,6849,4143,8212,1649,9235,4394,2064,8475,1388,4891,7519,6853,8358,465,3439,2359,5514,5343,3824,6126,2602,5561,7339,9971,7603,2497,6650,5857,9674,2236,2764,8005,7331,2739,1251,7934,9809,1688,8578,4387,3086,135,4183,7047,9389,8504,5093,9470,484,868,2680,667,396,1070,7788,1352,6094,550,3680,4238,3628,661,7362,3690,5768,9521,4678,3389,8046,942,1556,7090,6482,1255,5861,4780,5209,9898,4224,4272,7697,3581,6336,1452,2475,266,78,6879,3673,4349,6642,3418,9256,325,4771,561,7713,3938,2675,3903,9318,1844,9204,9804,4739,6425,8739,9722,4157,3074,6701,1802,3720,6266,6833,8155,1019,2949,9044,3498,6196,167,395,9142,7801,7711,8414,4805,7338,2660,6396,9622,1805,6873,3480,8477,5516,2062,5814,5963,358,8863,9075,36,3886,3780,2080,6816,8326,6363,9996,1718,3717,7989,232,8828,623,4899,5050,7143,9074,3001,255,6391,6123,3942,7619,2502,8393,9004,7150,1408,2787,8825,6520,317,7268,4943,1317,5018,8953,4822,4997,4709,580,768,958,4103,5108,3274,7163,2029,4181,1579,5732,1413,3693,3301,1748,9040,686,6932,9504,9022,1751,3369,7587,6465,4947,1683,6419,1596,8084,1591,1926,5666,2661,378,956,1310,8859,3399,837,438,4923,4731,7199,1505,3760,2248,7094,8804,2700,6696,9107,306,2823,8832,1156,9731,753,9967,287,3655,5725,7096,2517,6106,5097,3206,529,5847,8280,7736,3547,1898,1988,9713,5591,9953,6791,7527,8202,9388,482,655,6964,2001,6277,444,8604,6868,8226,9568,8666,2962,8707,4699,5029,2966,5661,5636,2473,723,7513,150,94,5634,7367,9172,9288,3604,4459,8216,4659,6577,2608,7877,8219,5366,5534,2705,8282,6685,6096,7429,9222,2089,6693,414,606,9206,3618,3126,2807,1347,3749,7515,4234,5210,1798,9077,5196,9146,5069,8071,4168,4144,354,6899,7595,8911,3837,1522,3690,9392,8082,3376,3639,6987,2369,1411,3374,339,3741,2298,8954,5388,5302,8974,8168,1130,1858,1552,8995,4864,6106,6128,4196,5547,760,7369,9259,181,6717,3475,1261,2052,9455,3328,6539,9605,9801,6211,4206,4702,3854,3662,1481,4761,8401,2986,4442,3490,1275,99,3722,7248,1953,1153,9053,6503,7237,7314,1343,6245,768,4119,1743,5922,9926,6003,3412,2016,7337,4928,8230,7079,3986,1624,2067,513,9198,4806,3080,9402,3550,2944,1570,2313,4495,5245,3208,2472,1908,4682,4676,7134,6936,1571,9697,5092,7249,442,2076,9341,6602,6106,5137,6338,1834,2955,6605,945,8944,8576,6782,8864,415,4893,6146,7996,6088,6944,7047,7758,2586,2311,2108,7911,9028,2139,567,979,3118,7086,9803,9362,6634,1159,1165,304,9114,668,1536,4903,2214,770,9818,9205,1046,1397,4074,5991,6101,502,4693,6285,9775,2041,8318,2336,3857,4727,2718,7018,829,2936,4039,6022,4026,7937,3551,7333,3325,4406,9636,1069,5776,2605,5474,5091,2198,3984,9308,7140,4396,3099,8814,9429,7922,8110,1251,8993,2103,9804,9930,708,580,4807,5597,965,4618,7818,4823,361,6584,1023,6606,397,3282,4802,6765,5277,5157,4783,9639,6706,8029,1729,9694,3137,9485,7931,3922,3070,9215,2051,3732,6050,7897,4575,4174,8857,5736,8025,775,6992,3859,6181,6100,9711,738,1131,1492,7611,1428,6349,4404,5844,7525,2393,1957,2204,9604,8293,168,2377,6295,6839,3821,1104,9520,4216,8577,109,2917,8126,6158,1081,8850,8060,9071,8153,6462,8654,4118,8515,3396,7987,7618,6889,2764,9633,6423,6750,6097,4594,5622,494,6649,140,7089,8112,1624,6730,371,9436,3119,6212,5188,7662,2116,7454,9637,2860,4477,3299,4177,6507,6175,5275,527,762,783,3200,2958,669,5359,6589,4582,5157,7675,8322,4654,7886,1995,3134,8041,9730,6279,3623,3301,2335,7078,2733,152,2015,7835,8233,6388,571,4244,9391,7933,2496,3304,6802,3610,7991,8879,392,3441,4380,9259,9701,3798,7631,2230,9594,2138,5545,2344,1253,3501,1758,3889,155,3087,4198]", 1651623},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.MaximumUniqueSubarray(nums);

            Assert.That(expected == res);
        }
    }
}