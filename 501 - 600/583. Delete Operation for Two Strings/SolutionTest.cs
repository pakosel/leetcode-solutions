using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace DeleteOperationForTwoStrings
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "a", "b", 2 },
            new object[] { "a", "xyz", 4 },
            new object[] { "sea", "eat", 2 },
            new object[] { "a", "aaa", 2 },
            new object[] { "aaakhjsdfljkxxxxxlkjlkjlkjlkjbbb", "aakhjsdljkxxxxlkjlkjkjlkjbb", 5 },
            new object[] { "abcdef", "ghibj", 9 },
            new object[] { "idmciznflgnmltogiktnpobphxiucrojnrhrlyoanggjkftiaxmtugjhaimwyhbrfwpsedytsdmygydsjalzbbylwuffvgtxpcndlzmxnztxurnsdwbbsmykzcxcthpildrdmzjegmejmozscntkdlhheupekxswqeakoszdvyfrjkpmhowaekopjzqujimyisqdicfnxvcixlnwerhvoqluqccesstotknqsefyolxsfkyutwvrnrekuzcefuucikmyxuuurzsdsryqlqkjbfcrntnnhxhmisgyotsuhqvelucimmnqrwxxzrzbipcjkwqrohzujollavnitrsyxouryrlzjplcsiazlcdenawgwghshnfuivxvyyurrkkmbqnwgzpalgovftpigmdoklvqcjrvtausiuinxwhwxudbrfufgesvfxpnrlqlyyglaziqmifqgiqzvleesmgyrqenadabfudtldchnqbxgdjxxwasvkv", "sgnovlkpajzhbdaafwtvohoaoajnnddqwnwfxzzhoyknctwuklgskrktmhhvxyydgzbaskvibprbtdalstywrrbcwxvojgmmraebbtugsdgzutrqfdhniieglwicfwpclvqloakwfeflzonbelpblcctisyktkqrqoyotkvkipmtbfpvehwoospxbmazboacjpoafgqyeacndbfzprvbhrvqzreuybdbwlbefulexmqgjeqkcjrgbawrfposyydpxffjcwhljbvxajorjvxxgikjpfbyildmnhdfntulvwvdcfzipjlfrnwrbhsjgvnixuwvtomwsapapcxwnxdwnybnsztgrglsbfldsmrtupdmfbolcviivrofjwucfayuonxbefjutvllpypsefmftabmuywdiptrntptzsyuvftvauqrsgxvygffrmkvvolwskrgfrxunbudaystrypugjutoqhorgxmpvypftumdzijrgfqhlw", 690 },
            new object[] { "kchfpbgvfktzljsstxvknwmiwzoinfbzxovupttgqjmmdshggpfuqdbbpqxjdawhkksferiintkufbrwzfptwbzoktldpqaezcsiofrndxlmdkpqfuuxtgoibzbeowxfltafwoplmjeosqpqhahbovywoekhbsmcexujjuqnytslatcysjxginldpvohyclnmywfpodhjvzsgcdsjhyrryfhrymlyxmjbtwuwgwdjxudxxwptggosacwuqzbmlfkjotbpkbbowegyrruhawfpppbqrxkbebmfixxzuybkcrmjntkydqpdcfqjvbfhncxvdjyzokcalvgxjuwwsltbehsewsjlqpvkvieaqaprxehbmanopneoxesxdxweffhqceztqeoidqsntmdzybcyxbtfgnjlqzyzthexqjkrbrykjtvekcqainapnchbgoiiuipnizxyjffbzildnmgphykczweslpebrxlaolybojrrgavrpk", "kjxylgpcvtoxufswsgwfyhkfrqwhbizzycmynrdnqeaqwwirgxwgwvucpcgcfukitrlcevhvqdffmeqbcikvudblefjlhncnabewuwtreqruzpauqqkajihsulkwsmxfjpfkrawmzwkhxkaaxrthnujvhquqapcygyupwikypuedwureejjzrjrgtzwtwzswztftakcggmkcpusdztdxywxmzbdbfltdkrtmvqiipzfzolpzticizlcqlgfzqgmmlgvffgfzurcxaolpiavwocxylvgusmmrffnghheevqcqimdkzzbxvlithzcdnehzzstwcmzrxlcwfxxpwfxhlenhlgtqnpzdyltgimtksonsvkmuvqasvfwjrkknexhnouzlxqhspthpillmiksagzxephqakuxhvkosexxygwibcsyqlxgbtbnbtowumcalabxqdqgjodepohfuahtrgkiazqilqqvrfpduckdyaaxzbnehvhh", 686 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericDP(string word1, string word2, int expected)
        {
            var sol = new SolutionDP();
            var res = sol.MinDistance(word1, word2);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string word1, string word2, int expected)
        {
            var sol = new Solution();
            var res = sol.MinDistance(word1, word2);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Memoization(string word1, string word2, int expected)
        {
            var sol = new Solution_Memoization();
            var res = sol.MinDistance(word1, word2);

            Assert.That(expected == res);
        }
    }
}