using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;
using System;

namespace SmallestNumberInInfiniteSet
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[SmallestInfiniteSet,addBack,popSmallest,popSmallest,popSmallest,addBack,popSmallest,popSmallest,popSmallest]", "[[],[2],[],[],[],[1],[],[],[]]", "[null,null,1,2,3,null,1,4,5]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string commandsStr, string argsStr, string expectedStr)
        {
            var commands = ArrayHelper.ArrayFromString<string>(commandsStr);
            var args = ArrayHelper.MatrixFromString<int>(argsStr);
            var expected = ArrayHelper.ArrayFromString<int?>(expectedStr);

            Assert.That(commands.Length == args.Length);
            Assert.That(commands.Length == expected.Length);            

            var res = new object[expected.Length];
            var sol = new SmallestInfiniteSet();
            for(int i=0; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "SmallestInfiniteSet":
                        break;
                    case "addBack":
                    {
                        sol.AddBack(args[i][0]);
                        break;
                    }
                    case "popSmallest":
                    {
                        res[i] = sol.PopSmallest();
                        break;
                    }
                }

            CollectionAssert.AreEqual(expected, res);
        }
    }
}