using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumOperationsToHalveArraySum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[5,19,8,1]", 3},
            new object[] {"[3,8,20]", 3},
            new object[] {"[54748,73369,40490,1796,9846,87072,34165,2925,54018,19663,4038,67835,21283,9488,24143,46842,68664,41083,68251,65090,80506,44914,99086,90706,85035,88544,57201,54794,75670,56982,1180,82112,16550,32465,21524,26924,99097,85998,57922,39186,71582,46694,93414,88185,13101,65658,80577,49819,19703,12500,83657,44459,10724,49267,73378,93673,66001,24314,70084,62069,39529,49650,2035,92235,37743,87662,25378,36024,18225,66295,22205,33861,67842,88648,54572,13873,57233,60475,90243,51651,66597,62149,55108,46202,72879,94168,89992,97064,15424,35158,33502,45190,61469,76331,98020,73874,91889,99363,68093,87498,24444,24241,244,99075,66428,64399,73970,44134,79011,52202,92465,20744,73202,96666,83188,91239,92862,82327,22656,7982,15710,96669,77941,73683,7689,27137,14988,42331,45072,54642,1278,90700,91416,9765,64237,97708,66981,28345,73603,76878,2334,52397,36411,90997,97787,46918,52044,82021,28160,15230,56661,54092,70946,12880,97030,28656,66015,30845,99344,27292,53989,2648,3740,56851,5139,39916,79611,79151,22516,14089,65879,15436,60297,89382,15713,12013,18040,9092,36182,5842,95900,86115,21768,45148,44962,17008,93463,84716,93332,78278,69403,48985,23388,95344,84238,64828,93749,78485,19407,39313,2975,12933,34959,94379,35329,84887,51139,95031,75355,47445,5073,39548,46283,67798,72221,14656,45861,24578,28406,43898,39163,91586,95110,61504,40579,30633,2220,65908,77869,74415,33739,93148,36793,15718,35186,3193,52407,47945,64209,41038,87005,18233,33830,77871,90755,41117,40984,3143,17257,31689,39940,20032,8071,30946,23502,47024,96585,42113,38474,78167,41121,51998,25907,7677,33990,87405,95059,96094,72885,29275,97928,43251,94738,19067,87503,39717,40988,90216,92588,44266,35176,7449,24214,8721,63036,61746,94691,7796,8345,46513,33164,93285,27037,25015,82444,66504,25746,25621,30369,90559,76333,2334,61730,54834,11732,97804,35914,93737,82789,89004,30541,70500,23166,49063,78965,42198,47702,14977,66353,36804,74974,2899,68937,9,81772,9652,10449,85092,77243,28566,15859,73949,10249,54028,55631,78804,95179,49951,78606,22010,60811,77972,58182,88027,35796,34033,52691,54249,41219,19127,24351,99143,40944,24599,38513,21421,90688,83795,4929,3808,76103,57633,85952,52497,91607,62869,44488,99122,91885,93407,29424,25533,55030,43780,32098,33944,10004,93943,17215,16606,12586,16798,58876,59657,5599,23274,85614,85125,3264,13200,74872,90264,44374,98759,53687,11981,96007,36528,91821,910,1788,82542,74166,93475,43964,35363,16660,88849,70060,85035,3126,41152,19646,8617,13243,80757,86802,43249,75721,33909,59999,56073,48055,15248,44321,81373,94915,53208,95527,96884,35195,44902,16850,82071,17476,74945,44889,21472,15663,87942,26349,42186,1358,88650,89328,39779,77002,49500,46995,84516,88909,13649,6463,84912,1908,64028,70375,78789,42088,57083,56983,54212,96245,76810,36090,18076,11033,54849,35559,29785,30571,96097,81972,55304,31310,9869,34781,79536,7135,76390,83783,65989,22968,22286,58709,49790,27700,68500,87654,90982,50532,56683,18601,26682,54903,77519,89748,9799,15143,81532,24928,95943,30356,41812,46913,12268,73519,76857,83161,27046,63866,50060,10385,58410,49709,39068,1190,69217,1264,75085,38273,12992,68924,826,52763,36330,33132,82030,56498,4382,95307,96701,51383,7151,18681,11621,81917,30181,44841,38403,69350,41584,30042,59844,64714,46064,41037,54107,80290,74815,89276,26746,19159,70195,53426,12223,33280,34177,7419,37452,39294,37863,22760,97634,69024,91825,45764,98454,93573,9764,88180,99707,33939,43483,22749,116,11348,94040,69724,30347,90599,84137,51425,25695,42703,71303,74839,582,68409,50860,49349,21583,83597,13835,65633,42589,50042,81322,22030,66334,56728,64305,88568,8441,68187,26072,63411,184,79569,58101,27546,68916,5948,58911,37488,95000,51075,62072,50605,1401,86391,67277,75648,68702,82840,47289,45041,6121,59767,58259,94976,62024,86577,4921,91680,90987,98049,3370,8323,3471,28617,1041,86433,6628,78765,75535,85942,99876,11743,64105,1085,54272,5946,25865,43020,10899,97669,54727,78475,77436,23490,56302,77595,13011,61720,27561,15442,86521,11514,3640,65342,53968,87304,44230,87484,58858,71802,80945,58747,98739,18164,8219,53282,99879,26972,48266,76816,30931,41005,66163,60355,77180,23708,82507,57993,3776,81172,26791,7886,30681,29958,11538,69669,45300,33257,26660,8620,12037,5111,32564,46766,7160,48800,47953,23852,42527,53458,99056,60654,85648,4347,7573,16195,15041,63757,51327,90654,58298,27711,58684,42005,79239,70962,69397,285,87436,31023,98768,54901,4889,5210,27744,41604,45750,14327,5919,99427,26440,36372,42474,79187,57499,84589,97370,62821,81864,13351,20162,94992,42080,87847,89457,2976,44241,16798,11939,11772,53541,66307,85858,29256,70066,68808,49092,74012,67635,91701,59209,13075,95785,12673,74793,22507,48714,73269,4009,27947,87096,83994,21608,66057,41002,51556,1230,12061,52154,49444,38241,41585,70361,26274,17133,37114,5063,39518,34525,32209,49879,81171,13710,85526,39396,97148,96147,85740,36349,94855,16360,38920,85948,93224,36913,57717,30893,2047,64593,10408,67468,16619,551,3430,90321,55256,99702,88905,58672,60704,73866,67028,13992,65773,29851,20001,10818,53083,93732,10694,99317,4141,42317,25862,86817,24776,17639,65895,26367,87407,17325,72686,21235,80583,8262,48057,47186,50475,84922,25246,75970,27356,30928,39485,17922,45662,96588,67011,11927,6079,71854,44094,33915,79868,19563,13684,97207,6570,41868,21700,78919,81996,80465,95547,83901,79912,29668,2545,15409,44473,17412,1205,35289,74862,49394,99487,56959,27187,54565,44006,48775,96561,84039,18375,28079,56644,57402,93267,98998,52433,11097,66658,1917,62189,67419,18354,90688,14133,58226,66788,72798,73975,2676,29089,46216,57168,31858,14539,21491,1980,60827,85078,50030,75298,85965,83805,24272,40234,35784,45496,81809,92478,42148,11825,97474,63618,91121,92961,66887,50840,99500,30540,21227,67758,1126,68955,46334,93006,94828,22494,59097,81358,85872,34539,59373,90667,33853,96625,82484,63100,29518,23047,20423,4130,64166,23392,78464,46672,10947,4642,59282,7424,28147,36558,22323,99637,7503,32715,30667,8459,41960,56263,1303,83214,33306,79828,55135,76966,45024,81558,95746,29584,63181,34233,52753,72452,72661,25863,20809,8226,37716,78609,61726,5044,83667,15007,86033,69497,34134,46292,47036,44106,24338,16983,9418,4266,3223,15206,85520,15047,78255,59629,38744,37845,86673,32376,61872,52978,40991,72805,53301,63069,29699,34963,10204,38504,61651,17843,78005,62178,8631,39098,21223,27162,28986,13171,40605,86967,99187,34253,75604,78222,21607,51502,37122,54650,7238,36425,91112,99853,58222,57393,59959,36403,46402,59009,75998,60926,75669,32002,43097,57408,45928,48417,35410,37508,80193,95462,17311,78281,94845,67426,98387,79615,54083,96037,42614,2736,4609,10067,37064,61347,21151,65099,79236,31696,32492,91090,45960,73501,2860,57716,77202,50400,49148,10743,64733,75377,8486,71281,9745,90507,97125,50528,56710,44938,14346,7526,39868,5153,37809,53112,75367,16231,18903,74719,54512,11877,25113,53793,14061,81601,79749,44264,2767,42021,27928,66801,89375,81627,66008,98418,92502,84565,68093,48533,27557,48596,50731,21920,41683,66514,85865,77949,80852,41114,5928,43887,74590,99145,45816,19056,5545,83618,57599,70409,35143,82589,46843,34205,81080,90712,17231,68253,95784,95194,41815,98043,40911,84619,80417,51811,98819,26016,91646,78016,65054,22177,61634,22410,32382,70670,44858,29257,4965,30245,70935,78841,28807,88835,27557,46371,46799,88909,94858,74960,7895,98050,97432,16125,11822,58915,22623,991,4374,1276,83321,67201,99184,29141,17228,87466,98616,30530,32355,93451,92955,51449,67806,40289,10912,24266,84228,54684,70187,61678,84892,49420,48864,80748,35195,37640,25440,56179,76959,92703,37196,29015,24623,56944,21620,76229,20071,62160,81760,70620,71133,17762,15850,19781,36622,50240,74444,31938,98036,52714,38006,9898,95901,6215,44333,48139,48697,66802,70660,18074,90631,16557,9527,84928,44893,43438,3342,61883,25775,63312,99920,66624,48726,43189,58960,19424,13100,12020,17088,85068,85020,47341,5302,36451,42886,74871,72408,31750,64454,26569,97452,71608,97411,20173,31750,55150,51213,27787,45587,88018,12849,98005,95792,31461,82361,8945,1811,20650,74809,1824,42139,10991,75383,58605,23231,63144,81517,60604,77470,77430,77101,7055,51092,35870,39953,73871,92571,99863,78856,38288,69616,11287,9393,82013,79420,97488,15700,39182,88721,99694,6912,64744,78001,59915,21157,63988,1152,31669,81684,52017,30886,9295,43893,30042,13588,93839,77690,25275,12751,49578,33861,38707,40610,39797,85096,68066,61396,32803,2099,80776,6961,35768,47906,12620,24965,92681,64748,85420,10795,89104,20862,32365,99899,16469,35718,94991,46711,46927,16585,29825,72122,96762,92975,11286,17519,19616,69615,87869,56395,71482,94388,28358,30180,69039,68408,21580,2672,45166,28638,43703,47897,14563,82669,24633,45591,58444,78881,37811,94830,39157,45758,21899,47663,38575,75968,98349,91082,58907,8468,66218,91032,9249,41650,35852,8136,45244,53551,7579,24789,16858,52473,44177,63785,831,93876,62232,85510,44150,99483,23101,78037,43817,29977,17597,20882,98846,65671,22488,83460,42240,37443,76097,32541,18453,85561,52771,62581,7142,42320,13174,96262,57382,11978,94190,48429,67113,89183,53905,15810,49287,97084,29896,33096,87563,27679,69423,98487,71484,83100,12752,28564,52201,53288,50598,84606,19066,20744,33641,37000,83749,58369,75655,40215,62325,52600,79120,96599,31796,68834,91525,29112,28734,29076,29652,65618,78924,27328,27005,72143,63534,84014,85124,37703,30329,38896,11430,32551,2374,47800,19268,80930,12987,15460,80227,62185,59245,11841,7376,75101,54614,97536,94942,76471,86900,87716,26911,31424,57684,6699,69132,60887,25146,90885,42533,33023,26141,64201,75776,43230,47710,57307,68828,12541,81726,86643,71213,76800,35464,16573,62633,23510,57326,14790,85009,92185,14039,19366,35155,24870,51161,33457,33338,92092,37673,2499,37193,37418,50528,33300,95874,89626,43293,89532,1266,9507,5170,86905,27354,700,27143,6546,84710,87732,39507,9639,8700,5688,8588,1137,97966,38811,57129,2714,16258,74842,19919,93103,26813,59030,81435,76598,17991,32413,9844,84138,66540,25934,72226,76907,7164,77065,73634,11014,81771,23170,30900,21406,83945,62853,19914,67975,52079,63061,96578,47508,96665,28311,10266,51943,96969,46545,82250,54866,37320,90374,55205,37924,90314,35732,61640,22737,73029,76269,48577,36123,88024,30411,36768,58580,25177,39413,7087,90752,89737,19889,53925,66046,85906,19119,61352,67761,74979,64126,82179,37650,10182,72940,50569,28720,47999,52349,54024,76479,62964,42231,25792,21169,54466,58405,46106,39828,43705,82534,49323,50845,27527,5547,34484,73049,3870,2039,81547,4866,82537,74884,41325,36377,47325,83570,55197,67385,36610,46469,28948,30807,13367,34223,83232,27704,89943,31608,27475,19869,78739,32312,38254,33251,58201,52885,59637,12867,96914,91824,58414,85611,63108,68138,84750,95665,99955,47101,64815,24638,51959,56458,28051,72372,96216,250,82332,87498,20249,95653,21012,91067,55695,39463,75281,52225,4839,23215,43806,87007,72795,93194,30835,54698,92144,19814,66080,80549,31571,6383,58183,14351,66227,3895,31890,30574,60104,19331,3344,42827,87259,80659,37377,71732,65075,16322,37836,39696,79983,94909,56826,55598,28209,79698,59485,50235,4559,25845,65207,84800,39162,72718,19868,92459,64004,70599,12639,43056,86941,21896,57054,97596,11427,18060,74258,51153,31433,47180,9034,7686,23035,69721,53536,42273,83235,32838,888,34434,18343,50441,88710,30936,39364,65701,15832,14180,82548,78218,46290,85903,5475,81151,21426,6481,52843,72183,68204,38850,71890,1550,24063,72138,38748,69813,19681,29902,94075,27423,63557,4222,62445,11103,3124,1230,27905,92463,98800,22143,86344,17397,68412,36014,61421,65134,27383,86755,90865,25082,60585,15554,65856,84462,64178,14570,79020,12297,14871,61108,40383,69732,87647,32660,74029,7885,23504,70459,31931,4331,30515,33767,44697,33819,66448,18485,64487,87313,51432,82646,7973,64598,18898,57406,18443,33416,4519,57466,89717,25981,98060,14144,31705,59704,25876,49970,89055,77571,42040,49306,70031,51571,60272,13461,83128,46589,66446,51338,13670,36294,20379,94918,90767,34685,73925,25336,22219,74249,73124,73041,99335,3497,4879,71639,29575,81919,48549,81584,34377,67661,98288,45231,69455,60252,56752,64458,31341,17391,51935,7417,46008,12743,14043,49114,11552,72254,83928,81437,19404,30358,59605,94426,8471,49716,15075,55219,24467,5865,93129,92021,22310,5153,73492,98914,25424,77921,6072,48157,20050,30610,89175,6586,90150,33461,75736,70107,25307,10561,9272,41779,85298,87016,5212,71000,27467,57129,21706,40115,95044,56304,59647,10792,40402,76311,89527,9552,94617,31063,13100,6601,61454,38578,19069,45220,53219,40653,11622,578,40548,85546,33678,26756,16741,89598,65638,9606,12882,48671,6434,22048,69064,10794,66613,78268,56242,79007,95634,33655,90836,16347,39415,83467,69049,79831,54315,76265,2773,92241,60294,32487,34655,21431,73754,69457,17150,75426,71366,20778,14907,955,99992,28633,90962,15680,50897,32284,76939,66316,76089,20499,11861,56729,31986,82896,96261,59864,64512,39461,59966,18434,32753,68009,26347,44419,46137,64277,83511,95181,35018,36199,66200,11254,79106,39348,61073,8473,1697,15748,54018,58701,28198,40831,23180,31948,26381,61884,74801,39762,28802,29718,55754,67437,90960,59825,67521,59479,56297,35715,38733,36265,89927,91415,63941,76432,63986,38358,35476,14181,24904,82633,99992,60985,33736,25068,14179,47973,29512,59563,44291,23600,94139,15583,10794,23283,70510,56033,83955,92781,3599,82889,56372,55509,13302,80945,84848,25870,87387,19069,92540,39650,90997,9945,68272,18527,30084,9311,78298,54402,69157,90287,75227,43629,5801,54487,64010,65675,79774,57553,65276,77056,5416,42653,59653,8098,10779,75247,17546,61136,61057,67177,66510,67992,92273,97131,89629,38966,56021,4154,73182,65183,26634,60272,23126,30141,42477,89783,81059,42408,78853,79961,88583,41467,56273,85753,58152,81762,45916,57087,71901,58534,5598,57441,39663,64552,71950,66327,99201,7973,83463,51626,74468,56054,37883,37772,18046,12112,72781,13654,18002,63559,67858,67760,87249,48568,81424,1917,46760,48598,68526,1950,4290,4444,45465,58137,20685,23395,89746,74694,72679,53787,9794,19202,8991,35157,40507,4191,84152,19847,68599,14227,93463,92393,70496,83048,32782,36398,19002,7457,29083,38633,53773,18650,65321,41047,34295,36662,2403,86560,79538,66664,7165,47130,49044,139,13093,88741,178,61871,83905,99473,8984,90002,79009,15337,50465,96699,89835,89193,12709,80425,57791,65843,21615,43379,98875,82865,89803,75544,14387,8144,85792,99206,40003,55716,10643,46601,1748,91335,79053,2839,78822,477,29702,67150,73828,44888,58709,4516,67756,8929,47671,10569,79640,38362,41779,58445,58694,79153,15235,63567,1799,86144,48498,38235,75256,49484,39394,11993,34221,21928,72566,89969,24521,49587,22916,97986,88890,67065,63705,33203,15091,89751,83810,360,31289,15585,68959,89647,70223,27944,49454,58762,32969,14690,8348,64213,68537,17011,53988,74069,84297,5879,38815,89174,44154,93779,5708,56837,21213,10504,48040,15595,87582,67842,39557,8689,97150,37407,8323,13732,51982,73265,58356,77136,15535,53930,47222,44418,37254,12456,53676,93003,83118,8459,70658,5443,59112,86920,68721,31978,82463,93535,36927,59726,45078,96315,20197,74758,83497,74483,496,92640,66104,21805,6617,24363,50727,98415,48161,22435,15644,81865,19426,29442,12979,94958,55248,66598,66316,80520,20735,30592,74707,50248,69402,2368,7647,99996,58492,73577,53470,61169,23276,76361,55607,51002,2122,95538,4761,60453,11917,55876,46068,87695,20776,19200,52020,74574,88063,61512,80651,71177,61839,95669,24626,16725,73082,36964,19927,57819,54828,26367,55824,5233,47607,24006,75900,45172,77567,18182,84679,85331,92114,33060,65589,50219,12198,12955,92517,38831,50746,61390,3914,80098,5499,86175,45434,99555,87765,55015,64829,22461,1725,42258,83474,73906,50464,11671,34505,36128,81569,31704,56426,42345,61274,88291,79644,23851,25452,16779,13514,24897,17378,57865,78875,3675,7473,93691,99468,87846,46351,83414,9820,52242,85856,18941,70024,54667,98509,75987,4571,40798,49036,5021,42086,89941,36024,15078,26664,83459,29092,71535,18952,44923,44455,76065,1939,26697,19806,17954,11756,38536,68088,4060,76907,98448,42326,39405,73324,38868,37265,81465,50284,51495,94577,57922,50683,78544,66039,56899,10630,61248,31644,36080,76673,98862,39901,14253,23634,48696,71748,30668,12290,46667,71299,33041,70036,90190,16705,30010,29588,8059,25652,75699,17970,50377,66288,3569,11660,59005,57298,41828,74612,27586,40357,58702,64982,21873,61310,66811,97621,50527,16908,37553,13069,15852,50967,56970,9523,41567,20772,10538,24169,9417,15352,38486,84502,57688,42947,94502,49601,91139,66542,53901,19713,1542,80738,56838,28267,28551,30521,84938,34371,4601,59931,21025,84697,49357,20730,77752,94827,81822,75253,31306,99922,34710,88674,39353,90770,65710,25061,73685,33995,89334,13584,72629,67229,26485,47316,94182,21428,67792,86210,70662,75377,78381,28319,83859,67355,72093,24440,39169,65376,36855,86988,28045,51117,49770,98957,97738,33731,75756,16567,1084,10073,91137,362,18769,83445,55374,33125,10528,18474,24865,15883,77522,19116,99779,63469,13171,57735,89213,27945,94218,61280,90105,86696,5988,67807,55669,52499,9931,987,17700,92762,45156,96817,59405,56598,60998,5246,10231,89298,60900,66344,41572,33526,9943,54042,76413,80050,40437,30537,13637,48263,1179,13697,20573,59313,51332,64382,6255,80764,43604,1607,92220,33321,37738,32882,46841,65082,17525,1106,82081,86392,15758,24220,36808,15878,11752,5649,28470,85484,61113,63682,93214,16387,51711,82690,8335,51109,23429,28955,89734,57296,13638,63393,89149,73035,31293,7565,22728,30251,20976,80149,6910,85184,38107,13107,73815,16922,54356,71056,29640,48295,46660,51700,6237,99206,66063,22394,16388,13956,87528,70623,96783,83751,51587,86546,12466,28636,85458,45861,73985,7075,72039,46743,41276,44419,94580,80348,61337,27143,97313,88989,86270,49156,84025,14871,67107,6284,87102,38068,82836,678,83348,51815,73667,15447,2896,62428,63982,33004,98166,79862,43571,81438,69018,16730,33023,15460,96968,62226,77278,16835,6166,30919,65760,38444,31690,82579,53044,94396,51278,43193,83526,41595,43737,25667,28821,574,35149,22279,4443,73290,55714,42564,74386,73328,97579,5402,86941,94659,77654,58203,53520,8357,45466,67521,49037,50571,51092,69339,70653,56283,11808,689,55820,81852,46741,82738,52174,36802,97208,59127,48053,57071,67157,20972,57723,66650,55921,84597,93614,73393,93777,11590,109,36379,62036,48878,37953,32103,68048,73893,23071,10323,18888,62337,80713,49513,6895,56190,37583,98162,37771,83083,53635,96289,82956,64913,76241,56049,39396,25324,76506,40227,74485,37624,82307,70165,72805,51297,333,88442,13148,53249,1191,76706,45544,24727,82590,58132,41200,24304,20847,69769,60921,42454,59399,4919,2569,27799,96364,34185,39033,96732,34616,37426,31358,20353,11232,22171,97364,88176,45210,16222,1600,29311,61301,69436,4469,93132,60366,68054,98671,39749,31351,98855,48443,58050,91747,49751,70139,73219,10047,76029,6371,83335,28636,98305,2780,29969,41305,72383,97802,21433,7698,81980,6625,37732,18077,72984,42051,35718,89803,41982,95200,99971,35042,75260,9486,99186,88788,21522,49158,96983,2459,96715,27058,14323,66529,79929,21077,4441,99157,27576,12722,9271,71581,29838,18854,23913,88819,19459,11374,33579,57133,672,31886,41683,1784,44900,11210,43773,83101,54979,52515,57035,71428,32744,80631,58367,95043,86291,35380,22731,90420,78442,93392,50608,6724,60137,30721,33162,21742,58831,20815,57996,85952,58463,36237,72963,88226,94794,53179,31490,18224,55967,70624,86919,21840,74285,6500,79309,83847,41534,73911,45225,38887,37072,12054,91939,24721,85489,1531,67442,67068,18182,6022,88013,54439,83485,72896,45035,91945,53871,5988,34812,21712,16207,92700,13915,92821,82278,3167,79520,82933,41302,69483,16586,37249,28184,6496,43468,25647,8370,76587,93923,53383,92240,81033,797,32737,92692,39964,75296,37005,9937,66168,39210,76207,8840,85285,7540,31035,29736,99918,91261,64452,54829,72417,9901,65987,45909,21157,19399,52437,82703,93828,21523,2057,31048,18800,46336,45391,69837,3140,84883,48504,2422,33693,8220,2309,6866,5164,22411,44631,38122,69445,10897,30719,98314,69516,76684,61402,51718,41874,66073,19241,17324,81766,3314,2396,96655,90644,51035,61793,57006,22326,80864,6596,44014,2898,34339,19399,97807,38511,27447,85907,81552,50828,30024,39209,81750,90078,66108,11541,50511,6097,18891,91937,17802,24418,31847,96142,48906,32765,3611,30029,22384,10708,68722,16979,29739,12008,89176,86302,95832,52836,89401,93402,17882,12649,73823,20585,93933,36886,8254,66561,51377,42979,71241,265,50730,6034,89340,25408,83260,64899,66279,37709,47940,65697,44784,72091,67011,56586,88467,73046,50671,27227,64274,97435,2359,91745,61903,90538,74411,41533,49076,8309,29322,59171,46911,88441,45841,56109,83185,33200,11355,53233,44500,64606,4034,2562,97946,13005,28691,42960,71490,50984,41878,14231,83739,38318,67453,54097,24219,63729,97246,60695,87008,92875,45210,14879,83082,39273,15475,17946,30453,71371,69348,14997,70877,22072,96905,6792,1768,58682,25080,86682,32125,16201,68470,18482,9360,6359,10168,79712,52447,46582,34948,68701,55234,25159,90598,66969,12786,93459,96007,40027,13883,26097,87893,54460,63521,21674,85601,28519,2676,4181,76870,91520,6640,81226,22855,17772,71676,77204,96905,92389,49279,34216,39711,85902,21033,30531,5447,92131,97224,69909,47387,47754,80273,5915,87176,37961,26818,39420,42207,41188,29895,82989,20278,58741,57728,41724,95858,92637,60685,20073,45730,49566,22166,51353,79126,82372,1913,49340,47949,28619,92971,84804,48678,58270,18797,49780,301,27845,93683,40770,87213,13775,33284,26489,19083,82647,28320,42126,60516,40890,40158,47313,4425,47854,71301,38615,11354,56200,41804,5412,14209,73323,50163,4779,2539,69087,16861,33424,70967,50697,71845,83094,1255,79605,25959,60327,14521,75415,74187,40576,41439,3332,77150,38268,51654,55003,9801,23914,68879,32185,43987,89160,89554,12970,91545,77539,35261,90176,81575,5660,99784,38830,53184,15926,8759,64751,51663,92166,67371,33060,45499,5427,13403,69321,47393,63345,57136,91566,75461,56257,12713,96729,92912,75751,50289,20356,48969,24802,78617,71844,69136,59158,99745,82049,27661,44354,77923,9715,13048,94677,7133,16998,14397,62706,81013,76860,25276,38191,53987,23173,30352,997,8434,12379,1658,51786,7712,53366,15126,88163,59637,97581,13939,14022,31029,30472,51602,40278,4174,77523,68092,56076,21053,13420,86329,22586,98143,55033,93817,36564,3625,49766,17035,31611,13692,4632,85136,48602,96136,47702,21375,39616,96672,36688,91653,48190,36337,64582,73876,65202,90329,55826,90678,85622,22775,81994,67429,80813,24895,62671,87973,85921,90,5869,79051,64005,49955,62337,48479,324,6102,11581,73506,38982,79443,89742,35621,45317,41589,52272,29255,53355,39344,56023,27016,44766,92800,83901,24097,12316,89592,28302,58372,72046,95380,90058,51802,43911,60622,17344,49654,68275,23951,18357,87383,2530,92735,76691,8365,18585,47779,9906,19764,424,97982,97391,5062,22830,75166,69900,50506,39931,37606,646,96928,49644,42559,83905,48832,45121,829,55473,33676,57629,78956,97631,24862,80740,26993,62043,5832,25288,24840,22984,22475,33369,67109,71641,83595,22921,81444,13458,59706,37941,54708,47284,58478,45802,91048,38046,59936,97140,28901,31747,66992,79924,45982,31807,1808,80562,27520,34189,65381,36382,56323,40752,15136,50652,51900,47593,92968,93551,96037,70485,16952,45419,14711,18285,2631,14888,39550,38689,7789,48219,39593,80573,43258,38228,9188,96169,39036,42957,51120,87640,10239,12221,11894,28000,50586,23847,63416,15027,37801,93982,26910,73594,74835,2988,17641,7672,26912,41035,35472,38153,29289,17845,44585,5534,3637,47550,26080,65763,51568,79146,30285,20554,73984,70441,37475,30030,49921,76689,29578,65564,61069,49597,17838,23947,69941,62517,67788,91140,12630,45213,44954,37368,73705,92979,45116,52911,14341,4946,55042,10448,98320,86658,99240,20857,54218,92504,48020,7170,19983,94038,1548,6118,65702,23077,93092,68832,3267,55468,32755,57303,83277,33714,38798,86481,28349,28996,54392,67590,80655,62188,90125,20365,19152,28245,34345,11452,30235,83493,72415,96710,9566,32348,92333,44748,5577,17156,97369,40980,95893,36480,93669,10193,40114,47929,56266,8294,87053,75469,49993,75683,16022,69118,19962,95443,96201,6058,94296,3134,97613,49732,64484,9786,2705,21501,5647,76088,80182,71859,67780,57077,98136,48990,8284,17646,69845,47005,32909,47841,66224,23131,65245,73421,47440,87217,16408,41727,68573,56856,85135,65185,49414,87081,2346,19837,17508,83408,58969,68084,94393,7826,39721,23385,44114,45576,25582,45912,25866,44540,48481,8032,26383,10458,66131,75786,8451,76911,85017,15803,57067,59224,47670,69394,58479,39415,44154,67543,88279,64630,85676,4449,6723,44777,80796,12404,34457,4963,46637,11271,14322,327,18983,40848,72877,16079,11910,38562,56940,91362,71076,92787,50447,23043,1213,51900,9685,67302,60335,2425,48816,46202,97883,79195,21825,38068,15043,79129,91343,52370,98407,79203,77224,61492,36080,19392,5419,22049,18652,41417,69597,4031,8075,41347,5676,15857,90887,64640,41344,39060,2980,63000,15642,1571,77265,42155,32816,42902,61941,42949,74723,39786,58360,96088,69065,62087,80495,51797,74824,52054,40719,44342,33226,45460,63708,46064,91205,36948,33991,74630,58624,45713,88335,68779,9718,72638,46599,77787,63304,60358,78745,13188,1499,37764,99584,90370,88199,51721,34800,31336,94071,12384,6713,1181,6251,91,26179,57578,49515,21029,12869,21706,6152,9603,7041,15484,61781,29344,41659,93814,61839,15893,17720,12036,28426,81407,70791,98417,83831,31963,80437,21254,37643,46363,48808,25393,75119,18687,59793,50171,2690,76255,71827,76068,53196,69386,50138,54541,3213,56610,66021,44681,15299,67405,51892,1562,31457,13712,10443,31987,88988,92415,91451,72634,66836,2856,16820,76512,6795,2288,7804,38713,83736,90990,14871,92965,94671,96848,99254,48422,10712,43452,48837,24869,11812,80955,91392,90262,44780,71755,24678,42664,49120,5235,71094,81909,72546,11911,388,53856,9399,7513,9083,3711,41382,12597,83767,27597,30128,16022,93756,73639,51944,40063,44433,26766,49840,48597,5032,42973,42460,15769,6304,16055,66843,22360,53512,95209,84360,74984,58986,12815,27585,94632,13332,32817,8626,48846,57474,44165,36737,84786,59945,78397,29743,83457,23280,23699,38305,85140,98569,45326,51608,79845,88959,83924,674,51803,32579,33782,80784,32029,31684,59754,84076,4371,92190,68020,3666,33730,55114,50970,53906,99716,19680,93205,59766,38416,80900,95007,17646,47224,11046,27733,97836,87322,39349,74568,76095,83289,86914,26221,96563,9605,96918,38008,48619,92259,89499,55225,19925,47425,91402,32540,49197,51021,3302,33871,11192,14361,53588,41859,46982,54754,40127,79015,77968,50847,11828,70949,69226,85301,59151,76294,66088,21413,51983,50678,43652,72971,48628,41991,75475,15449,37741,33255,96483,32234,74297,85744,36761,45905,50425,4726,4709,24514,70358,10147,49995,79985,51647,7270,45569,80593,31468,99308,13022,30020,21058,96042,71472,47520,29259,95855,92427,34666,45282,51160,50804,10023,5220,40692,19412,31386,69674,16525,54019,49012,89520,86981,78396,31764,72283,2593,14375,5305,53543,33150,84131,82064,7853,68541,92071,57798,45764,5078,53229,85094,41116,51926,2312,39101,54156,36331,7482,97717,38683,29935,15575,85477,87506,21183,84888,67166,60445,30598,81971,58813,79081,49025,95036,77516,62894,28393,82629,94966,49769,1606,13790,35822,56235,63533,21453,30665,56303,57457,69805,78941,76339,32134,82820,98722,50750,15752,68153,35252,52120,79967,3196,284,53526,55088,65930,20142,81762,68577,86362,60955,9990,83776,51834,47611,63206,24812,44577,66899,38368,74394,99693,3971,97995,48969,61090,83135,80170,85451,60360,93756,44702,37969,50455,43891,84987,95923,6702,97253,48095,34534,92307,68861,46764,40603,74085,42202,77129,87136,3574,30629,30197,51574,42115,70263,1928,80978,57840,95054,24155,38952,42351,65221,21187,23549,45326,4080,29231,67996,96368,13176,52536,94011,95090,83260,47740,55584,92059,22124,13782,15198,87001,68417,42263,84608,7957,54271,6940,33375,50107,75460,96794,71028,68933,32975,34785,81592,88457,30579,13103,77090,60996,22996,91193,34521,77652,7493,66528,43887,62830,75706,89011,54317,37488,68842,40356,63870,51111,87596,35220,85972,88695,16605,35685,95840,27064,80352,32502,31577,31191,71147,6536,78743,17622,69067,38605,38491,40037,32056,79075,56638,62458,80405,24447,96119,47420,76518,84875,93108,65395,23454,45127,244,74357,50334,55109,29906,19865,77192,2599,70151,72398,81638,40194,8818,42657,88610,79997,31841,49456,73382,94376,18271,79449,19582,47128,40043,36036,36322,66106,41666,31529,60648,22160,89409,71675,91460,76133,92079,39696,70962,59053,48249,95816,83435,78971,58584,35152,82175,12712,16802,59530,71469,39660,45923,62896,6238,71276,68697,978,36276,77067,56450,16045,8548,70153,5119,66293,60040,71004,99706,42711,30030,21694,16599,42606,73652,38709,68591,2772,10185,82917,41671,87747,1464,571,164,76443,45454,75926,9382,48070,62959,64536,12436,7877,91796,75966,87067,8511,4458,78064,65831,33793,46677,87246,91313,1776,2500,46751,62433,55263,30782,81903,27021,97367,20951,3355,42139,27373,49621,16437,39026,16309,34064,17456,53676,12717,50408,10362,45054,35176,59109,58240,6488,42685,41253,79708,46331,38386,85386,2370,92340,21298,45993,86416,14354,53786,54667,36830,37665,73092,29143,55644,32341,61046,13975,85661,89259,5577,94822,76521,15366,43374,23532,94637,1399,63310,54881,75296,28029,5530,22838,12518,64334,41992,1136,86876,93744,92875,85485,94936,39919,37679,99088,15468,65062,21939,10863,28258,89031,56121,63752,45103,60771,63621,70713,7874,65524,80651,7989,18662,51956,64840,85718,67243,69334,99909,21022,8319,38783,2902,77115,52428,29209,57766,39337,67692,79053,21380,58264,9712,57118,56367,93259,22337,22377,40190,2270,56167,27237,35335,61633,46609,32043,14461,53369,28187,45994,73607,24501,89228,32451,13472,32029,20201,57345,73030,73831,7490,38764,92687,2377,56752,42249,5564,43681,73379,88903,9804,75708,88289,32318,26128,74466,10188,63579,49180,24030,30681,14921,91622,366,42220,18598,54004,84674,77509,99608,84242,43091,19642,90572,20605,16109,36778,21014,92953,7491,33842,40876,75329,53544,16830,46633,60260,55273,61001,20861,80383,61431,37417,10476,37453,18589,55126,31711,78801,17976,8168,66424,14615,92137,36487,92563,10221,63089,65710,11264,88734,46192,39706,27768,79487,15991,83566,32059,16133,41606,80488,99321,40853,40633,97833,64862,97104,51495,4984,15759,23503,30244,58105,26754,88403,95493,94565,64340,24350,90016,57300,29098,29263,26829,27365,39535,42916,6544,2907,86857,57266,26964,9093,63278,35077,69532,80672,12800,67776,31815,70877,53656,48084,56823,38129,18409,71192,53,24661,36415,69730,8711,78798,43312,12016,14444,68273,32704,78006,24967,56074,21609,91531,68520,96899,10630,98407,78098,75089,24997,94818,71291,83763,87928,89003,43580,36302,56070,16039,14068,65539,16791,92936,54635,71898,18788,25242,56866,3333,14865,59998,13432,64862,84796,39332,3255,70524,39526,82957,86912,60269,52979,54865,22048,71297,6503,44247,84547,84707,11147,91870,23247,5564,77625,31708,94954,22989,1560,33051,66881,68737,6619,75563,47545,21585,10605,25578,85721,97350,88217,92608,22179,57454,57769,99027,92050,52566,10297,34372,95996,62344,21262,6513,51504,93273,11667,82749,40881,31019,95031,70451,59037,10175,63339,15406,99816,54084,61317,27939,41861,90786,39146,25611,35118,11351,45320,68371,12622,17776,80560,57708,5064,64985,73465,11627,92722,46177,19293,95387,25174,10750,8031,25826,63144,9698,90878,97612,29379,20748,78140,90351,33583,24214,59606,27683,17212,89333,85581,54521,75566,5645,33493,30992,34349,98514,4649,70556,78441,69320,13293,47930,8116,82811,7787,52541,58284,37901,87067,49379,37899,97820,2708,27908,52793,77692,38154,49338,88613,84635,60975,63178,2528,12375,58801,4696,8632,59996,83401,45540,89934,66529,51374,20807,94088,9181,97926,12237,56590,75471,99956,87404,51966,81086,53595,34596,89169,57483,85275,33446,69158,87566,58949,83006,89533,96682,87032,96997,21904,19915,4074,6688,43627,37707,94791,45862,81112,48929,37676,77758,19462,31146,32211,60382,2520,35700,82086,3143,40186,31734,5405,38161,59292,4873,14073,19921,77305,36797,16708,39681,18241,77878,6261,26879,67709,84288,1811,19381,2480,80341,98487,10916,17342,77303,73114,75335,59370,94134,99256,23744,68119,87309,46000,89798,17713,14005,67378,5257,35576,31599,75535,83649,18056,18928,48979,51939,35763,25026,56492,49182,59269,36405,74065,88673,1981,99790,81974,11779,32634,87632,78379,87478,86725,9431,12890,81632,732,99627,40510,21348,4076,70401,95456,87167,97097,19123,36474,71731,4870,34251,51661,90797,2270,43288,47490,29103,87213,60318,49579,37165,20237,39281,7773,381,27141,53039,58322,57687,48140,58485,77925,12104,98936,98554,50757,27392,15736,74693,89040,79296,64420,7208,38810,13829,92569,35640,12733,22999,9384,15549,16230,87884,31653,60780,2668,13112,6050,36624,96747,34448,57731,11116,87111,5276,74571,53663,52289,32326,51488,88477,68045,25878,36720,87174,69891,92766,73486,31036,43126,86619,81511,72108,9386,21131,81408,34406,29277,51467,40051,80751,59621,86059,78403,93293,59825,26040,9956,75335,52547,59498,55533,75856,95879,37524,83656,55794,12987,34281,9717,53825,49382,40719,93972,22961,14534,99792,31069,57357,44239,16199,47402,9295,9950,28714,18289,9498,63720,11191,51494,67526,15085,94850,5120,34296,4975,57902,83789,29512,67780,47806,58373,16958,70311,73428,13514,46345,61169,24707,1471,73187,60956,74098,21643,84760,10516,80016,61688,3750,12650,73470,2619,2860,90101,77828,41555,77714,55965,97251,18693,34324,73895,43815,73614,25561,49404,17553,30795,8201,83427,95951,60105,35295,31373,95984,58344,11225,1420,20845,83378,74307,70849,54497,82811,48434,9646,79626,2361,84479,51113,53072,691,56981,35100,53339,31464,68383,6854,4755,66332,80867,92838,45760,16091,81841,10897,8849,95142,55802,72835,45761,53092,62876,34827,98122,68352,90236,76282,25896,68814,29717,20607,4614,96162,68040,49662,59170,84127,52916,8930,61374,34954,39804,84941,63862,29700,91789,81612,1346,22855,73203,33626,76538,64190,90667,11075,21101,33176,46713,67379,20471,19861,77136,97301,21517,25499,40742,73259,74859,69864,71718,3256,70636,24912,1658,2114,95479,24195,63527,14872,65175,81824,1942,99581,18827,87487,43636,45200,94147,28569,34956,13900,69239,86446,99907,13906,60553,42487,99703,51310,44030,26382,64192,79736,3758,82886,81898,31308,20969,72260,33558,76519,28415,62694,7340,44402,12561,5984,35733,37580,79391,74700,97242,83663,43383,16699,72689,63634,38435,57446,68033,1978,67505,46451,87595,72623,87895,93853,32728,31554,57452,68137,21889,54545,60957,66371,99388,20000,3727,48329,77571,77837,38567,34977,93308,13255,17321,42635,40126,90439,71888,91382,8067,19799,2080,21441,10858,51716,83983,95349,59070,69375,42204,67965,57756,98366,59946,76218,97114,90300,97191,58391,34107,65568,64949,96075,13479,16466,9148,78395,34855,36875,60929,82287,96916,18549,20703,4244,41055,20893,63463,74550,97933,82440,87956,84126,74490,39506,9360,21598,35169,59027,67932,29478,71425,25837,84107,74315,3085,60260,87391,62521,84917,53982,15712,54322,16650,23606,22663,71770,94381,93464,9067,62604,97805,96406,46771,78829,8080,35558,60498,8930,30217,27883,60644,16469,21709,7077,45760,97929,99239,39337,1262,15423,53618,48124,60853,15296,13730,24311,7245,43898,65232,64911,54965,30891,1656,13398,35056,70574,48472,29400,19353,81147,97602,98927,6898,64922,11021,96962,15544,54273,72209,86389,73403,87788,64430,23247,40711,76533,51696,49151,1498,5394,81654,80054,4381,45010,85077,86820,55683,64012,31940,89323,76595,26219,16828,27514,94798,11887,83932,61586,78024,41002,36026,63482,86430,50809,14438,40275,50365,76349,67504,58750,85780,37934,70367,48973,11228,24759,14334,32218,14979,95328,21666,52964,73223,58531,9682,6424,19102,28178,59421,78422,83804,35334,86570,91215,55388,13791,88982,89728,50687,26558,7978,12389,91306,90816,45374,54599,66449,19514,11303,49095,34495,87687,16292,98516,52051,37094,99761,69148,12885,11717,48429,20572,82460,20773,26951,49241,71366,6442,49435,17709,89058,15373,88631,79392,44065,85529,15815,2795,3779,98246,25480,2055,93204,52438,39689,8873,62353,37101,53268,30260,61382,45068,61602,22119,43840,33154,17042,5637,44725,12723,16930,18342,42048,49276,64501,88901,17065,97081,3444,72340,38753,31881,96299,48909,59925,77599,50389,2014,29801,62331,59757,62255,82398,45544,86525,31491,67798,7045,17838,97316,67642,44100,38499,54077,46353,44465,40173,37780,41537,80134,18437,4821,70540,91127,10729,79167,30164,84858,98678,13677,79902,75085,31067,20557,31685,45890,53966,3234,70777,95332,75882,69170,32580,19607,89117,36942,40001,55761,94079,80751,46840,11463,70106,15541,72426,15672,77868,12337,77832,29641,31905,90072,50631,55002,6197,94138,88347,90803,8141,95595,82315,68499,96402,9487,14541,44096,10104,77981,58160,26918,72630,66354,58881,73484,87262,92139,37758,92166,81508,21151,81551,88872,7537,13800,70047,94694,37213,96603,87035,58970,18606,15663,14374,33582,57067,1254,96658,92761,82767,24658,26165,88009,77794,43400,91617,96535,894,2703,78369,53319,16019,78158,10816,48419,39072,87083,45319,23637,1346,99753,87274,96017,84021,88751,93062,6907,75881,85842,32884,40810,99477,77656,96824,41630,70252,46493,46079,8948,81542,50343,94879,44840,74684,10729,25901]", 4741},
            new object[] {"[8,8,8,8,8,16,16,256,1024,4096]", 2},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.HalveArray(nums);

            Assert.AreEqual(expected, res);
        }
    }
}