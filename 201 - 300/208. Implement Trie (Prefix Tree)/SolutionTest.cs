using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace ImplementTriePrefixTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"Trie", "insert", "search", "search", "startsWith", "insert", "search"}, new string[] {null,"apple","apple","app","app","app","app"}, new bool?[] {null, null, true, false, true, null, true} },
            new object[] {new string[] {"Trie", "insert", "search", "search", "startsWith", "insert", "search","startsWith"}, new string[] {null,"apple","apple","app","app","app","app","apple"}, new bool?[] {null, null, true, false, true, null, true, true} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] instructions, string[] inputs, bool?[] expected)
        {
            Assert.That(instructions.Length == inputs.Length);
            Assert.That(expected.Length == inputs.Length);

            var sol = new Trie();
            for(int i=1; i<instructions.Length; i++)
            {
                switch(instructions[i])
                {
                    case "insert":
                        sol.Insert(inputs[i]);
                        break;
                    case "search":
                        ClassicAssert.AreEqual(sol.Search(inputs[i]), expected[i]);
                        break;
                    case "startsWith":
                        ClassicAssert.AreEqual(sol.StartsWith(inputs[i]), expected[i]);
                        break;
                }
            }
        }

    }
}