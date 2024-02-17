using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CompareStringsByFrequencyOfTheSmallestCharacter

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[bbb,cc,a]", "[aa,aa,aaa,aaaa]", "[1,2,4]"},
            new object[] {"[bba,abaaaaaa,aaaaaa,bbabbabaab,aba,aa,baab,bbbbbb,aab,bbabbaabb]", "[aaabbb,aab,babbab,babbbb,b,bbbbbbbbab,a,bbbbbbbbbb,baaabbaab,aa]", "[6,1,1,2,3,3,3,1,3,2]"},
            new object[] {"[cbd]", "[zaaaz]", "[1]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string queriesStr, string wordsStr, string expectedStr)
        {
            var queries = ArrayHelper.ArrayFromString<string>(queriesStr);
            var words = ArrayHelper.ArrayFromString<string>(wordsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.NumSmallerByFrequency(queries, words);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}