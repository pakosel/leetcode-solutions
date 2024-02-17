using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace OrderlyQueue

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"cba", 1, "acb"},
            new object[] {"baaca", 3, "aaabc"},
            new object[] {"ehtvoedhfjrmapwhwikggrscbkmlpothgncxmzccugvghgnageseydkzgxckfcwlefeosbvkdylepttmkpcehtveayahcnlppmhpkjpfknrsqourycqiplncrppknljfcoxkzpkqviilsvtwzhgwgctufljztqgjsxysavmbadddfdbbhjadahzijebdkpzrlqbffmkrnogqrydbsalagjtoelkzrkbwbvejgzkwpspypvapfhaaxgqkwrpgzlxvebnipcapjyrptgekyqdknfeawgxsgxdaiboqbvvvcvogmjestwuvcevpztqbtcpkhdlwcdtzafsurbjwybpddlktkhcmgxfnndrwxyvuohbmbwcokyryo", 77, "aaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbcccccccccccccccccccdddddddddddddddddeeeeeeeeeeeeeeeeefffffffffffffggggggggggggggggggggghhhhhhhhhhhhhhhiiiiiiijjjjjjjjjjjjkkkkkkkkkkkkkkkkkkkkkkkllllllllllllllmmmmmmmmmmnnnnnnnnnnnooooooooooooppppppppppppppppppppppppqqqqqqqqqqrrrrrrrrrrrrrrsssssssssssstttttttttttttttuuuuuuvvvvvvvvvvvvvvvvvwwwwwwwwwwwwwwxxxxxxxxxxyyyyyyyyyyyyyzzzzzzzzzzzz"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, int k, string expected)
        {
            var sol = new Solution();
            var res = sol.OrderlyQueue(s, k);

            Assert.That(expected == res);
        }
    }
}