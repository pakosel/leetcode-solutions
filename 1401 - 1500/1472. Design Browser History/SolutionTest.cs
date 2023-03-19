using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace DesignBrowserHistory
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"BrowserHistory","visit","visit","visit","back","back","forward","visit","forward","back","back"}, new object[] {"leetcode.com","google.com","facebook.com","youtube.com",1,1,1,"linkedin.com",2,2,7}, new string[] {null,null,null,null,"facebook.com","google.com","facebook.com",null,"linkedin.com","google.com","leetcode.com"} },
            new object[] {new string[] {"BrowserHistory","visit","visit","visit","back","back","forward","visit","forward","back","back","forward"}, new object[] {"leetcode.com","google.com","facebook.com","youtube.com",1,1,1,"linkedin.com",2,2,7,77}, new string[] {null,null,null,null,"facebook.com","google.com","facebook.com",null,"linkedin.com","google.com","leetcode.com","linkedin.com"} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] instructions, object[] inputs, string[] expected)
        {
            Assert.AreEqual(instructions.Length, inputs.Length);
            Assert.AreEqual(expected.Length, inputs.Length);

            var sol = new BrowserHistory((string)inputs[0]);
            for(int i=1; i<instructions.Length; i++)
            {
                switch(instructions[i])
                {
                    case "visit":
                        sol.Visit((string)inputs[i]);
                        break;
                    case "back":
                        Assert.AreEqual(sol.Back((int)inputs[i]), expected[i]);
                        break;
                    case "forward":
                        Assert.AreEqual(sol.Forward((int)inputs[i]), expected[i]);
                        break;
                }
            }
        }

    }
}