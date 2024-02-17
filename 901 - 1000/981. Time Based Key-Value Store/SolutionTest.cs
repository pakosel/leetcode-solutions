using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;
using System;

namespace TimeBasedKeyValueStore
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[TimeMap,set,get,get,set,get,get]","[[],[foo,bar,1],[foo,1],[foo,3],[foo,bar2,4],[foo,4],[foo,5]]", "[null,null,bar,bar,null,bar2,bar2]"},
            new object[] {"[TimeMap,set,get,get,set,get,get]", "[[],[foo,bar,2],[foo,1],[foo,3],[foo,bar2,4],[foo,4],[foo,5]]", "[null,null,,bar,null,bar2,bar2]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string commandsStr, string argsStr, string expectedStr)
        {
            var commands = ArrayHelper.ArrayFromString<string>(commandsStr);
            var args = ArrayHelper.MatrixFromString<string>(argsStr, true);
            var expected = ArrayHelper.ArrayFromString<string>(expectedStr);

            Assert.That(commands.Length == args.Length);
            Assert.That(commands.Length == expected.Length);

            var res = new string[expected.Length];
            var sol = new TimeMap();
            for(int i=1; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "set":
                    {
                        var timestamp = int.Parse(args[i][2]);
                        sol.Set(args[i][0], args[i][1], timestamp);
                        break;
                    }
                    case "get":
                    {
                        var timestamp = int.Parse(args[i][1]);
                        var get = sol.Get(args[i][0], timestamp);
                        Assert.That(expected[i] == get);
                        break;
                    }
                }
        }
    }
}