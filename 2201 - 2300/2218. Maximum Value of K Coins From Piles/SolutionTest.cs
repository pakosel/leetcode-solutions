using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumValueOfKCoinsFromPiles
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,100,3],[7,8,9]]", 2, 101},
            new object[] {"[[100],[100],[100],[100],[100],[100],[1,1,1,1,1,1,700]]", 7, 706},
            new object[] {"[[67,33,71,32,77,48,88,1,95,67,28,11,25,45,38,54,31,61,48,13,11,2,66,6,57,44,65,62,96,93,80,89,18,41,31,100,47,38,84,52,81,70,76,37,49,52,51,91,75,33,57,29,75,95,78,100,72,97,69,51,45,25,37,80,93,31,71,10,80,70,51,3,71,80,19,68,24,26,13,80,11,26,92,66,1,49,48,77,34,83,12,95,36,20,8,64,90,5,2,13,81,5,19,41,53,83,27,71,79,84,22,83,13,31,34,93,72,23,24,53,78,19,28,30,36,16,12,82,93,12,51,32,19,97,55,40,41,45,16,83,35,54,58,88,82,28,38,22,92,88,14,19,14,87,82,81,17,1,69,4,11,65,44,81,51,84,71,29,80,81,34,19,18,55,45,7,40,27,68,47,25,61,71,31,11,95,75,78,59,47,22,80,100,93,62,34,44,6,50,72,84,95,52,79,5,41,75,34,77,17,8,85,59,94,19,41,21,93,3,15,12,38,70,54,17,22,17,80,66,78,68,5,87,33,46,11,50,79,62,37,46,50,71,9,35,77,74,58,21,86,80,33,55,45,90,100,98,37,6,88,69,42,21,72,29,97,34,9,9,8,5,80,13,18,97,8,28,69,20,27,51,5,19,7,76,71,9,53,38,39,49,69,86,88,5,85,90,97,83,56,8,32,65,59,36,99,41,87,84,90,76,66,1,99,35,86,96,97,34,43,5,41,42,48,12,71,76,55,61,38,16,16,31,28,45,73,4,71,13,27,18,21,43,79,71,75,61,48,1,27,35,87,27,16,56,14,14,39,33,99,82,90,7,33,67,92,17,26,29,72,19,44,47,86,16,7,2,39,64,63,61,75,57,99,61,30,95,4,29,77,44,82,41,69,28,95,28,17,48,9,36,10,67,98,93,99,26,41,7,64,4,94,40,13,51,35,93,20,73,10,78,45,24,33,14,72,98,78,6,100,65,33,1,9,3,99,54,37,41,97,72,69,63,41,96,98,76,18,49,61,8,83,53,53,1,76,16,56,99,7,71,78,67,100,26,18,68,10,33,29,8,67,59,22,84,14,30,63,14,66,69,82,74,44,63,92,92,75,85,40,85,86,50,51,68,99,28,99,74,61],[31,33,41,98,27,6,17,35,3,61,42,70,97,20,61,89,89,74,63,69,66,52,63,56,62,80,66,97,50,36,19,35,54,53,71,64,59,94,19,76,39,48,88,55,48,33,23,34,93,43,12,10,12,3,44,26,75,90,42,25,13,72,16,62,62,38,65,1,59,43,96,78,2,91,39,88,18,90,27,100,74,15,63,87,19,36,23,68,76,58,75,52,52,94,62,4,15,17,55,6,33,6,88,51,38,13,68,29,78,25,89,73,94,91,39,93,33,16,9,30,94,87,81,96,5,89,62,1,47,9,20,97,76,59,90,39,95,45,85,14,34,84,35,85,74,56,26,74,17,39,16,55,98,31,97,13,19,47,38,2,89,21,72,32,94,18,24,73,43,31,2,71,57,65,69,44,62,68,3,21,100,86,62,69,54,85,50,23,62,43,89,3,53,66,63,91,90,10,33,26,62,24,65,27,23,15,75,100,9,51,54,78,96,58,99,32,13,54,14,15,36,25,14,52,39,67,73,66,95,11,6,84,8,62,54,97,22,30,54,73,79,18,45,52,81,32,22,31,19,36,85,86,15,3,76,19,68,90,6,25,15,26,74,30,79,71,22,87,10,8,98,14,23,80,51,50,94,84,81,88,78,74,60,86,52,83,78,63,45,84,40,76,67,16,63,36,27,60,19,97,20,71,84,24,6,54,57,69,7,44,87,100,22,44,94,96,98,21,75,51,14,61,75,48,74,21,52,95,22,87,20,21,72,60,59,27,33,41,74,41,29,84,1,63,59,12,43,55,91,2,39,55,80,83,69,22,26,51,72,81,50,37,68,86,8,80,63,27,47,6,17,99,28,61,27,7,53,73,50,77,3,33,18,6,25,47,89,45,23,58,43,78,45,71,79,21,35,53,16,88,54,64,69,96,57,100,15,29,88,79,25,73,50,12,5,68,33,49,6,38,59,92,62,9,18,8,8,8,68,12,14,45,55,86,9,54,36,15,40,72,61,23,24,92,81,95,83,10,33,81,99,48,41,94,30,91,79,40,35,2,18,5,10,56,37,64,20,88,45,45,32,57,51,5,30,78,49,30,69,72,9,54,4,92,82,81,20,4,86,61,45,7,69,11,75,29,60,38,30,48],[33,30,40,9,84,82,21,39,99,71,90,35,51,99,77,31,80,77,19,9,63,56,98,5,96,66,48,19,37,14,16,65,85,90,38,22,67,49,46,57,22,9,77,49,81,56,70,83,24,52,98,50,72,99,15,63,35,88,89,80,65,29,97,8,2,1,64,78,91,11,11,77,74,32,21,98,37,80,57,33,48,31,66,63,1,88,71,14,40,52,69,55,83,49,19,21,28,99,80,93,24,75,73,85,17,45,73,38,39,59,55,86,74,38,61,37,67,99,91,49,32,45,28,51,15,11,52,76,49,26,10,27,38,64,96,41,55,7,36,4,14,23,74,4,83,68,24,69,9,27,98,43,37,56,9,48,19,18,71,45,50,32,34,14,71,45,4,23,58,56,77,45,44,51,72,15,8,79,87,43,69,11,34,82,29,38,69,28,32,54,11,33,52,58,53,14,59,57,57,63,81,72,29,35,2,100,81,35,42,1,9,87,40,14,62,34,4,79,86,69,88,44,11,73,27,39,59,25,60,27,92,2,52,7,2,54,10,22,79,91,12,27,75,78,21,42,54,68,22,84,74,61,60,90,41,43,23,76,41,27,7,74,49,54,62,93,72,90,2,31,4,44,48,56,86,4,44,84,12,82,24,88,63,72,69,54,81,32,14,30,2,21,76,25,99,55,54,68,33,84,76,32,94,21,12,79,6,67,87,44,74,60,97,43,15,13,93,21,17,68,16,31,27,46,34,12,49,53,43,34,68,91,68,40,8,91,86,58,91,69,52,88,69,1,80,65,50,21,85,82,88,22,98,87,59,98,35,78,59,17,29,51,95,9,16,7,87,31,81,22,72,57,40,67,55,82,13,3,34,8,1,89,58,35,65,86,31,29,56,73,20,84,8,47,61,23,82,9,24,91,59,40,9,22,82,91,41,58,92,55,37,18,74,67,31,44,3,79,25,57,99,48,28,29,3,34,26,43,24,11,34,72,61,4,67,52,27,33,2,16,6,70,11,84,64,28,59,63,23,78,13,69,12,77,16,99,28,21,53,14,92,30,32,90,26,15,43,73,48,30,10,16,15,15,36,39,86,58,91,68,37,22,33,64,91,52,99,94,93,93,71,94,19,30,49,32,21,89,24,24],[52,73,15,38,78,56,92,69,81,51,100,35,27,76,65,64,44,70,12,47],[69,100,70,37,13,57,47,100,25,4,58,61,14,27,37,29,93,67,47,2],[56,65,83,96,76,76,26,75,29,57,93,87,84,60,35,30,19,20,70,10],[2,9,49,20,50,96,53,48,72,41,9,30,35,13,53,83,7,10,31,88],[92,44,24,16,99,19,43,11,44,34,17,64,42,68,53,90,57,18,27,36]]", 20, 1426},
            new object[] {"[[326,891,468,960,989,915,557,264,620,62,756,412,231,954,764,186],[779,739,404,94,283,225,843,977,884,213,784,133,211,933,706,858,553,484,20,826],[846,847,251,630,738,441,295,301,167,854,475,469,516,870,227,326,818,377,337,944,586,89,851,261,326,397,961,546,690,49,947,966,547,393,857,721,132,652,648,279,191,431,115,337,156,440,636,499,550,878],[401,603,574,190,40,152,842,886,301,539,357],[67,291,889,567,521,65,30,697,376,831,274,761,488],[810,476,80,998,133,987,214,91,363,542,251,290,163,523,834,301,569,233,823,28,314,734,937,145,203,864,266,254,657,678,428,700,151,492,347,715,933,138,414],[524,976,535,117,83,706,922,248,215,746,231,935,793,2,627,746,452,836,208,917,676,194,587,97,824,274,477,744,128,506,235,8,240,467,186,202,620,91,251,336,67,446,939,733,500,754,247,916,809,12,939,706,771,141,337,368,897,70,219,31,498,455,76,344,825,818,405,743,97,646,972,47,844,97,301,682,365,193,697,455,439,330,782,333,687,471,989,115,230,107,926,863,280,476,626,782,394,199,259,169,722,390,881,218,166,365,516,672,930,200,607,471,824,763,101,444,117,510,49,408,809,103,746,597,538,161,892,773,662,914,328,586,443,66,208,185,301,544,285,978,861,588,311,475],[114,778,774,301,199,17,146,981,478,913,898,944,590,787,81,548,632,96,275,37,244,858,333,522,462,595,447,687,103,591,18,612,453,670,124,146],[925,654,575,819,647,486,349,766,430,216,868,546,806,482,727,504,304,821,269,170,83,931,667,329,556,962,52,698,373,166,740,342,111,686],[844,281,799,70,283,116,593,178,29,230,303,354,133,944,41,71,613,608,410,433,668,468,288,769,628,369,994,833,61,567,15,620,497,951,43,762,780,681,158,768],[866,46,379,237,643,448,53,404,496,782,417,615,364,275,497,999,974,433,297,638,991,830,23,546,836,458,676,474,407,252,248,786,485,424,774,759,217,211,654,505],[282,694,400,947,849,425,419,92,149,512,346,412,695,713,157,550,96,172,660,709,516,593,586,912,677,802,130,433,293,889,572,494,951,253,473,296,424,728,296,529,716,72,411,569,882,572,914,439,283,606,552,355,287,31,267,863,44,64,518,634,421,80,812,26,514,11,493],[624,595,691,765,580,510,771,842,590,638,522,240,700,616,126,148,856,736,739,155,208,824,618,789,412,70,947,20,376,524,895,827,14,587,908,115,944,214,428,142],[557,399,186,333,457,694,212,533,576,126,12,174,550,123,614,523,394,607,806,444,733,352,54,460,692,788,797,347,507,697,190,790,309,657,103,841,636,488,572,381,393,899,586,944,700,748,566,334,210,788,964,220,607,662,533,626,867,315,820,939,929,732,428,727,328,622,878,645,790,553,965,253,418,329,21,269,788,650,683,581,156,561,786,653,82,420,760,950],[706,533,634,746,924,161,92,787,537,527,795,964,51,425,568,799,20,335,114,453,160,337,275,801,607,620,305,92,923,540,209,434,852,926,814,115,123,260,585,477,69,647,192,994,94,968,349,604,725,890,96,359],[313,440,408,377,569,642,8,64,595,318,386,585,464,898,574,132,475,480,729,635,950,949,793,775,172,331,130,252,279,209,605,743,380,909,91,988,453,748,568,856,646,171,125,762,204,264,968,187,24,500,289,173,336,971,829,591,101,88,471,700,549,457,788,477,376,523,992,568,253,836,635,336,517,235,918,866,985,206,159,568,175,103,231,144,14,954,629,591,317,547],[402,341,117,69,156,645,290,962,263,210,529,888,105,725,220,240,531,200,574,306,727,609,849,576,29,861,980,937,410,557,755,889,688,993,585,651,653,805,535,174,663,335,616,366,167,327,881],[536,108,217],[108,263,260,474,294,324,340,888,67,741,878,432,805,769,306,685,411,385,343,80,932,438,892,384,127,364,56,29,57,332,975,543,686,842,420,444,163,824,966,713,456,670,916,155,933,345,941,490,993,454,965,523,950,511,165,839,247,411,949,336,851,573,422,18,119,929,675,950,545,21,78,599,924,921,646,763,517,478,161,495,423,353,152,865,490],[417,848,55,539,906,956,87,14,457,724,412,163,632,11,83,486,110,995,105,270,208,141,971,783,297,797,302,735,132,21,765,498,896,129,655,962,217,127,776,726,381,974,673,472,47,110,168,35,287,998,402,670,504],[327,784,893,537,176,238,727,26,255,623,851,954,502,715,750,160,345,739,217,836,466,81,633,99,147,568,592],[255,898,651,807,403,923,416,580,690,846,149,738,378,998,850,110,508,555,435,452,411,329],[962,621,877,299,881,501,746,187,95,538,249,579,676,406,133,431,104,11,425,976,560,689,676,505,762,105,606,444,815,593,602,766,919,835,754,640,213,650,939,509,904,716,799],[437,731,311,850,57,331,679,459,166,721,582,68,476,493,283,919,799,255,647,453,486,127,540,300,680,689,790,784,343,571,444,960,358],[551,364,904,810,911,626,320,371,57,919,445,171,189,797,305,524,1000,91,961,150,500,1000,584,754,789,714,407,47,90,20,208,346,809,781,561,295,369,258,907,235,447,593,67,543,87,935,44,403,389,63,888,348,255,420,483,224,484,970,344,537,57,273,117,60,801,282,684,475,845,827,890,81,872,789,804,242,934,257,22,555,970,67,131,353,638,587,579,531,158,842,620,928,738,357,201,166,490,979,685,225,418,395,525,182,885,300,552,928,556,124,977,5,50,150,233,112,887,578,406,787,446,965,15,413,442,624,594,432,93,241,483,220,455,57,847,69,587,376,653,14,267,856,304,240,656,106,729,98,574,429,549,570,601,342,812,996,157,556,516,552,575,909,522,432,786,721,398,194,432,704,687,124],[671,920,984,409,23,676,744,942,544,473,89,388,744,540,88,300,628,43,225,465,360,460,576,802,183,329,101,821,632,285,587,521,463,184,883,619,504,873,579,406,227,690,73,831,206,401,63,658,566,601,201,862,909,433,648,770,865,76],[862,831,853,317,413,705,929,667,71,710,495,750,501,779,302,755,815,575,781,504,57,208,79,727,565,837,945,646,846,485,808,900,499,845,238,228],[840,469,736,863,225,43,557],[882,832,219,726,85,500,169,641,392,413,100,915,258,395,739,306,628,246,891,957,288,978,614,992,718,500,520,462,733,12,314,168,197,683,927,728,238,374,117,391,104,895,245,33,158,498,399,689,447,639,38,884,250,581,892,275,149,967,906,151,567,345,503,455,699,149,22,481,130,389,277,728,345,720,903,278,807,609,368,811,526,595],[651,664,189,431,511,111,959,314,402,744,101,350,302,582,269,517,997,364,829,169,554,860,331,212,930,295,189,134,923,432,662,729,763,633,658,211,954,87,570,606,108],[929],[17,131,576,69,624,204,899,592,924,160,976,236,515,415,356,925,112,124,275,306,768,228,916,224],[181,549,914,861,499,488,540,508,333,362,20,261,278,601,623,355],[688,162,505,347,857,649,859,344,703,283,545,789,499,452,39,211,168,299,657,769,491,829,433,442,349,775,25,44,40,542,536,365,942,288,346,1000,193,423,694,800,853,390,423,748,556,285,862,717,512]]", 1249, 652926},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string pilesStr, int k, int expected)
        {
            var piles = ArrayHelper.MatrixFromString<int>(pilesStr);

            var sol = new Solution();
            var res = sol.MaxValueOfCoins(piles, k);

            Assert.AreEqual(expected, res);
        }
    }
}