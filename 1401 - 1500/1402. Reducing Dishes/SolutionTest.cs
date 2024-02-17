using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ReducingDishes
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[-1]", 0},
            new object[] {"[1]", 1},
            new object[] {"[-1,-8,0,5,-7]", 14},
            new object[] {"[4,3,2]", 20},
            new object[] {"[-1,-4,-5]", 0},
            new object[] {"[357,480,290,-49,-20,668,-754,-560,-881,250,842,-739,819,-393,144,-446,788,250,975,373,660,277,761,-219,755,565,-423,-223,-635,763,-725,-556,-872,-155,62,-336,584,418,-76,90,657,979,399,-637,-387,-953,134,612,738,-397,-834,-798,439,-22,103,31,-100,696,-9,250,437,-29,-359,-174,-83,-277,660,955,247,-3,526,-591,594,810,-195,-931,-569,140,902,403,829,-964,105,-673,-97,348,-847,80,447,-783,154,361,119,2,755,-381,414,6,559,789]", 1940280},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string satisfactionStr, int expected)
        {
            var satisfaction = ArrayHelper.ArrayFromString<int>(satisfactionStr);

            var sol = new Solution();
            var res = sol.MaxSatisfaction(satisfaction);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}