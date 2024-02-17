using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumFrequencyStack
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {new string[] {"push", "push", "push", "push", "push", "push", "pop", "pop", "pop", "pop"}, "[[5], [7], [5], [7], [4], [5], [], [], [], []]", "[null,null,null,null,null,null,5,7,5,4]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string[] commands, string argsStr, string expectedStr)
        {
            var args = ArrayHelper.MatrixFromString<int>(argsStr);
            var expected = ArrayHelper.ArrayFromString<int?>(expectedStr);
            Assert.That(commands.Length == args.Length);
            Assert.That(commands.Length == expected.Length);

            var sol = new FreqStack();
            for(int i=0; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "push":
                        sol.Push(args[i][0]);
                        break;
                    case "pop":
                        ClassicAssert.AreEqual(sol.Pop(), expected[i]);
                        break;
                }
        }
    }
}