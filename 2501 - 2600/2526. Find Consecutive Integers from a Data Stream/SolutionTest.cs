using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindConsecutiveIntegersFromDataStream
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[DataStream,consec,consec,consec,consec]", "[[4,3],[4],[4],[4],[3]]", "[false, false, false, true, false]"},
            new object[] {"[DataStream,consec,consec,consec,consec]", "[[4,3],[4],[4],[4],[4]]", "[false,false,false,true,true]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string commandsStr, string argsStr, string expectedStr)
        {
            var commands = ArrayHelper.ArrayFromString<string>(commandsStr);
            var args = ArrayHelper.MatrixFromString<int>(argsStr);
            var expected = ArrayHelper.ArrayFromString<bool>(expectedStr);

            Assert.That(commands.Length == args.Length);
            Assert.That(commands.Length == expected.Length);            

            var res = new bool[expected.Length];
            DataStream sol = null;
            for(int i=0; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "DataStream":
                    {
                        sol = new DataStream(args[i][0], args[i][1]);
                        break;
                    }
                    case "consec":
                    {
                        res[i] = sol.Consec(args[i][0]);
                        break;
                    }
                }

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}