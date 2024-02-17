using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DesignNumberContainerSystem
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[find,change,change,change,change,find,change,find]", "[[10],[2,10],[1,10],[3,10],[5,10],[10],[1,20],[10]]", "[-1,null,null,null,null,1,null,2]"},
            new object[] {"[change,change,change,change,change,change,change,change,change,change,change,change,find,find,find,find,find,find,find,find,find,find,find,find,find,find,find,find]", "[[916631618,1],[62250878,1],[714001470,1],[469439395,1],[521119966,1],[633452675,1],[863060782,1],[237340860,1],[896922243,1],[367602738,1],[884156302,1],[790852102,1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1]]", "[null,null,null,null,null,null,null,null,null,null,null,null,62250878,62250878,62250878,62250878,62250878,62250878,62250878,62250878,62250878,62250878,62250878,62250878,62250878,62250878,62250878,62250878]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string commandsStr, string inputsStr, string expectedStr)
        {
            var commands = ArrayHelper.ArrayFromString<string>(commandsStr);
            var inputs = ArrayHelper.MatrixFromString<int>(inputsStr);
            var expected = ArrayHelper.ArrayFromString<int?>(expectedStr);
            Assert.That(commands.Length == inputs.Length);
            Assert.That(commands.Length == expected.Length);
            
            var res = new int?[commands.Length];
            var sol = new NumberContainers();
            for(int i=0; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "find":
                        res[i] = sol.Find(inputs[i][0]);
                        break;
                    case "change":
                        sol.Change(inputs[i][0], inputs[i][1]);
                        break;
                }

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}