using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace DesignAddAndSearchWordsDataStructure
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"addWord","addWord","addWord","search","search","search","search"}, new string[] {"bad","dad","mad","pad","bad",".ad","b.."}, new bool?[] {null,null,null,false,true,true,true} },
            new object[] {new string[] {"addWord","addWord","addWord","search","search","search","search","search","search"}, new string[] {"bad","dad","mad","pad","bad",".ad","b..",".","....."}, new bool?[] {null,null,null,false,true,true,true,false,false} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] instructions, string[] inputs, bool?[] expected)
        {
            ClassicAssert.AreEqual(instructions.Length, inputs.Length);
            ClassicAssert.AreEqual(expected.Length, inputs.Length);

            var sol = new WordDictionary();
            for(int i=0; i<instructions.Length; i++)
            {
                switch(instructions[i])
                {
                    case "addWord":
                        sol.AddWord(inputs[i]);
                        break;
                    case "search":
                        var res = sol.Search(inputs[i]);
                        ClassicAssert.AreEqual(res, expected[i]);
                        break;
                }
            }
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic_2023(string[] instructions, string[] inputs, bool?[] expected)
        {
            ClassicAssert.AreEqual(instructions.Length, inputs.Length);
            ClassicAssert.AreEqual(expected.Length, inputs.Length);

            var sol = new WordDictionary_2023();
            for(int i=0; i<instructions.Length; i++)
            {
                switch(instructions[i])
                {
                    case "addWord":
                        sol.AddWord(inputs[i]);
                        break;
                    case "search":
                        var res = sol.Search(inputs[i]);
                        ClassicAssert.AreEqual(res, expected[i]);
                        break;
                }
            }
        }
    }
}