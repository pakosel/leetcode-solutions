using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DataStreamAsDisjointIntervals
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases_GetInterval =
        {
            new object[] {"[[]]", 1, 0},
            new object[] {"[[1,1]]", 3, 1},
            new object[] {"[[3,4]]", 1, 0},
            new object[] {"[[1,1],[3,3]]", 7, 2},
            new object[] {"[[1,1],[7,7]]", 3, 1},
            new object[] {"[[1,1],[7,7]]", 2, 1},
            new object[] {"[[1,1],[3,3]]", 2, 1},
            new object[] {"[[1,3],[7,9]]", 2, 0},
            new object[] {"[[1,3],[7,9]]", 7, 1},
            new object[] {"[[1,3],[7,9]]", 8, 1},
            new object[] {"[[1,3],[7,9]]", 9, 1},
            new object[] {"[[1,3],[7,9]]", 10, 2},
            new object[] {"[[1,3],[7,9]]", 5, 1},
        };

        private static readonly object[] testCases =
        {
            new object[] {"[SummaryRanges,addNum,getIntervals,addNum,getIntervals,addNum,getIntervals,addNum,getIntervals,addNum,getIntervals]", "[[],[1],[],[3],[],[7],[],[2],[],[6],[]]", new string[] {null,null,"[[1,1]]",null,"[[1,1],[3,3]]",null,"[[1,1],[3,3],[7,7]]",null,"[[1,3],[7,7]]",null,"[[1,3],[6,7]]"}},
            new object[] {"[SummaryRanges,addNum,getIntervals,addNum,getIntervals,addNum,getIntervals,addNum,getIntervals,addNum,getIntervals,addNum,getIntervals,addNum,getIntervals]", "[[],[1],[],[3],[],[7],[],[2],[],[6],[],[5],[],[4],[]]", new string[] {null,null,"[[1,1]]",null,"[[1,1],[3,3]]",null,"[[1,1],[3,3],[7,7]]",null,"[[1,3],[7,7]]",null,"[[1,3],[6,7]]",null,"[[1,3],[5,7]]",null,"[[1,7]]"}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string commandsStr, string inputsStr, string[] expectedStr)
        {
            var commands = ArrayHelper.ArrayFromString<string>(commandsStr);
            var inputs = ArrayHelper.MatrixFromString<int>(inputsStr);
            var expected = Enumerable.Range(0, expectedStr.Length).Select(i => expectedStr[i] != null ? ArrayHelper.MatrixFromString<int>(expectedStr[i]) : null).ToArray();

            ClassicAssert.AreEqual(commands.Length, inputs.Length);
            ClassicAssert.AreEqual(commands.Length, expected.Length);
            
            var sol = new SummaryRanges();
            for(int i=0; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "addNum":
                        sol.AddNum(inputs[i][0]);
                        ClassicAssert.AreEqual(expected[i], null);
                        break;
                    case "getIntervals":
                        var res = sol.GetIntervals();
                        foreach(var it in res)
                            Console.Write($"[{it[0]},{it[1]}],");
                        Console.WriteLine();

                        CollectionAssert.AreEqual(expected[i], res);
                        break;
                    default:
                        ClassicAssert.AreEqual(expected[i], null);
                        break;
                }
        }

        [Test]
        [TestCaseSource("testCases_GetInterval")]
        public void Test_GetInterval(string intervalsStr, int num, int expected)
        {
            var intervals = ArrayHelper.MatrixFromString<int>(intervalsStr);

            var sol = new SummaryRanges(intervals);
            var res = sol.GetInterval(num);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}