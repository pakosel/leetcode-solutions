using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaxPointsOnLine
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[0,0]]", 1},
            new object[] {"[[0,0],[1,1]]", 2},
            new object[] {"[[1,1],[2,2],[3,3]]", 3},
            new object[] {"[[1,1],[3,2],[5,3],[4,1],[2,3],[1,4]]", 4},
            new object[] {"[[1,1],[6,-1],[4,1],[2,3],[1,4]]", 4},
            new object[] {"[[1,1],[6,-1],[4,1],[2,3],[1,4],[4,3],[10,1],[13,0],[16,-1]]", 5},
            new object[] {"[[-2,82],[67,40],[72,-60],[44,40],[-15,49],[-41,-34],[-26,47],[30,-14],[46,14]]", 2},
            new object[] {"[[-184,-551],[-105,-467],[-90,-394],[-60,-248],[115,359],[138,429],[60,336],[150,774],[207,639],[-150,-686],[-135,-613],[92,289],[23,79],[135,701],[0,9],[-230,-691],[-115,-341],[-161,-481],[230,709],[-30,-102]]", 11},
            new object[] {"[[54,153],[1,3],[0,-72],[-3,3],[12,-22],[-60,-322],[0,-5],[-5,1],[5,5],[36,78],[3,-4],[5,0],[0,4],[-30,-197],[-5,0],[60,178],[0,0],[30,53],[24,28],[4,5],[2,-2],[-18,-147],[-24,-172],[-36,-222],[-42,-247],[2,3],[-12,-122],[-54,-297],[6,-47],[-5,3],[-48,-272],[-4,-2],[3,-2],[0,2],[48,128],[4,3],[2,4]]", 18},
            new object[] {"[[-30,-197],[60,178],[30,53],[-42,-247],[-12,-122],[-54,-297],[6,-47],[-48,-272]]", 8},
            new object[] {"[[5151,5150],[0,0],[5152,5151]]", 2},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string pointsStr, int expected)
        {
            var points = ArrayHelper.MatrixFromString<int>(pointsStr);

            var sol = new Solution();
            var res = sol.MaxPoints(points);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}