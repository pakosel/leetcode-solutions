using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumInsertionStepsToMakeStringPalindrome
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"a", 0},
            new object[] {"ab", 1},
            new object[] {"zzazz", 0},
            new object[] {"mbadm", 2},
            new object[] {"leetcode", 5},
            new object[] {"aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 0},
            new object[] {"slqbhxhhvjfzhgectuhrsjhrzuyxyvqfloumyzvgtduoibnsqbvqsgnqyldnvtluujdggsxjqhkulxvwnrblvyncxrizmznspxlpqagtfkzqlydftawxigjyjthdarqgcdatvsiavzeumgmneugcrqrvdfyjbyvzwynpdwdxuuzakebpmnetjopeupbhhzkkjqzuleeozzdxjqnrfaxhofpjgyahoyrvmhphueprzmlaguufrtbjmmwnnojeoyanbvtmchrfaejkbnqlsjcqhpxpnweqxtquisdxlgknsrpwahodnupavrohofrdfslleixphfiqgcjjgelahqttivscrmsdhszxjequofjgzlorkxblnabzmogpqhhmgjpdsqcwesgtvyivajyujcfrucfqskafoahxghjxcjzhcullnncdnszvvnvfquchwugsnyjsbdqwddmcnrdiorfufwhtudrlsqvnawdnnkwrnofhbngwubem", 339},
            new object[] {"ifrgvcejgxverhxstfyyrogrtxgmmyxiqlfkmetailcmmvdtnyzggspuycsrxlrqeloxjaixpmuxjkzyqjgeikpoobxflaengalxfstjxpikmwmcfwrcnskttxbiyyzrmnxlgcznjrwbybdnaealwttmtnotxazbczdgfudumxfppsydienjmrmylfpgxagqbnbqajlprnevktujfopyzfynmpdfsgqetljctfspfhxdccplfspggnjbbxftqgvhovbwgmbjwgmcqowmtbevspymihelifbpkfvvjaovsvpmheasymqnobvjhmvcxskggksgyzdfqokynpvfcraveesbdisnnzisixfkaaouyxdgknbpuwfkkxsdtjgklhzpqbmkjfiteofzxicaiuyzrwrmrxyzrftdbraqrzwkhjnvbjuycvmdxgdrgdlfxijtlclbpnzegkxurddqiykjhzpblfqaquwzxnxewbkkewvjvgvcpxoy", 337},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.MinInsertions(s);

            Assert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericRanges(string s, int expected)
        {
            var sol = new Solution_Ranges();
            var res = sol.MinInsertions(s);

            Assert.AreEqual(expected, res);
        }
    }
}