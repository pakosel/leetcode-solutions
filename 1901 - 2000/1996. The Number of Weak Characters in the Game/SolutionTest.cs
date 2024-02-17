using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TheNumberOfWeakCharactersInTheGame
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,1],[1,100000],[100000,1]]", 0},
            new object[] {"[[5,5],[6,3],[3,6]]", 0},
            new object[] {"[[2,2],[3,3]]", 1},
            new object[] {"[[1,5],[10,4],[4,3]]", 1},
            new object[] {"[[7,9],[10,7],[6,9],[10,4],[7,5],[7,10]]", 2},
            new object[] {"[[1553, 9660],[4040, 4983],[4270, 1840],[8914, 9360],[7714, 8795],[172, 5323],[1101, 9951],[1638, 6217],[6858, 6840],[8709, 7696],[8089, 7269],[6038, 2334],[9032, 2183],[741, 7077],[6488, 6951],[5930, 3750],[4336, 8660],[8276, 8586],[4882, 2142],[8050, 1473],[5547, 3671],[5064, 332],[2367, 1346],[8745, 252],[6147, 517],[8376, 2325],[8027, 4708],[4850, 2247],[8686, 5271],[8822, 3028],[6507, 8131],[7471, 7407],[3713, 8226],[5045, 598],[107, 5460],[7512, 7120],[3077, 2484],[4423, 8425],[6469, 1520],[4241, 9682],[5706, 1107],[2325, 7849],[2697, 4850],[4423, 8672],[5888, 3380],[8501, 7245],[5220, 9888],[7682, 5789],[8354, 8999],[2952, 1478],[7721, 4277],[1996, 5585],[949, 7143],[9413, 9230],[3112, 6528],[2882, 3788],[6945, 403],[6053, 9758],[1600, 6143],[412, 9045],[4158, 678],[8745, 2198],[2293, 7185],[3872, 6393],[7621, 9806],[2535, 5098],[2493, 3745],[7094, 7929],[2725, 2673],[4595, 9075],[3936, 9245],[3815, 1685],[1468, 3229],[5600, 2567],[1924, 7152],[7345, 3654],[2225, 8966],[1270, 7552],[9060, 3878],[9942, 8081],[2822, 6200],[2811, 8960],[4907, 8428],[3096, 5891],[5133, 6816],[9689, 4549],[8562, 5737],[9159, 2599],[4133, 8520],[1244, 5472],[3509, 5549],[2948, 4681],[8722, 312],[421, 647],[5519, 896],[4483, 320],[3331, 6574],[1595, 7907],[7407, 6242],[3831, 7547],[7910, 9264],[4219, 292],[5037, 8158],[1655, 7846],[4399, 9862],[6887, 815],[2694, 1968],[8884, 8922],[4857, 1406],[4620, 4954],[8266, 2175],[5263, 8098],[8631, 4715],[8281, 3126],[9548, 7137],[2767, 724],[9230, 453],[5348, 8934],[3882, 8898],[7414, 5247],[2557, 5187],[2005, 715],[7484, 5478],[9788, 6963],[2554, 3461],[7445, 182],[4844, 4755],[1047, 152],[384, 4464],[2258, 8106],[9384, 113],[8936, 2530],[8721, 4226],[6990, 9507],[3451, 5904],[3646, 1324],[5413, 2978],[3563, 8628],[768, 3405],[5623, 9927],[2092, 6105],[4383, 674],[1048, 8350],[1042, 375],[981, 138],[3096, 7276],[7728, 9034],[2429, 978],[2302, 4965],[7373, 3192],[6417, 1400],[6974, 5443],[4759, 1571],[3175, 8611],[5893, 8042],[3093, 342],[3157, 4902],[2225, 2617],[4728, 7919],[4066, 1102],[6998, 4558],[6225, 8823],[9502, 3759],[4547, 7769],[7549, 875],[5304, 6225],[6073, 1195],[3442, 1792],[2537, 1714],[882, 7645],[8270, 6447],[7268, 159],[321, 3134],[2891, 1238],[9249, 6269],[3227, 9012],[7191, 1457],[3450, 8025],[3108, 9197],[4961, 6811],[2159, 728],[639, 6771],[2271, 5740],[156, 3974],[2015, 534],[6388, 691],[9594, 1105],[5570, 1320],[1136, 1112],[9085, 4082],[5307, 7145],[7839, 3986],[6955, 7964],[9488, 1407],[8967, 6610],[6111, 222],[2398, 2428],[8484, 3054],[662, 9106],[9458, 3491],[9213, 4793],[5724, 2954],[209, 8875],[6073, 6157],[5493, 7427],[5248, 802],[5800, 6192],[6517, 824],[8175, 5755],[5888, 3083],[5291, 7025],[5920, 821],[8682, 1591],[5423, 1897],[5384, 7144],[504, 841],[7245, 5364],[7124, 7651],[5467, 2654],[8345, 9062],[1467, 7633],[3639, 6088],[8754, 9747],[6606, 1380],[7782, 7953],[3670, 667],[6223, 5459],[7968, 6701],[8749, 1030],[596, 5555],[8754, 3533],[3381, 8047],[4608, 8202],[4869, 5859],[7821, 956],[816, 3784],[1961, 8567],[7515, 3300],[9978, 4293],[5908, 3833],[4867, 6837],[167, 5464],[1919, 6573],[1229, 6612],[9309, 4498],[5212, 1033],[3499, 4050],[9296, 1725],[3116, 2691],[6488, 7243],[3931, 708],[4672, 2516],[5660, 4523],[9740, 3362],[9058, 1710],[568, 6132],[4686, 9087],[5504, 6851],[9617, 5787],[7436, 6124],[4730, 6165],[5894, 398],[1822, 7919],[9112, 6031],[2759, 2865],[1851, 7433],[5089, 7401],[4923, 6996],[901, 86],[9721, 3035],[9155, 1904],[8214, 7863],[8653, 8953],[2757, 9395],[9882, 7290],[4256, 3309],[2472, 2364],[9954, 6999],[1564, 447],[3512, 573],[7511, 6849],[5961, 5718],[6575, 6534],[9638, 6208],[2461, 7246],[6496, 3920],[5981, 1743],[1424, 3562],[1314, 5249],[9633, 4592],[1781, 2344],[7107, 7420],[3669, 8840],[5615, 877],[4271, 8422],[3807, 4622],[4874, 8547],[5647, 7378],[9505, 7897],[1193, 1419],[304, 9248],[7861, 1968],[9197, 7683],[6867, 3858],[1917, 6420],[4633, 5417],[1537, 1412],[6915, 4783],[2003, 745],[4320, 4173],[5537, 1195],[4373, 9411],[9452, 9722],[5835, 767],[8268, 9364],[3497, 213],[6889, 1396],[3805, 9853],[8413, 9259],[7899, 9920],[7954, 2166],[6744, 4646],[3348, 2180],[8374, 8928],[6285, 7556],[250, 6955],[3338, 7256],[9365, 8421],[7596, 3423],[190, 9443],[8885, 4657],[8597, 8243],[7178, 9877],[7091, 5574],[1982, 596],[9247, 3511],[9163, 5450],[5460, 2398],[2451, 1850],[3106, 2628],[9539, 7229],[6233, 355],[1242, 8206],[633, 2841],[7277, 1132],[7634, 6670],[7697, 572],[1192, 2933],[5583, 8458],[112, 7849],[5550, 7961],[868, 7976],[1132, 4413],[4411, 2607],[7648, 6035],[2897, 4850],[5567, 3906],[8092, 4888],[6620, 2566],[8181, 129],[2164, 7410],[464, 7293],[1379, 2890],[1353, 2152],[4732, 6013],[6462, 2298],[588, 6024],[4279, 5331],[7391, 1770],[1138, 3985],[3463, 9778],[6758, 1095],[2160, 2655],[2497, 2958],[9787, 6447],[6591, 2757],[3090, 4732],[4931, 317],[3252, 2353],[1811, 4228],[2355, 4667],[502, 8692],[9867, 3597],[4083, 1714],[6372, 2135],[2812, 2495],[757, 8665],[9334, 5061],[6448, 3986],[1144, 9056],[882, 89],[6176, 3007],[4344, 7369],[4890, 1538],[7672, 1936],[378, 5647],[1329, 1074],[623, 1927],[2227, 9239],[9865, 307],[3689, 9352],[6199, 1368],[1804, 9837],[8594, 8520],[6121, 392],[5709, 6123],[132, 9025],[5685, 2698],[79, 9282],[5448, 8255],[1463, 178],[626, 4124],[5751, 9521],[9788, 7780],[6170, 2127],[8707, 2463],[7968, 5079],[8214, 9218],[5959, 5620],[7029, 2255],[8269, 8140],[6683, 4385],[4863, 6961],[6394, 4751],[1111, 8207],[2065, 3027],[441, 4034],[1591, 674],[9738, 5761],[3520, 6426],[5929, 8383],[6825, 3776],[6102, 2472],[1036, 6351],[8530, 4166],[2806, 8258],[5350, 1447],[7138, 745],[604, 63],[7477, 7526],[8927, 9666],[5261, 5172],[3244, 9165],[9288, 7811],[9233, 4604],[7059, 2019],[3885, 5013],[7756, 957],[6188, 2672],[4945, 3092],[2877, 2101],[2622, 4407],[1096, 1042],[1609, 4400],[7687, 3259],[8730, 3783],[3903, 2293],[4125, 9739],[6838, 5424],[9481, 1873],[8794, 3440],[8634, 5599],[7502, 5545],[5280, 9485],[7136, 9186],[636, 4606],[545, 637],[3924, 3225],[3030, 1901],[4881, 9025],[9691, 8560],[2022, 5967],[2510, 9295],[4645, 4960],[6614, 9946],[7538, 444],[8798, 3149],[6839, 8044],[165, 9352],[7687, 9733],[5725, 6581],[7933, 4339],[6045, 2645],[4416, 9982],[2179, 6500],[3688, 9931],[3652, 7121],[4239, 9865],[9943, 879],[3858, 2505],[8426, 5022],[6122, 4195],[1155, 5888],[5313, 9009],[3245, 3102],[1964, 8321],[8471, 1855],[4946, 7251],[8605, 7290],[1767, 3688],[9530, 8165],[3506, 3590],[8268, 6234],[2301, 9580],[625, 2172],[7566, 3597],[7896, 1346],[8771, 3040],[7887, 6821],[4493, 5560],[1782, 1159],[5669, 5547],[9142, 4754],[4634, 5735],[3946, 6729],[8337, 1861],[8849, 5118],[5284, 3402],[9257, 9346],[8474, 2084],[6875, 8844],[5616, 5032],[3910, 8466],[4939, 9419],[7246, 9481],[5335, 7787],[9146, 2096],[5580, 4604],[4239, 9384],[1592, 2297],[7487, 6688],[6450, 8266],[3267, 8203],[6997, 5417],[7924, 3098],[2474, 7819],[4, 7345],[2555, 8857],[1089, 9595],[8888, 6986],[5230, 3043],[6258, 5045],[8289, 827],[688, 3510],[8871, 507],[1887, 9279],[2363, 1035],[9305, 9756],[1598, 6900],[3546, 1420],[9159, 8624],[1897, 3520],[6518, 2423],[1437, 4548],[8733, 6315],[2548, 7707],[7406, 30],[4040, 2780],[9126, 2149],[7304, 831],[6820, 3466],[9107, 5626],[515, 9163],[8817, 5606],[8892, 9500],[685, 6652],[7433, 9446],[6554, 583],[1722, 6839],[430, 8260],[5992, 3893],[68, 9228],[4236, 9649],[9599, 6550],[3384, 6432],[6660, 1127],[7231, 2167],[1030, 1982],[3082, 5891],[4869, 4407],[9837, 2802],[2282, 4052],[1915, 9302],[2325, 9260],[7534, 6454],[5775, 8564],[4852, 4457],[246, 1291],[3997, 6134],[8824, 3118],[2717, 6513],[7603, 9189],[3249, 477],[7651, 52],[9677, 4907],[1821, 6431],[5758, 9951],[8419, 4180],[9286, 9671],[7202, 8747],[1744, 7577],[5538, 2878],[1080, 7980],[9779, 731],[7739, 197],[246, 8649],[6588, 5004],[6278, 3437],[1566, 7005],[7597, 7894],[463, 601],[9919, 313],[4540, 9126],[5139, 6551],[8667, 6071],[8646, 2345],[4096, 9405],[5590, 560],[362, 1075],[185, 670],[5964, 7854],[3412, 2709],[6938, 5055],[6848, 1258],[3301, 8675],[1951, 2013],[6940, 8766],[8026, 635],[8970, 1345],[2493, 2126],[8103, 9427],[1218, 9856],[4674, 5367],[5952, 3044],[399, 6746],[2079, 7565],[7837, 6556],[5405, 5870],[4861, 2592],[4392, 66],[6492, 7300],[7335, 8347],[6426, 4258],[4170, 7012],[4299, 4605],[1025, 8128],[6012, 8338],[6291, 5082],[32, 8866],[768, 2375],[2234, 6453],[7603, 1908],[4801, 9863],[6197, 6340],[3838, 9856],[9338, 2306],[6908, 3255],[6444, 325],[9157, 6216],[6963, 2992],[5768, 2055],[8998, 9509],[1929, 989],[4614, 9376],[5360, 3907],[2784, 6058],[5516, 4126],[7498, 3733],[65, 2439],[8529, 9662],[833, 3398],[403, 1188],[1350, 7286],[4504, 6295],[7169, 1598],[2045, 6683],[9369, 9171],[3732, 751],[7047, 899],[7098, 9613],[2620, 5037],[32, 6081],[3575, 9882],[1662, 1540],[1440, 4679],[3553, 2562],[7938, 4144],[9095, 4478],[980, 3982],[9910, 836],[3107, 2442],[8479, 2732],[3674, 7999],[9040, 5011],[9561, 7920],[7714, 6945],[2582, 4051],[4473, 2499],[2398, 9687],[422, 903],[3782, 5987],[9802, 8834],[1930, 9964],[3557, 2870],[9952, 6296],[9090, 7627],[7057, 3481],[656, 591],[2049, 3362],[3468, 2348],[3078, 4467],[9802, 9219],[6432, 598],[141, 130],[562, 8235],[4420, 3864],[5773, 2693],[5225, 4591],[6525, 8224],[8417, 9886],[9843, 3675],[4290, 769],[3332, 7374],[8046, 792],[9246, 2961],[1075, 2052],[2380, 2069],[404, 3560],[9701, 7176],[5653, 9446],[1666, 5136],[7252, 9109],[6689, 1674],[6508, 8999],[7603, 5437],[7578, 3669],[8214, 8325],[5207, 8133],[8933, 110],[5654, 8373],[234, 1105],[2263, 8933],[8911, 1064],[1668, 5229],[8502, 4371],[2527, 3041],[9575, 2658],[7801, 6104],[885, 72],[8292, 6723],[2431, 1059],[1629, 2852],[3449, 371],[5217, 2936],[7133, 8099],[5436, 4471],[1314, 7472],[3618, 6804],[4980, 4582],[3520, 4561],[9613, 3531],[3551, 9950],[2149, 6526],[4916, 9012],[2834, 6396],[3662, 9874],[2149, 4154],[9894, 1253],[2315, 678],[3860, 34],[8942, 5854],[3580, 707],[7399, 7448],[4603, 1631],[112, 7392],[7443, 7653],[3627, 7947],[516, 183],[6357, 5307],[1429, 747],[90, 5893],[6452, 6976],[9025, 2975],[6808, 5180],[9153, 6080],[8686, 959],[3320, 6870],[7468, 5565],[9753, 7949],[1051, 6877],[8446, 8437],[5693, 1411],[8032, 6149],[8522, 5142],[3929, 4623],[7346, 8796],[5770, 5413],[4135, 3592],[164, 2799],[8002, 6653],[7469, 3502],[2239, 9865],[3783, 1799],[68, 7436],[8561, 9517],[8787, 3891],[8282, 3297],[361, 3992],[7911, 7129],[3790, 3992],[5283, 2730],[5229, 325],[9086, 4383],[2143, 2417],[9692, 2232],[9068, 4601],[3572, 1651],[7300, 1369],[3031, 9374],[6056, 4383],[9529, 1130],[6966, 8628],[6436, 9649],[1221, 3424],[1924, 4613],[7833, 779],[8997, 4361],[8137, 6383],[651, 3995],[1596, 7859],[3199, 9623],[7132, 8894],[3197, 5891],[1372, 3507],[1194, 8033],[9602, 8152],[3439, 5068],[2765, 6501],[3366, 5782],[854, 5705],[8361, 2646],[973, 1571],[9480, 2120],[7822, 7892],[8075, 7812],[8631, 7607],[8829, 5048],[1896, 6778],[5272, 3522],[1755, 2529],[1630, 292],[4264, 9829],[2725, 27],[4646, 574],[7322, 6473],[3235, 5895],[6755, 454],[4764, 9942],[2777, 9233],[2094, 5083],[9476, 3434],[1684, 2458],[730, 3579],[1808, 2118],[7244, 6197],[1981, 3346],[9515, 7108],[9768, 4610],[132, 4410],[8010, 7400],[8266, 9899],[7786, 5827],[2728, 2533],[4119, 1758],[5001, 2703],[9803, 6366],[4091, 567],[570, 9240],[6568, 3856],[6569, 9150],[217, 1433],[636, 924],[9120, 8726],[6527, 3206],[4378, 9867],[8109, 8863],[1658, 3193],[5750, 3699],[5843, 4322],[5047, 7841],[6360, 8202],[5837, 2139],[2690, 5462],[5448, 7270],[4529, 9988],[5383, 4608],[2868, 8889],[3377, 9849],[9519, 4834],[4732, 5874],[4468, 1397],[3068, 2848],[2616, 5337],[4490, 1193],[6363, 6248],[4918, 1095],[9249, 5633],[5407, 456],[3667, 9522],[5283, 3552],[7790, 4172],[4215, 502],[1988, 1750],[1632, 3451],[333, 6786],[2998, 9156],[3841, 9759],[7535, 2786],[4471, 881],[8675, 3342],[7602, 4128],[9748, 8035],[3818, 8861],[9535, 5],[1837, 5208],[8977, 45],[5879, 3616],[697, 7510],[8437, 4900],[7815, 9031],[4420, 6191],[2308, 7958],[6916, 2444],[7001, 3388],[2327, 1445],[7902, 7972],[6577, 5769],[4473, 6736],[3727, 7897],[9837, 6913],[295, 6653],[10000, 9545],[4419, 6953],[7125, 6837],[7673, 1197],[6789, 374],[8296, 9927],[9932, 3832],[6106, 7793],[4331, 1457],[7325, 4083],[3668, 5433],[2975, 7233],[1731, 3239],[870, 4883],[6604, 9892],[5876, 8975],[1132, 3973],[7437, 2697],[2672, 9170],[1743, 9649],[1407, 9582],[8109, 2523],[3675, 9064],[1194, 1845],[7678, 7367],[4713, 2697],[5164, 2933],[6518, 1485],[6028, 4503],[4153, 2539],[5469, 1213],[3445, 1092],[1487, 7217],[5700, 6196],[5959, 6712],[5070, 5011],[6078, 7847],[5515, 5868],[3034, 9968],[4038, 8709],[6252, 544],[614, 6901],[9366, 1795],[2314, 9632],[5635, 8358],[1475, 8703],[5529, 3445],[5992, 8737],[3480, 6029],[8097, 7334],[2511, 8242],[3618, 5501],[4466, 823],[771, 2748],[8489, 1970],[4285, 6527],[2559, 403],[9950, 9750],[2759, 3201]]", 992},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string propertiesStr, int expected)
        {
            var properties = ArrayHelper.MatrixFromString<int>(propertiesStr);

            var sol = new Solution();
            var res = sol.NumberOfWeakCharacters(properties);

            Assert.That(expected == res);
        }
    }
}