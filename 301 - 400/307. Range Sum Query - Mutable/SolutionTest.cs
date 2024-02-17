using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RangeSumQueryMutable
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[NumArray,sumRange,update,sumRange]", "[[1,3,5],[0,2],[1,2],[0,2]]", "[null,9,null,8]"},
            new object[] {"[NumArray,sumRange,sumRange]", "[[1,3,5,6],[0,2],[1,3]]", "[null,9,14]"},
            new object[] {"[NumArray,sumRange,sumRange,sumRange,sumRange,sumRange,sumRange,sumRange,sumRange,sumRange,sumRange]", "[[1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21],[4,20],[5,5],[5,7],[4,20],[5,5],[5,7],[4,20],[5,5],[5,7],[5,7]]", "[null,221,6,21,221,6,21,221,6,21,21]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string commandsStr, string inputsStr, string expectedStr)
        {
            var commands = ArrayHelper.ArrayFromString<string>(commandsStr);
            var inputs = ArrayHelper.MatrixFromString<int>(inputsStr);
            var expected = ArrayHelper.ArrayFromString<int?>(expectedStr);
            Assert.That(commands.Length == inputs.Length);
            Assert.That(commands.Length == expected.Length);
            
            var res = new int?[commands.Length];
            NumArray sol = null;
            for(int i=0; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "NumArray":
                        sol = new NumArray(inputs[i]);
                        break;
                    case "update":
                        sol.Update(inputs[i][0], inputs[i][1]);
                        break;
                    case "sumRange":
                        res[i] = sol.SumRange(inputs[i][0], inputs[i][1]);
                        break;
                }

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}