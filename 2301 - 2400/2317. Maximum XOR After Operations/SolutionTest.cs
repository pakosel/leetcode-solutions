using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumXORAfterOperations
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[3,2,4,6]", 7},
            new object[] {"[1,2,3,9,2]", 11},
            new object[] {"[44,516,45,549]", 557},
            new object[] {"[44,516,256,45,549]", 813},
            new object[] {"[198703, 43750]", 240367},
            new object[] {"[198703, 43750, 45061, 5267, 196951, 173096, 199652, 113801, 198494, 138824, 95944, 95007, 61077, 180512, 63150, 158920, 6125, 17958, 35131, 40849, 141069, 149542, 93210, 194521, 144022, 136971, 143688, 187245, 62084, 66871, 181873, 136267, 122072, 42574, 194510, 22716, 173457, 191551, 76606, 140767, 32650, 3253, 97202, 33193, 162738, 1559, 34936, 174397, 7293, 75037, 124418, 24348, 86194, 178186, 22617, 67380, 81148, 189869, 61051, 159045, 92606, 126074, 76244, 7873, 116265, 113969, 190919, 45079, 186515, 1907, 54217, 85055, 121779, 69911, 154508, 83623, 22489, 124036, 7662, 185066, 165666, 141386, 16283, 20447, 196281, 10237, 14247, 120745, 28436, 119523, 166451, 65530, 35724, 81943, 84002, 91795, 32475, 169983, 150337, 122023, 28405, 71891, 48847, 58431, 171398, 81320, 106689, 199113, 126990, 189111, 173487, 42833, 157293, 159409, 96640, 68880, 152860, 46857, 71469, 169312, 90116, 77482, 140050, 192870, 160546, 122896, 170945, 186836, 13930, 144789, 192902, 176387, 70258, 117107, 148865, 62054, 46914, 6250, 163414, 184474, 118606, 35273, 15522, 158742, 188684, 100039, 186392, 47596, 53087, 12507, 106538, 106731, 180342, 67456, 151418, 142739, 95141, 54309, 104729, 196490, 24633, 113624, 37320, 155107, 166028, 2218, 83260, 95986, 159860, 199291, 181833, 47243, 164699, 155367, 166137, 81178, 94351, 131314, 26523, 188426, 173216, 174974, 98690, 136219, 28031, 70850, 51514, 61994, 187702, 115100, 132300, 134353, 14927, 70104, 121284, 7244, 116770, 27497, 80736, 143967, 168603, 152433, 26325, 59606, 189841, 156858, 8193, 114266, 11826, 153899, 119000, 92068, 61712, 120163, 71437, 6418, 134026, 72890, 50531, 192490, 106940, 114584, 116858, 96639, 6184, 146815, 191860, 144162, 194407, 9383, 80705, 162112, 67953, 103618, 134128, 167506, 28774, 155059, 314, 31024, 166238, 149463, 86485, 6437, 162788, 43953, 161197, 117459, 44746, 90080, 73457, 167533, 120188, 98106, 97868, 14859, 85083, 154062, 82116, 117597, 126595, 185984, 84383, 57863, 180749, 18711, 159220, 67640, 17189, 99898, 50238, 186110, 153135, 2655, 184311, 188061, 171392, 153823, 137244, 176673, 19468, 130166, 44551, 71563, 50158, 69547, 69433, 172129, 146707, 27146, 20881, 97223, 47598, 163030, 80602, 31267, 88471, 166545, 110706, 166308, 150560, 160709, 162622, 141359, 139377, 85099, 43779, 119874, 90747, 105014, 173942, 71779, 189502, 39318, 176800, 105651, 170934, 150083, 150474, 41517, 94588, 14817, 198342, 25597, 187982, 14202, 139853, 123802, 150356, 136042, 165372, 127812, 120191, 129958, 145788, 154351, 48032, 94061, 187301, 25468, 18619, 13408, 41337, 134164, 106150, 4962, 145498, 28281, 126343, 128896, 4764, 29241, 8010, 152050, 103168, 170616, 36270, 15006, 183470, 49737, 126076, 34968, 113831, 181499, 128392, 99354, 69247, 144635, 3753, 157689, 60580, 134306, 192762, 198892, 26936, 67392, 35521, 109552, 118750, 43860, 15219, 2296, 14574, 63306, 98793, 58139, 77264, 176856, 142887, 139452, 130837, 134489, 49827, 99014, 143937, 195687, 14168, 21498, 25777, 544, 2470, 97522, 162059, 114926, 148740, 68177, 104018, 29990, 146132, 98101, 82707, 97813, 60521, 197153, 50310, 76737, 66854, 1650, 80004, 74321, 70457, 140155, 1776, 70494, 84315, 110249, 140465, 185346, 53910, 140174, 55848, 87431, 88603, 9910, 184237, 10363, 35369, 37737, 97168, 113456, 106161, 181150, 82260, 167894, 56332, 54081, 177896, 69818, 14984, 182189, 72911, 56889, 103981, 108553, 86014, 29190, 190617, 155579, 101348, 50181, 94577, 16659, 166953, 122689, 167501, 157465, 32824, 192508, 85034, 136024, 92199, 40427, 26381, 143857, 17820, 76108, 186634, 150625, 103890, 139534, 39663, 78507, 159370, 123329, 17566, 139425, 176311, 172202, 43093, 164018, 143097, 44020, 170455, 105359, 41356, 84431, 55548, 122165, 153567, 8487, 7598, 1520, 92204, 199922, 61323, 67688, 124548, 77957, 90522, 143053, 36244, 166976, 25678, 165781, 20464, 39933, 142000, 180694, 153598, 2694, 168457, 164621, 47066, 15170, 28352, 107321, 141191, 180062, 153703, 122372, 93507, 123025, 55308, 80151, 7582, 23147, 27923, 2995, 103713, 74216, 57591, 99146, 162550, 121024, 162640, 35935, 66115, 101393, 147139, 183067, 124981, 139734, 58493, 139395, 186020, 112556, 185219, 38017, 142811, 164605, 3566, 130690, 158270, 115928, 39793, 135028, 41089, 32654, 39536, 2744, 116723, 49659, 127387, 27977, 105537, 136914, 196156, 180489, 77704, 187841, 84743, 115557, 169580, 179400, 63402, 68782, 199586, 87722, 185004, 29254, 52033, 180218, 159398, 72566, 116093, 192753, 53382, 97125, 97270, 118589, 110724, 156291, 192014, 69992, 15862, 146685, 17876, 163412, 15494, 48941, 57137, 24514, 36526, 9317, 136107, 130491, 159905, 124763, 16777, 161090, 48392, 114968, 189483, 24363, 35136, 135437, 78971, 95422, 196423, 31741, 169360, 102027, 130737, 49825, 137996, 76287, 10043, 51082, 90474, 138640, 133254, 182344, 4227, 80615, 92269, 51209, 117202, 135629, 129992, 146364, 66361, 163443, 162272, 95352, 104090, 126234, 44826, 159607, 111888, 37532, 57258, 101917, 89518, 118671, 167537, 84761, 162904, 168808, 72611, 29330, 107726, 144797, 160905, 168343, 4830, 180134, 87603, 142766, 151680, 187919, 157220, 33330, 196213, 107102, 143643, 72368, 48255, 84302, 106854, 163507, 15052, 86343, 145464, 150058, 30383, 24428, 117462, 518, 20077, 96515, 110170, 68942, 177459, 43379, 25954, 11734, 164174, 179307, 30641, 91089, 126012, 145572, 127862, 136381, 169144, 189625, 157450, 63162, 68801, 147533, 83506, 29429, 124482, 194047, 61107, 740, 56880, 145388, 98655, 88705, 19560, 172107, 79966, 190754, 126165, 179224, 136838, 28839, 4061, 25132, 164374, 142630, 59306, 132045, 176268, 113628, 54201, 46406, 82466, 196608, 183292, 68824, 55622, 5845, 179244, 149306, 191112, 179532, 108151, 109401, 24664, 5716, 44297, 67067, 30754, 193809, 23290, 20880, 28570, 59525, 131733, 77810, 34431, 107872, 198764, 175023, 119937, 125151, 57760, 79913, 2941, 122981, 81129, 198378, 122180, 79903, 139409, 139111, 76462, 81580, 187384, 183333, 108278, 183683, 94175, 28264, 135563, 103248, 82810, 35260, 181115, 49946, 187819, 99546, 111038, 78600, 41022, 11699, 8443, 157108, 171860, 100082, 188446, 193812, 176917, 197876, 99890, 146709, 155495, 185966, 186012, 42603, 85627, 153881, 86897, 139072, 193269, 63808, 29681, 80504, 57533, 132783, 179779, 65023, 78461, 155487, 191029, 17674, 137411, 183637, 168634, 97221, 67815, 144045, 108873, 86089, 13514, 158803, 53779, 92327, 168165, 75651, 92888, 21701, 165922, 180338, 186923, 63800, 93300, 198920, 56595, 23382, 104064, 122240, 129424, 100353, 92738, 158339, 119648, 38685, 44290, 176681, 141753, 167798, 162051, 171307, 94004, 65791, 34027, 6859, 122477, 143758, 10242, 92648, 26690, 155882, 153328, 23211, 123176, 115979, 190394, 146219, 158095, 88184, 86333, 186809, 854, 147320, 138521, 73592, 2160, 185997, 6660, 127771, 92700, 173696, 109894, 81802, 36217, 144407, 67285, 32143, 52478, 144237, 18272, 82589, 109392, 141859, 66831, 2323, 5234, 158782, 39911, 168524, 30277, 6122, 167972, 120692, 177941, 189615, 127118, 166408, 51763, 5760, 86568, 89752, 92675, 150862, 105836, 38318, 23185, 20886, 192003, 125200, 89950, 68099, 139599, 65286, 157831, 5660, 101183, 59823, 23400, 63258, 123883, 8079, 140458, 80632, 154525, 56374, 124908, 60483, 57855, 91257, 103783, 164190, 27357, 192841, 58239, 178038, 154849, 121062, 149794, 57989, 141305, 100166, 133838, 176215, 82640, 134919, 194803, 187675, 18514, 5555, 98182, 20889, 1540, 196049, 193327, 71247, 132132, 73790, 45169, 83461, 148727, 58986, 150656, 95018, 94825, 134043]", 262143},
            new object[] {"[772,45,1,297,549,549,301,805,297,261,36,772,37,548,300,545,773,549,268,32,41,521,44,516,256,45,549]", 813},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            
            var sol = new Solution();
            var res = sol.MaximumXOR(nums);

            Assert.AreEqual(expected, res);
        }
    }
}