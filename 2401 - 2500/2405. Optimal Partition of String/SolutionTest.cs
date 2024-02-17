using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace OptimalPartitionOfString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"abacaba", 4},
            new object[] {"ssssss", 6},
            new object[] {"nvwhhdnyoqddsvlkznaryzmplsnkyrbgnmkgslhetwsjkpewyqlvpztodxitcxrkerpisgxsjdwxdhvnqbybmwshlmgukuwikktuxivklwfjhtwglrjicxkjhlibfemfxoblocvezjgbbzccryiuochijcwdkppplarxvccmielykeqmxxuctksienmeomdjceljuervzxieqsgzlrkhrllwpskpboelniwodtwqmxrfvsjbpbxfbklcnroudjuymyaciwqvaxxaydkffhrptxqvgleuktqyaslitibylzseacuvofrrdpdtvynjkmoduicpojckrzofvczxknvpuckruprcyshsiqoqzqunheitloayhodpkwffwetlisexhspfduzqtggfvyopvreozpbexvjcjjmtckcoqvhqwkhckjdzrrojlzpghtphnrcrzruqwuuisjspvbfwqdikhlwfmdmwomsoiuvnkmxvnhqhxapzcfsvpizjdmcsojpsirvtvfikhspmtrhdjvowugawjtlwanxpryockidlkrolepddhgpdngpbexuiekdcuooyqhxdlbzfwovjzenrydcpzldukyazhkmssntfdmxgrronddaeptilunlpdfyrrvdztdhiyqvzfqeixtneevzkepaclopkskowxyojmmxqzjsmexvxtvhlwbethheftjznictnstohciblzuvafzwdbtwblofnznontfsdhjkkhpfsuhdvznacqyjxsjqsfqprhuvyskkatfdmjbfjnegjquiqplgogmgjcoxvhsnsojjqaleueqaiohzicnhkpmbcktjlcgjqjjfzkmbyqudvvboxhoplfirafdgfyetwdastgpqmsfyswwxyisuxmbufwmuapdhzbddkpedpgcivquybbjyaarnktllpykpnpbkvdakodxjbjlqnajgwfsjxemjhvhattqsciyvawgriwsfdvciitxrvhoamwqqwnksinibogtddtysswilbqtrepcmgxumdsdhwiqfxxvsfyxqabdbvazbhwcvkggvctnbjdtoczlzlbcsyhiwaehrcxwqacpiaerrmkqtgrckxyagxtlrjvyscrcalpovepzqybssrwqwzuceihjxdxdulmqprqzyiiqusqpczkiezvhbrqkclgxvxmrdxqjadsuklvktcctlwtfmtcrrminndjlzammyfoylbyjjixznypynttpazvnmsrpyqdcblazqoynrmhtyvdsqulfqaugttzesjmwxejydlpvbeobekxfqwttneuoezqzsmrbixzhzchglpqoyqlfqnkbfxgnpyqmgxsfadwomqliupviipbvgogsctszlhattrfusogydfccuttsnhyoelrjqslcuiptkcxwmtlqbuvhxalctnkdutnufbjadwnmrggxqhleawzskqrrupeouvvdmtchwsoifqttxzfivmcwgffccrghuiwdhualmiicjnopkckdgcpwqjvfqzdjprkucaxyzltosprhdlznlvhrhosvuguzfdktrxychzzcilbcscovrkskvudisgisirbjgogkdvkgqrpkpjbcpbicqaufldgwnjuvfxgnektxivakxvawtetjasajmdwqvvnvyisngygmmlxiubttblphhhyrjchewfsgyzjmxxvuapknzuicnbioiixilgsgjtvnqnhpsqzrassgglfjhcbivgafvfbjxgwpfdgtwggikfajodgrsrvyqhppjhjkghhlynqgxzaonxasgcmcglbtlnfgahbqbeygqnydxgtwonemwujhjksjwwrgccqyfutpidyhwcmlymugcubthmwtnnxunxyeifvzwdgbjdndkkuaoqavkxqnygkqaduodlhtfkdowjmssamsvclsmfkecqfbuyazshudvqlixuaegkabuflfrrrirvlcuoghfkblejrbtkmgpczjxdmpfi", 335},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.PartitionString(s);

            Assert.That(expected == res);
        }
    }
}