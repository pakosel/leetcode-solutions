using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SnapshotArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[SnapshotArray,set,snap,set,get]", "[[3],[0,5],[],[0,6],[0,0]]", "[null,null,0,null,5]"},
            new object[] {"[SnapshotArray,set,snap,snap,snap,get,snap,snap,get]", "[[1],[0,15],[],[],[],[0,2],[],[],[0,0]]", "[null,null,0,1,2,15,3,4,15]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string commandsStr, string argsStr, string expectedStr)
        {
            var commands = ArrayHelper.ArrayFromString<string>(commandsStr);
            var args = ArrayHelper.MatrixFromString<int>(argsStr);
            var expected = ArrayHelper.ArrayFromString<int?>(expectedStr);
            
            Assert.AreEqual(commands.Length, args.Length);
            Assert.AreEqual(commands.Length, expected.Length);

            var sol = new SnapshotArray(args[0][0]);
            var res = new int?[args.Length];
            for(int i=1; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "set":
                        sol.Set(args[i][0], args[i][1]);
                        break;
                    case "get":
                        res[i] = sol.Get(args[i][0], args[i][1]);
                        break;
                    case "snap":
                        res[i] = sol.Snap();
                        break;
                }

            CollectionAssert.AreEquivalent(expected, res);
        }
    }
}