using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LruCache
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[LRUCache,put,put,get,put,get,put,get,get,get]", "[[2],[1,1],[2,2],[1],[3,3],[2],[4,4],[1],[3],[4]]", "[null,null,null,1,null,-1,null,-1,3,4]"},
            new object[] {"[LRUCache,put,put,get,put,put,get,put,get,get,get]", "[[2],[1,1],[2,2],[1],[2,2],[3,3],[2],[4,4],[1],[3],[4]]", "[null,null,null,1,null,null,2,null,-1,-1,4]"},
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

            var sol = new LRUCache(args[0][0]);
            var res = new int?[args.Length];
            for(int i=1; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "put":
                        sol.Put(args[i][0], args[i][1]);
                        break;
                    case "get":
                        res[i] = sol.Get(args[i][0]);
                        break;
                }

            CollectionAssert.AreEquivalent(expected, res);
        }
    }
}