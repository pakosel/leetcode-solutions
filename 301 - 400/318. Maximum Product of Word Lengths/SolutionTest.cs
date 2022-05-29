using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumProductOfWordLengths
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"abcw","baz","foo","bar","xtfn","abcdef"}, 16},
            new object[] {new string[] {"a","ab","abc","d","cd","bcd","abcd"}, 4},
            new object[] {new string[] {"a","aa","aaa","aaaa"}, 0},
            new object[] {new string[] {"snubwfsphikfxjwyffsweqtovltpuqrawmqbmfwc","xaerkplwihxjpinxxtymhbteuuifxqtgfemmeww","cpobqjjdzykjxsvsvlcurswzpgam","tkigkhxbgqnuzrpckoeo","gyzhrkafgfrqdvtcvmuy","htoasvpaxoxgjeybqadp","mnskiasydyahfbvwsflj","aaaa","xgwpdewauotqpilbojeu","trmseatgkjloeunqnxia","yphtalnspmxwbeibkzky","wbpletvjpnvvtoivwkix","avemnwpdmhjlbcdwhbxu","yxhposxpciibufhvsilr","gvueabhcpefvaqzqrtqf","fspxdqjcvyllhvydfvqe","otuwxrbtbykpedskjmtc","jakfstkbwpvsabkvhyos","atickntbyipykazuahmk","gcrkjfgrodwhrxwaashd","gphpeediqksruvcxrwrs","rnastxvjkgvkzvjhjblb","lrrshhlueiaiodezyxlijpdsdzybuvsraqbznjzgoqkubmrsxyqsw","nljcbnoklnyjljclqaenxeakamdepseqbn","zzssxyvqgthztrwqwxne","bdixtfrzveolsvesgnmu","tvtybbastpzyvflidaml","pmyzdqnksrqzamntdivv","wkyfgdzzlzoeyxwhrzge","ydfmeaeoschfslapondp","rzucbolhybvijtotpvyk","qdbuidzkrmepzjkdnnys","fncgkztdrjyyzbablnng","sgrilrioplxaspepnohw","qnsmvkdjevobmnfoloqu","sdxdumrecyofbgnixzri","cvkzlzokwwcgrherdvlv","zmqvixskitxufwhrhpqhkbhegbbhhhuvgsg","tutztmzguvhdcrltyyjw","vvqzkikadxoajkglkxrtsmdmpcvvpeane","cdbidlbuadxwnnralyvy","cjuvaaszdmvyfautfaef","shfrpqkxnfvjhuvnptzv","qyeofcjjlqabctzgxmea","gzghevwdeskesyvtcsit","odhjgurvctkkyzutsaqz","pzjgtnupfrnxxasygwna","zuugsazstrlkckfinmho","kslpwbhgebiagypgizxi","ozevkejqjcadkzxdouzx","dasctbhfyrdeuexbjjml","zrixjpbuxcsiczudpxrb","zmcxpmtwzuybvdihtuvy","dcovynlqscdkvnjmcrdf","kqdjrvgyqncqkraogxxe","dcbvczndzxttrqkxtfbu","hsmaoqmagffkkdekfeds","llbdrjgdclhvzbnszgbr","oqeyuiyguetvhbckhzkb","qgkirkcfxaufajhlekko","fwelcwsqyqnkznvkxkdx","usmiomoefnkcsginszid","srehlgyweeyvlinjwhcz","yuekbplidojztpphxkvn","abvjmdyyaxdxyowvcnbs","myvijpnenvywhzcpgmho","zftchdpurspzytrzirrd","fgeadnuyhuuxraezloan","tkjrkbhhisiwcrbwgljx","bbb","knektegegzhuwnclxgzp","vniowcrtokkytjzuqify","iwifemvinhuyixtnawzq","qtbmkisadfcevgltfemt","yjlcvxlfjqcbdfurgjct","iwiypvpgnmwxjdfbbtiw","tduvwlhyzzecjjmgnrof","rcydsilbqfniiisbqzht","jlikplqyygygsuhyekan","lxpseitmmnricdxulfxt","lcmbvtjykxxgsseohqik","byetqtxzuodhduooojyk","xoxzltibuqmqkgshkpyc","rwnxhlkznneythrbvbxw","iwikbmgvujchsweiosla","rvdqtfsfxtfrdaesiglo","bozlbkgjpynbpvtcumcc","wffjloponkgchavccnde","hglxytsrbycjmmuipbaf","encshhmikofzdangwddi","aueiqiderjdkkkytnfmq","edqwpdinmtccqkaezesu"}, 140},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] words, int expected)
        {
            var sol = new Solution();
            var res = sol.MaxProduct(words);

            Assert.AreEqual(expected, res);
        }
    }
}