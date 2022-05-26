using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DetectSquares
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {new string[] {"add", "add", "add", "count", "count", "add", "count"}, "[[3, 10], [11, 2], [3, 2], [11, 10], [14, 8], [11, 2], [11, 10]]", new int?[] {null, null, null, 1, 0, null, 2}},
            new object[] {new string[] {"add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count"}, "[[5,10],[10,5],[10,10],[5,5],[3,0],[8,0],[8,5],[3,5],[9,0],[9,8],[1,8],[1,0],[0,0],[8,0],[8,8],[0,8],[1,9],[2,9],[2,10],[1,10],[7,8],[2,3],[2,8],[7,3],[9,10],[9,5],[4,5],[4,10],[0,9],[4,5],[4,9],[0,5],[1,10],[10,1],[10,10],[1,1],[10,0],[2,0],[2,8],[10,8],[7,6],[4,6],[4,9],[7,9],[10,9],[10,0],[1,0],[1,9],[0,9],[8,1],[0,1],[8,9],[3,9],[10,9],[3,2],[10,2],[3,8],[9,2],[3,2],[9,8],[0,9],[7,9],[0,2],[7,2],[10,1],[1,10],[10,10],[1,1],[6,10],[2,6],[6,6],[2,10],[6,0],[6,2],[8,2],[8,0],[6,5],[7,4],[6,4],[7,5],[2,10],[8,4],[2,4],[8,10],[2,6],[2,5],[1,5],[1,6],[10,9],[10,0],[1,9],[1,0],[0,9],[5,9],[0,4],[5,4],[3,6],[9,0],[3,0],[9,6],[0,2],[1,1],[0,1],[1,2],[1,7],[8,0],[8,7],[1,0],[2,7],[4,5],[2,5],[4,7],[6,7],[3,7],[6,4],[3,4],[10,2],[2,10],[2,2],[10,10],[10,1],[1,10],[1,1],[10,10],[2,10],[2,9],[3,9],[3,10],[10,1],[1,10],[1,1],[10,10],[10,4],[10,3],[9,4],[9,3],[6,6],[6,10],[10,6],[10,10],[9,7],[4,7],[9,2],[4,2],[2,3],[2,1],[0,3],[0,1],[2,8],[10,8],[2,0],[10,0],[8,4],[2,10],[8,10],[2,4],[0,0],[9,9],[0,9],[9,0],[5,7],[5,8],[4,7],[4,8],[10,10],[10,1],[1,1],[1,10],[6,8],[7,8],[6,9],[7,9],[4,6],[1,6],[4,3],[1,3],[10,1],[1,10],[10,10],[1,1],[7,7],[7,10],[4,7],[4,10],[0,0],[8,0],[0,8],[8,8],[3,5],[2,4],[3,4],[2,5],[0,6],[0,2],[4,2],[4,6],[5,2],[9,6],[9,2],[5,6],[1,1],[1,10],[10,10],[10,1],[7,5],[2,0],[2,5],[7,0],[1,9],[1,2],[8,2],[8,9],[3,8],[3,3],[8,3],[8,8],[3,10],[9,10],[3,4],[9,4],[0,2],[0,10],[8,10],[8,2],[9,4],[8,4],[8,5],[9,5],[9,8],[4,3],[4,8],[9,3],[4,9],[0,5],[0,9],[4,5],[1,3],[3,5],[1,5],[3,3],[0,0],[0,8],[8,0],[8,8],[2,8],[10,0],[10,8],[2,0],[8,1],[0,9],[8,9],[0,1],[4,9],[4,6],[1,9],[1,6],[0,9],[0,8],[1,9],[1,8],[5,1],[5,6],[10,1],[10,6],[9,2],[2,2],[2,9],[9,9],[5,5],[8,5],[5,8],[8,8],[8,0],[1,0],[8,7],[1,7],[8,2],[5,5],[5,2],[8,5],[6,6],[6,8],[8,6],[8,8],[2,10],[10,2],[2,2],[10,10],[1,9],[8,2],[1,2],[8,9],[7,4],[7,2],[9,4],[9,2],[1,9],[1,0],[10,0],[10,9],[2,10],[2,3],[9,10],[9,3],[10,0],[1,0],[1,9],[10,9],[8,10],[1,10],[1,3],[8,3],[0,9],[9,9],[0,0],[9,0],[7,9],[8,9],[7,8],[8,8],[3,1],[9,7],[9,1],[3,7],[5,9],[6,9],[5,8],[6,8],[0,1],[0,10],[9,10],[9,1],[8,0],[8,2],[10,2],[10,0],[8,0],[0,8],[8,8],[0,0],[6,7],[5,8],[5,7],[6,8],[0,9],[0,2],[7,9],[7,2],[5,0],[5,5],[10,0],[10,5],[1,10],[10,10],[10,1],[1,1],[9,2],[9,10],[1,2],[1,10],[1,10],[10,1],[10,10],[1,1],[9,9],[0,9],[0,0],[9,0],[9,6],[9,3],[6,3],[6,6],[10,4],[6,0],[10,0],[6,4],[6,8],[0,2],[0,8],[6,2],[7,9],[0,9],[7,2],[0,2],[9,1],[9,10],[0,10],[0,1],[10,0],[10,9],[1,9],[1,0],[1,6],[1,9],[4,9],[4,6],[0,8],[1,9],[0,9],[1,8],[1,1],[9,1],[1,9],[9,9],[2,5],[2,9],[6,5],[6,9],[7,3],[2,3],[2,8],[7,8],[9,4],[4,4],[9,9],[4,9],[4,4],[2,4],[4,2],[2,2],[0,3],[0,2],[1,3],[1,2],[10,9],[10,2],[3,2],[3,9],[5,6],[10,6],[10,1],[5,1],[9,0],[0,9],[9,9],[0,0],[5,6],[9,2],[9,6],[5,2],[3,3],[10,3],[10,10],[3,10],[2,4],[2,10],[8,4],[8,10],[4,9],[1,9],[4,6],[1,6],[1,8],[9,0],[1,0],[9,8],[10,3],[5,8],[5,3],[10,8],[8,2],[0,10],[8,10],[0,2],[9,0],[2,7],[9,7],[2,0],[0,4],[5,9],[0,9],[5,4],[5,3],[10,3],[5,8],[10,8],[6,4],[7,4],[6,5],[7,5],[9,1],[0,1],[9,10],[0,10],[5,10],[5,7],[8,7],[8,10],[8,0],[8,7],[1,7],[1,0],[1,1],[9,9],[1,9],[9,1],[3,1],[3,5],[7,5],[7,1],[5,8],[5,3],[10,8],[10,3],[0,9],[2,7],[2,9],[0,7],[9,3],[9,7],[5,3],[5,7],[0,0],[9,0],[9,9],[0,9],[6,4],[4,2],[4,4],[6,2],[1,9],[1,5],[5,5],[5,9],[7,7],[0,7],[0,0],[7,0],[1,3],[1,9],[7,3],[7,9],[0,9],[9,9],[9,0],[0,0],[1,8],[3,6],[3,8],[1,6]]", new int?[] {null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,2,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,2,null,null,null,2,null,null,null,2,null,null,null,2,null,null,null,5,null,null,null,6,null,null,null,2,null,null,null,3,null,null,null,3,null,null,null,14,null,null,null,3,null,null,null,1,null,null,null,2,null,null,null,2,null,null,null,4,null,null,null,20,null,null,null,4,null,null,null,5,null,null,null,10,null,null,null,26,null,null,null,8,null,null,null,3,null,null,null,7,null,null,null,21,null,null,null,20,null,null,null,52,null,null,null,6,null,null,null,56,null,null,null,2,null,null,null,5,null,null,null,17,null,null,null,18,null,null,null,13,null,null,null,19,null,null,null,102,null,null,null,9,null,null,null,2,null,null,null,157,null,null,null,23,null,null,null,29,null,null,null,23,null,null,null,15,null,null,null,24,null,null,null,186,null,null,null,12,null,null,null,32,null,null,null,36,null,null,null,10,null,null,null,35,null,null,null,20,null,null,null,43,null,null,null,48,null,null,null,35,null,null,null,73,null,null,null,59,null,null,null,56,null,null,null,72,null,null,null,198,null,null,null,37,null,null,null,145,null,null,null,130,null,null,null,45,null,null,null,68,null,null,null,172,null,null,null,281,null,null,null,147,null,null,null,53,null,null,null,160,null,null,null,105,null,null,null,253,null,null,null,82,null,null,null,103,null,null,null,248,null,null,null,75,null,null,null,86,null,null,null,312,null,null,null,301,null,null,null,273,null,null,null,119,null,null,null,191,null,null,null,61,null,null,null,584,null,null,null,696,null,null,null,802,null,null,null,293,null,null,null,104,null,null,null,114,null,null,null,242,null,null,null,259,null,null,null,300,null,null,null,465,null,null,null,180,null,null,null,1082,null,null,null,697,null,null,null,187,null,null,null,113,null,null,null,201,null,null,null,520,null,null,null,652,null,null,null,197,null,null,null,91,null,null,null,670,null,null,null,159,null,null,null,189,null,null,null,386,null,null,null,403,null,null,null,204,null,null,null,301,null,null,null,378,null,null,null,314,null,null,null,292,null,null,null,352,null,null,null,174,null,null,null,2778,null,null,null,473,null,null,null,869,null,null,null,1568,null,null,null,190,null,null,null,198,null,null,null,342,null,null,null,286,null,null,null,1062,null,null,null,475,null,null,null,354,null,null,null,174,null,null,null,574,null,null,null,1605,null,null,null,547}},
            new object[] {new string[] {"add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add","add","add","count","add"}, "[[229,355],[229,491],[365,491],[365,355],[452,647],[452,297],[802,647],[802,297],[33,359],[494,359],[494,820],[33,820],[8,110],[8,940],[838,940],[838,110],[92,887],[530,449],[92,449],[530,887],[561,544],[829,812],[829,544],[561,812],[412,442],[192,442],[412,222],[192,222],[926,177],[860,177],[926,111],[860,111],[11,962],[11,9],[964,9],[964,962],[169,199],[169,981],[951,981],[951,199],[420,822],[420,901],[341,901],[341,822],[793,806],[98,806],[98,111],[793,111],[898,92],[898,899],[91,92],[91,899],[418,214],[669,214],[669,465],[418,465],[997,20],[997,921],[96,921],[96,20],[291,735],[884,735],[291,142],[884,142],[956,450],[956,65],[571,65],[571,450],[577,890],[661,890],[577,806],[661,806],[695,111],[504,302],[504,111],[695,302],[628,772],[46,190],[628,190],[46,772],[834,216],[60,216],[834,990],[60,990],[126,868],[978,868],[978,16],[126,16],[724,44],[430,44],[724,338],[430,338],[193,16],[992,16],[193,815],[992,815],[925,29],[745,209],[925,209],[745,29],[454,225],[360,131],[360,225],[454,131],[935,22],[935,898],[59,22],[59,898],[793,242],[939,388],[793,388],[939,242],[133,268],[133,970],[835,970],[835,268],[86,80],[86,930],[936,930],[936,80],[30,30],[30,984],[984,30],[984,984],[728,469],[541,469],[541,656],[728,656],[16,0],[998,0],[998,982],[16,982],[272,48],[272,505],[729,505],[729,48],[223,737],[74,588],[74,737],[223,588],[875,302],[952,225],[952,302],[875,225],[924,781],[924,103],[246,103],[246,781],[281,294],[570,5],[281,5],[570,294],[801,153]]", new int?[] {null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null,null,null,1,null}},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string[] commands, string inputsStr, int?[] expected)
        {
            var inputs = ArrayHelper.MatrixFromString<int>(inputsStr);
            Assert.AreEqual(inputs.Length, commands.Length);
            Assert.AreEqual(expected.Length, commands.Length);

            var res = new List<int?>();
            var sol = new DetectSquares();
            for(int i=0; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "add":
                        sol.Add(inputs[i]);
                        res.Add(null);
                        break;
                    case "count":
                        res.Add(sol.Count(inputs[i]));
                        break;
                }

            CollectionAssert.AreEqual(res, expected);
        }
    }
}