using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;
using System;

namespace ImplementQueueUsingStacks
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[push,push,peek,pop,empty]", "[[1], [2], [], [], []]", new object[] {null, null, 1, 1, false}},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string commandsStr, string argsStr, object[] expected)
        {
            var commands = ArrayHelper.ArrayFromString<string>(commandsStr);
            var args = ArrayHelper.MatrixFromString<int>(argsStr);

            ClassicAssert.AreEqual(commands.Length, args.Length);
            ClassicAssert.AreEqual(commands.Length, expected.Length);            

            var res = new object[expected.Length];
            var sol = new MyQueue();
            for(int i=0; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "push":
                    {
                        sol.Push(args[i][0]);
                        break;
                    }
                    case "pop":
                    {
                        res[i] = sol.Pop();
                        break;
                    }
                    case "peek":
                    {
                        res[i] = sol.Peek();
                        break;
                    }
                    case "empty":
                    {
                        res[i] = sol.Empty();
                        break;
                    }
                }

            CollectionAssert.AreEqual(expected, res);
        }
    }
}