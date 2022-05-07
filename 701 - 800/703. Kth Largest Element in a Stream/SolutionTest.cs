using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace KthLargestElementInStream
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"add", "add", "add", "add", "add"}, 3, "[4, 5, 8, 2]", "[3, 5, 10, 9, 4]", "[4,5,5,8,8]"},
            new object[] {new string[] {"add", "add", "add", "add", "add"}, 3, "[7,7,7]", "[1,1,1,1,1]", "[7,7,7,7,7]"},
            
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] commands, int k, string initStr, string argsStr, string expectedStr)
        {
            var init = ArrayHelper.ArrayFromString(initStr);
            var args = ArrayHelper.ArrayFromString(argsStr);
            var expected = ArrayHelper.ArrayFromString(expectedStr);

            Assert.AreEqual(commands.Length, expected.Length);
            Assert.AreEqual(args.Length, expected.Length);

            var sol = new KthLargest(k, init);
            for(int i=0; i<commands.Length; i++)
            {
                var cmd = commands[i];
                switch(cmd)
                {
                    case "add":
                        var res = sol.Add(args[i]);
                        Assert.AreEqual(res, expected[i]);
                        break;
                }
            }
        }
    }
}