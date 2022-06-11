using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SuccessfulPairsOfSpellsAndPotions
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[5,1,3]", "[1,2,3,4,5]", 7, "[4,0,3]"},
            new object[] {"[3,1,2]", "[8,5,8]", 16, "[2,0,2]"},
            new object[] {"[40,11,24,28,40,22,26,38,28,10,31,16,10,37,13,21,9,22,21,18,34,2,40,40,6,16,9,14,14,15,37,15,32,4,27,20,24,12,26,39,32,39,20,19,22,33,2,22,9,18,12,5]", "[31,40,29,19,27,16,25,8,33,25,36,21,7,27,40,24,18,26,32,25,22,21,38,22,37,34,15,36,21,22,37,14,31,20,36,27,28,32,21,26,33,37,27,39,19,36,20,23,25,39,40]", 600, "[48,0,32,37,48,22,33,47,37,0,43,6,0,46,0,21,0,22,21,14,46,0,48,48,0,6,0,0,0,3,46,3,45,0,34,20,32,0,33,47,45,47,20,18,22,45,0,22,0,14,0,0]"},
            new object[] {"[13,22,21,13,11,9,13,35,7,38,10,10,38,19,3,16,13,24,16,27,20,24,32,5,16,35,24,2,25,32,20,22,22,3,35,39,27,26,25,21,27,40,15,17,24,40,35,27,20,40,9,35,27,19,15,34,35,37,17,40,8,3,33,39,29,22,30,1,37,2,16,30,32,31,24,6,34,26,36,4,21,2,29,31,3,27,6,24,40,18]", "[33,16,35,14,26,23,23,2,37,23,15,20,25,34,23,29,4,18,26,24,16,37,15,11,33,24,12,13,7,24,3,26,1,3,38,33,19,3,34,22,30,39,18,7,21,4,33,18,39,5,34,14,32,5,20,22,5,25,15]", 533, "[0,21,19,0,0,0,0,39,0,42,0,0,42,16,0,9,0,28,9,33,16,28,37,0,9,39,28,0,30,37,16,21,21,0,39,44,33,31,30,19,33,44,5,14,28,44,39,33,16,44,0,39,33,16,5,39,39,42,14,44,0,0,37,44,34,21,37,0,42,0,9,37,37,37,28,0,39,31,42,0,19,0,34,37,0,33,0,28,44,15]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string spellsStr, string potionsStr, long success, string expectedStr)
        {
            var spells = ArrayHelper.ArrayFromString<int>(spellsStr);
            var potions = ArrayHelper.ArrayFromString<int>(potionsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            Assert.AreEqual(spells.Length, expected.Length);

            var sol = new Solution();
            var res = sol.SuccessfulPairs(spells, potions, success);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}