using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumOperationsToReduceXToZero
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,1]", 3, -1},
            new object[] {"[5,5]", 3, -1},
            new object[] {"[1,1,4,2,3]", 5, 2},
            new object[] {"[5,6,7,8,9]", 4, -1},
            new object[] {"[3,2,20,1,1,3]", 10, 5},
            new object[] {"[1,1,2,5,7]", 2, 2},
            new object[] {"[148,265,439,720,45,38,569,625,254,662,854,897,974,109,401,99,372,599,699,907,84,539,813,932,762,280,591,915,695,426,628,831,186,914,3,203,774,697,726,799,365,548,305,79,132,507,82,645,344,333,893,371,113,428,255,605,938,36,285,356,650,175,754,422,438,6,12,197,802,302,211,204,118,407,710,527,734,484,869,246,623,600,361,500,308,759,256,252,560,510,236,120,134,392,21,632,766,62,183,253,514,181,601,257,119,52,839,575,258,105,638,517,228,792,219,26,474,794,785,251,774,488,453,933,221,885,54,757,711,163,526,17,454,471,481,717,156,393,166,911,387,417,279,148,668,938,270,819,779,665,489,358,329,142,499,855,409,789,982,699,915,770,586,902,452,719,936,649,657,879,468,469,589,775,317,229,273,81,196,18,959,326,108,635,595,165,556,985,646,98,516,300,354,876,301,210,439,754,726,941,359,564,987,501,59,537,398,554,395,555,308,686,120,433,130,949,9,728,40,576,122,16,669,95,420,288,452,27,969,755,849,88,989,23,894,451,423,530,962,469,585,702,992,500,526,875,402,586,330,527,652,149,1,687,461,901,563,825,964,970,114,893,514,274,153,416,244,614,100,362,654,533,227,827,872,789,766,307,629,328,647,164,350,980,32,842,325,271,670,811,705,187,22,681,790,774,528,301,162,603,819,762,154,211,565,58,344,558,739,779,937,667,685,924,497,303,850,743,766,40,818,489,14,233,679,195,572,960,904,866,394,465,431,469,71,74,390,144,480,940,127,643,436,68,342,247,599,216,184,794,228,569,425,807,948,161,917,258,582,951,430,625,586,756,933,41,32,585,755,511,285,279,832,406,213,663,439,865,882,404,837,178,52,135,411,265,232,727,560,248,718,262,205,375,166,423,957,314,479,278,273,512,902,342,147,373,690,678,766,488,97,49,138,503,21,287,775,506,44,966,960,750,892,698,51,42,184,541,825,717,483,202,736,880,109,307,850,924,398,460,445,353,656,643,920,439,747,631,715,856,869,522,67,833,834,971,535,681,604,497,543,964,186,440,943,574,154,294,420,525,672,329,251,545,814,576,68,255,401,369,790,505,121,156,139,262,986,909,580,891,815,117,650,175,518,493,768,664,686,526,337,93,957,574,10,397,912,922,485,821,671,392,942,914,216,934,117,844,86,494,675,73,122,433,985,960,990,399,650,974,118,156,791,489,998,952,386,889,425,70,452,978,361,404,557,787,182,773,510,61,859,304,74,863,639,792,317,959,259,401,518,674,354,747,582,887,387,707,335,993,419,58,45,23,647,30,438,569,603,240,785,808,31,63,435,535,202,188,4,140,237,980,669,420,913,488,736,38,120,150,96,69,573,528,334,667,442,433,415,370,991,57,357,170,579,912,622,816,820,376,664,206,85,670,749,851,377,286,534,710,422,916,565,943,186,564,484,757,22,394,561,131,121,896,232,831,488,36,434,216,537,576,454,953,669,411,972,178,736,740,998,875,261,177,562,632,977,708,332,122,401,842,849,931,621,123,137,15,30,274,987,125,654,283,181,390,742,68,547,524,693,869,450,620,885,219,67,623,52,549,493,176,187,333,815,280,761,766,769,673,659,765,513,292,288,577,428,987,803,788,528,926,122,833,617,640,967,253,742,953,477,647,863,247,180,777,243,893,510,719,990,209,559,222,536,929,780,676,543,530,611,867,955,661,972,355,607,618,680,646,997,216,476,526,712,61,985,404,658,400,228,699,213,796,68,456,408,177,191,148,597,731,21,264,896,878,644,135,207,696,369,940,502,35,328,188,463,516,912,464,64,302,245,561,296,940,428,40,834,801,582,809,829,121,534,685,25,242,340,419,972,574,201,382,339,173,467,249,865,636,156,310,343,208,159,75,26,284,161,694,282,647,123,167,335,149,526,749,805,207,273,107,254,288,13,781,450,754,238,127,883,445,93,441,411,925,576,165,938,115,309,489,392,90,755,507,499,529,151,704,280,470,896,314,88,21,970,223,639,488,692,18,604,220,668,277,886,961,65,625,168,544,589,510,748,606,359,555,86,210,34,296,610,987,364,173,28,625,194,912,624,209,985,905,618,163,814,568,385,654,324,549,421,195,158,661,313,470,467,241,488,45,396,298,451,472,965,592,338,273,225,690,260,96,828,112,93,154,360,974,600,103,860,553,68,634,891,450,916,71,616,240,894,926,6,109,803,295,57,412,584,121,495,89,221,934,924,355,822,170,841,481,457,743,586,930,486,20,291,49,249,362,805,312,472,304,21,575,439,26,875,939,363,985,389,23,305,664,381,164,260,840,561,727,907,665,949,746,366,276,111,444,873,374,492,773,563,724,499,353,325,662,924,614,649,558,258,568,670,224,455,349,32,393,468,912,795,157,981,380,582,625,1,106,316,96,869,142,535,525,124,881,899,831,437,758,922,841,715,700,350,465,944,866,43,913,18,219,178,965,328,717,860,844,307,61,165,5,963,802,308,840,463,248,613,725,791,101,718,652,164,641,882,739,636,693,43,719,458,68,502,697,468,625,553,112,528,677,822,605,814,150,638,130,523,709,412,1000,764,342,620,177,629,268,639,646,734,612,206,662,414,111,245,837,40,186,435,707,434,473,281,780,816,785,162,302,214,386,947,828,323,600,379,512,399,925,542,874,217,783,288,599,244,355,674,486,11,352,749,552,731,137,384,326,868,50,91,578,607,833,484,555,865,209,6,15,244,789,182,588,207,328,582,958,48,145,976,237,930,170,833,413,755,171,714,136,503,839,89,278,828,77,19,754,520,228,721,500,384,951,150,407,823,757,183,787,315,550,354,141,343,933,36,644,216,879,771,199,397,518,536,192,424,973,345,654,853,126,592,613,523,992,447,653,102,618,861,543,321,827,459,63,285,791,399,578,947,352,585,809,308,395,246,533,302,491,621,568,258,847,974,928,904,106,147,780,863,152,722,537,117,624,411,642,362,903,401,476,336,182,838,873,258,702,549,225,472,635,309,731,587,318,451,757,30,456,665,15,145,725,532,376,778,817,546,433,553,59,772,929,990,460,134,16,777,453,68,20,2,568,514,848,784,939,900,285,963,206,832,340,33,890,528,607,124,321,782,422,84,175,334,496,634,836,852,501,629,241,503,143,763,674,602,979,78,647,724,387,344,766,993,467,597,114,293,415,67,34,897,353,25,23,708,560,762,11,295,859,706,536,119,79,688,210,601,733,947,699,980,746,396,257,694,416,848,73,841,231,930,92,384,635,331,713,226,155,197,632,299,435,317,430,588,742,141,858,122,419,395,829,244,458,638,465,7,102,911,595,646,961,949,752,265,446,208,292,271,410,447,768,524,764,20,753,1,605,6,940,132,127,88,735,282,517,97,579,672,613,780,727,767,48,83,177,370,423,118,989,700,534,568,564,792,228,970,203,111,847,250,109,743,927,86,920,167,960,763,662,225,695,176,102,641,588,936,244,418,919,865,761,29,302,80,745,304,701,241,323,946,468,33,606,969,747,899,267,995,347,944,343,734,230,924,715,536,204,28,868,796,368,38,704,210,522,438,951,451,945,392,666,633,39,408,415,364,117,997,525,618,332,958,994,191,986,17,380,248,854,601,697,960,479,616,121,265,519,766,556,929,298,98,218,660,659,702,507,568,201,263,818,967,295,578,908,763,548,287,214,950,618,340,160,521,97,25,184,156,353,243,294,959,23,503,301,974,874,456,196,555,360,246,676,675,684,689,185,457,12,755,37,152,896,613,190,440,342,441,439,437,111,590,402,792,247,347,66,741,64,165,639,198,607,597,329,86,678,104,270,268,553,621,150,536,915,499,10,396,685,644,753,671,258,899,720,787,281,773,185,779,266,350,876,732,214,196,322,278,543,389,17,614,790,212,510,522,178,472,995,721,301,613,305,783,290,318,702,980,552,760,734,877,932,168,121,85,303,222,640,479,331,410,160,462,424,885,578,867,102,699,439,120,287,139,926,145,574,515,108,136,86,221,124,963,830,722,336,277,743,719,827,148,601,751,328,596,974,504,117,5,385,153,26,122,837,591,641,627,484,897,407,72,395,684,803,930,68,451,441,540,921,170,379,187,865,22,348,770,514,119,400,319,920,94,245,421,238,975,967,363,222,994,38,500,450,270,608,225,447,515,386,953,463,339,179,931,639,781,901,114,795,232,258,366,74,894,610,851,590,868,471,391,163,326,671,782,289,61,406,122,660,4,695,200,812,92,907,775,137,11,32,641,396,858,110,89,557,19,820,378,152,217,811,664,872,672,840,983,839,513,813,973,940,904,840,475,213,994,728,110,897,2,85,960,941,324,656,78,517,487,236,795,618,693,640,736,476,137,803,94,258,550,860,806,808,120,767,148,573,697,164,262,975,754,812,748,749,576,592,711,159,832,644,918,279,118,93,291,968,313,894,150,936,242,442,305,620,970,388,185,343,923,497,513,1,59,720,61,140,269,737,89,112,281,782,147,755,380,572,312,743,978,209,959,662,113,552,901,20,384,301,729,982,550,712,943,698,715,704,840,992,295,741,707,424,697,125,828,135,477,92,812,670,615,899,587,31,391,321,607,586,378,272,583,110,684,761,790,86,787,931,56,460,938,374,527,703,965,251,485,868,830,632,377,557,926,664,21,488,342,864,882,459,394,516,354,226,691,299,277,398,278,474,38,418,174,905,647,246,569,757,487,301,642,627,804,16,268,369,668,145,869,727,27,760,686,732,753,934,933,452,567,280,498,195,563,444,479,483,24,395,229,129,568,73,187,647,323,548,417,482,847,659,489,913,169,719,809,226,708,55,658,554,526,67,266,661,469,909,470,168,754,175,700,173,225,775,593,91,872,86,360,543,98,509,892,318,263,571,675,380,490,411,134,127,790,461,31,347,292,600,884,147,156,938,133,643,352,518,119,587,712,523,785,878,779,747,739,462,379,64,769,409,205,75,272,852,241,366,443,94,93,77,164,571,908,485,947,970,812,799,259,872,966,446,423,884,877,26,127,503,654,12,670,469,121,744,308,426,481,968,420,935,578,553,275,170,593,801,490,148,976,512,704,712,936,106,924,289,821,814,778,307,285,162,373,605,813,987,594,468,112,220,950,75,50,669,610,636,288,716,262,70,437,530,650,829,152,158,804,995,287,187,48,378,409,542,203,690,619,570,453,834,785,131,215,190,828,833,210,496,32,465,674,695,321,936,27,656,789,104,673,424,945,484,15,870,655,880,261,110,454,417,329,382,137,576,881,758,665,446,143,85,396,174,399,158,990,782,82,314,835,373,304,412,212,111,456,19,206,8,697,559,586,77,492,625,966,66,946,911,797,125,31,986,54,954,585,711,738,865,55,740,947,774,669,518,255,430,957,379,914,124,932,100,612,593,249,394,307,977,262,496,867,715,693,354,826,363,260,638,775,252,294,94,462,203,58,149,809,389,767,130,964,686,988,538,882,193,306,271,555,811,972,380,834,669,454,569,434,238,251,237,640,514,323,429,945,759,91,45,172,839,314,992,46,979,225,351,719,724,248,507,709,290,370,545,283,522,66,312,813,990,57,499,617,43,299,866,539,627,952,962,704,755,510,342,648,892,683,742,771,826,602,653,194,113,932,512,803,835,872,701,671,531,330,546,105,838,817,856,788,165,309,107,42,498,586,58,93,588,367,335,739,49,556,904,33,232,715,732,408,329,838,91,717,664,94,29,455,503,46,691,326,746,369,936,805,589,211,938,196,50,580,466,276,321,418,434,902,254,977,79,316,464,513,604,829,88,361,614,402,392,64,199,244,836,996,305,847,238,105,842,136,682,896,925,658,10,48,176,97,758,502,300,853,757,581,972,424,406,629,989,964,18,404,963,541,231,804,347,646,993,829,461,846,28,627,420,713,38,387,798,142,463,737,264,73,204,573,741,327,197,201,248,810,551,807,891,421,984,182,916,379,801,793,472,341,268,539,791,672,203,12,104,402,522,626,520,223,295,698,699,873,594,19,530,858,890,87,618,425,241,160,695,655,818,844,93,558,103,894,991,868,243,88,22,908,20,253,825,249,43,52,467,867,977,418,869,279,395,245,516,712,538,171,7,591,67,532,707,291,302,432,658,259,579,938,816,954,214,665,2,522,369,476,713,388,455,765,426,876,130,989,452,294,296,828,213,34,671,860,415,457,223,8,252,530,372,904,116,912,761,624,479,186,848,911,920,564,299,538,467,339,293,370,435,113,910,699,360,400,563,853,720,595,627,737,754,195,957,684,7,576,43,735,310,669,570,843,500,76,140,550,830,739,736,285,862,453,914,485,587,979,229,108,559,520,569,597,995,990,349,817,605,135,229,380,797,548,957,885,274,417,65,539,794,422,221,307,898,984,602,975,937,824,544,819,360,571,755,495,783,420,435,36,543,160,922,862,553,782,814,269,25,100,182,277,142,183,486,832,952,161,626,86,123,343,770,93,346,437,528,929,378,919,692,934,776,258,408,676,33,899,179,336,478,302,110,828,562,995,7,427,620,374,175,671,308,582,169,867,460,218,746,97,685,215,197,667,960,722,640,140,463,951,881,283,815,423,141,700,834,620,14,182,388,98,8,4,734,200,581,580,262,690,966,799,265,302,450,77,293,684,511,419,304,988,779,663,465,217,937,897,131,364,839,422,653,702,794,857,414,271,812,449,965,947,79,730,514,850,29,838,723,299,374,435,922,20,624,358,138,989,391,842,269,672,610,458,725,40,536,859,916,505,18,53,107,871,764,836,310,716,383,886,50,953,741,855,257,163,953,380,716,6,618,585,233,857,21,38,488,731,656,787,556,600,998,977,917,498,269,373,133,221,243,726,725,88,769,855,282,867,215,668,544,387,209,640,727,785,816,795,772,312,509,748,240,952,90,632,154,471,540,539,792,595,334,803,219,434,195,41,255,170,184,594,474,567,359,481,938,304,593,316,476,598,897,122,607,186,626,104,514,822,648,289,155,296,34,297,134,681,993,885,720,9,601,228,158,421,376,698,728,870,50,467,523,691,573,624,739,905,274,264,53,56,645,788,807,61,791,995,820,487,51,505,394,28,443,909,86,700,197,908,939,493,238,407,321,469,149,198,21,406,964,803,438,880,824,500,125,804,130,492,800,544,294,760,512,952,409,43,534,611,186,156,563,516,489,152,464,263,795,22,765,32,36,364,642,94,10,283,966,787,413,580,311,44,746,377,129,403,730,877,633,768,136,756,270,715,866,353,128,844,153,504,976,257,56,12,279,249,516,175,893,710,910,146,576,478,579,658,373,924,512,23,988,329,550,383,19,388,729,477,566,251,690,903,784,320,947,724,469,911,643,563,493,431,508,667,974,948,790,233,496,338,337,495,995,909,270,131,633,708,481,677,452,835,731,129,962,35,225,872,509,39,560,291,834,198,713,60,985,362,640,358,327,50,746,632,851,662,215,572,250,424,548,218,847,31,892,948,808,330,699,718,872,500,328,257,13,550,325,545,858,56,203,805,598,182,674,298,937,778,290,186,64,191,345,235,334,145,280,665,684,87,753,924,542,617,210,535,860,996,837,238,616,538,823,408,974,623,263,112,849,578,533,593,417,32,253,46,139,229,764,770,742,769,867,252,435,101,491,123,855,645,772,69,781,958,825,864,658,78,504,481,515,573,61,866,115,833,484,999,10,167,21,25,33,657,667,743,483,282,428,630,351,621,74,478,270,163,567,918,227,813,306,728,30,958,104,864,484,78,176,326,658,970,608,126,339,81,527,191,862,365,337,581,273,994,178,760,997,953,914,318,389,338,950,865,84,569,839,232,394,296,21,526,678,404,746,1000,330,59,486,718,341,274,171,989,719,935,469,956,111,465,603,263,452,168,455,180,644,724,887,110,977,75,968,328,174,418,546,311,259,211,67,408,993,474,319,692,998,958,589,175,171,434,299,48,511,70,704,554,732,419,425,807,173,415,855,514,432,726,593,429,731,405,565,345,863,733,104,811,212,904,567,754,695,315,743,77,638,73,12,564,655,702,573,597,832,342,568,574,906,371,153,894,563,452,791,764,33,199,706,439,826,352,210,583,502,886,750,714,676,822,977,945,177,95,25,501,871,253,687,311,361,760,476,962,114,612,928,206,275,751,323,465,662,472,394,672,554,804,567,661,929,628,999,458,954,186,209,589,265,151,484,338,949,279,787,643,599,739,831,975,550,328,591,700,356,289,702,143,275,549,767,39,992,174,297,382,980,154,88,593,237,895,600,836,757,636,888,844,772,341,608,181,926,910,466,457,828,149,391,819,519,659,379,263,923,708,396,558,595,780,486,696,365,74,1,898,505,97,786,827,830,461,651,970,618,13,317,952,621,824,262,885,997,241,474,587,945,138,840,390,592,427,783,224,912,191,758,220,238,243,768,622,633,485,171,483,989,346,774,900,941,568,492,702,543,185,899,338,838,294,378,617,521,782,888,64,382,43,452,155,372,76,91,596,951,586,225,964,434,368,810,351,23,237,285,520,778,118,663,577,488,526,532,517,239,442,110,301,153,522,469,61,834,453,466,219,885,129,193,145,811,800,324,59,651,909,248,563,970,184,859,198,690,928,41,933,191,181,296,430,768,2,346,74,518,380,331,496,132,159,91,23,318,335,10,952,51,547,813,435,294,703,417,50,7,678,47,931,20,733,282,382,15,98,887,564,625,656,526,457,218,848,354,661,732,424,879,696,470,805,545,677,784,482,332,253,108,66,724,289,474,404,911,55,588,574,864,144,717,153,629,166,247,116,832,698,327,808,824,942,673,169,103,729,919,387,575,771,483,753,338,686,37,486,848,277,700,237,646,377,755,381,716,495,251,593,396,379,845,647,692,390,607,584,850,780,449,575,771,986,242,618,805,883,634,221,69,701,33,24,640,52,382,244,758,60,55,615,435,210,134,586,145,680,631,564,116,440,26,451,342,304,15,2,982,47,873,310,508,653,860,75,203,44,95,650,72,130,176,587,120,180,27,656,70,511,644,73,101,928,972,58,557,196,790,804,750,444,226,477,268,967,725,896,778,628,220,86,804,300,838,907,221,380,326,540,430,459,353,24,484,255,462,226,96,590,794,817,673,97,311,635,815,704,586,642,325,166,392,414,475,79,771,286,243,970,959,565,152,597,992,544,303,283,102,477,624,453,901,552,875,26,839,739,458,554,379,214,352,773,613,94,967,11,775,373,64,309,914,808,14,654,131,374,244,293,62,143,528,784,390,929,8,405,723,146,555,845,454,400,868,998,104,811,220,345,938,741,160,325,378,727,582,336,490,621,137,388,491,253,692,915,961,316,581,986,188,944,40,460,821,31,332,590,409,303,533,465,211,347,301,422,77,748,609,424,208,657,706,683,193,919,684,674,273,672,382,39,695,521,24,335,643,711,143,281,871,685,209,152,909,118,883,371,153,487,169,637,704,800,904,231,587,16,340,202,852,110,789,5,115,689,752,218,968,57,726,324,297,210,751,319,132,904,413,824,355,317,967,350,451,404,496,429,210,611,84,720,790,453,122,952,594,809,944,167,702,524,822,82,855,776,510,163,989,202,204,444,396,817,593,114,935,737,53,590,238,381,90,603,150,926,815,712,918,328,341,334,670,196,23,892,60,797,229,826,919,976,276,596,865,188,866,293,699,678,631,671,152,606,875,263,899,473,701,573,578,851,686,318,128,609,379,653,340,91,552,320,870,428,980,164,951,616,558,844,338,270,155,931,995,719,588,249,168,251,59,65,244,142,95,199,232,854,32,521,513,529,906,352,794,273,862,111,797,620,224,969,532,12,502,247,500,87,93,655,476,371,323,666,131,983,390,544,28,715,201,643,734,553,774,302,564,19,181,36,203,426,946,260,690,242,750,639,193,972,950,684,122,441,412,929,930,892,845,115,364,683,175,301,852,39,948,169,210,276,101,172,647,779,259,165,321,387,641,345,253,238,309,576,473,858,851,988,395,498,635,612,955,790,294,316,367,640,875,953,554,478,746,574,249,30,390,470,878,408,877,663,773,729,112,441,998,210,912,292,947,577,962,139,308,693,40,775,994,657,324,349,355,23,49,826,550,642,190,548,475,255,831,542,959,15,100,269,362,369,265,981,399,819,702,714,33,207,352,261,852,258,140,689,325,646,465,461,248,961,659,361,44,797,137,192,336,645,895,264,409,403,984,232,568,108,516,166,159,180,566,425,488,347,47,204,879,777,772,351,726,455,181,833,585,674,11,535,452,408,225,634,531,983,393,98,576,713,491,760,175,237,836,366,800,284,721,705,564,779,878,303,795,149,676,118,478,256,468,969,294,377,689,79,229,236,884,363,224,938,926,724,663,259,285,767,635,101,763,8,320,930,271,274,999,523,485,509,1,996,595,842,126,923,443,856,238,54,464,28,103,412,232,129,972,418,862,516,892,3,708,161,471,115,216,875,452,280,952,883,414,517,565,574,953,220,502,969,481,107,595,596,70,503,53,325,109,49,126,927,975,194,180,784,162,527,951,628,797,830,789,500,405,787,731,36,835,178,768,786,839,898,817,308,368,614,55,239,246,930,538,120,652,729,240,284,876,885,142,182,515,899,461,522,983,158,788,988,87,32,288,11,113,640,338,271,954,659,406,724,143,886,606,239,309,26,420,877,589,332,494,229,54,768,676,287,344,85,113,597,46,168,8,706,725,694,722,864,292,107,967,372,608,766,556,401,155,653,637,378,468,277,829,219,29,500,617,353,375,834,333,478,643,716,591,164,267,581,912,899,300,349,976,666,974,42,235,409,302,798,425,159,669,934,970,771,443,742,836,859,775,650,931,487,380,966,156,387,255,512,374,336,623,719,913,118,855,975,108,464,570,416,23,995,283,84,63,438,347,321,958,363,697,546,504,816,424,299,247,825,306,819,755,609,658,224,659,983,959,427,951,565,871,449,967,674,206,949,977,581,89,556,578,341,726,83,132,961,300,727,141,195,506,55,888,73,784,284,830,875,822,120,724,553,607,467,121,324,771,375,382,168,421,669,111,379,987,485,385,264,801,304,295,276,414,466,887,194,568,749,748,242,496,969,562,53,519,320,512,528,602,309,28,856,514,880,451,417,604,201,803,9,442,212,825,741,762,469,39,495,555,660,183,287,885,268,420,180,592,273,565,266,441,472,263,573,806,987,595,175,982,990,56,290,882,481,479,531,158,413,788,972,173,888,979,148,65,478,189,840,52,831,410,98,393,794,596,609,630,693,412,67,64,650,841,315,303,302,534,804,798,929,35,225,356,91,21,113,780,210,624,176,278,434,791,621,915,776,634,79,955,172,869,656,707,411,386,264,890,17,94,49,4,796,486,822,130,896,434,586,203,549,68,176,399,830,136,429,663,925,305,440,645,304,560,949,518,743,570,121,58,934,333,74,11,383,821,161,294,956,395,312,145,777,452,671,371,403,205,22,45,341,917,769,893,910,567,362,622,343,505,755,918,545,449,456,778,391,208,199,808,579,730,709,714,898,739,922,444,708,711,871,662,936,499,940,637,620,330,575,43,687,213,745,537,868,962,293,116,107,91,111,562,958,639,936,331,938,279,225,135,700,490,671,775,166,369,791,389,185,76,364,944,978,348,53,416,557,491,646,106,970,942,994,121,697,515,955,289,143,838,502,540,314,660,183,826,360,193,975,475,553,852,629,52,638,741,810,943,637,298,811,371,548,523,176,829,207,923,973,60,797,56,38,357,13,816,556,309,128,219,588,731,654,327,995,585,117,942,647,775,274,317,142,436,514,919,844,82,336,333,877,624,825,101,921,320,166,689,175,9,27,650,102,682,643,583,148,355,342,247,667,264,975,45,812,437,896,632,324,455,715,929,397,458,426,44,626,677,242,294,596,322,360,866,370,24,280,598,616,794,404,727,700,11,68,749,943,621,547,656,985,48,291,292,60,834,906,641,977,729,326,194,344,565,899,262,453,345,198,871,733,639,414,768,109,368,167,935,991,608,838,880,18,800,209,687,610,746,617,71,339,94,974,51,134,271,57,222,936,1000,270,657,494,984,914,302,475,438,33,103,681,855,4,443,605,609,170,467,672,594,70,413,985,611,76,333,348,246,125,990,19,693,129,373,912,715,307,243,67,850,261,54,673,391,92,63,334,196,484,68,376,771,723,40,11,738,566,633,383,503,152,909,785,186,244,455,540,660,944,412,116,615,335,321,686,666,717,326,629,358,413,294,970,369,248,291,477,263,256,132,852,537,86,157,496,532,905,242,406,166,80,134,487,240,635,860,456,389,53,31,127,590,978,741,553,417,996,702,881,200,639,145,359,664,535,942,483,482,333,737,583,788,474,350,988,457,974,309,922,856,39,877,232,437,710,7,475,40,329,868,492,184,840,161,89,552,687,808,120,911,187,674,779,943,641,858,510,764,252,593,502,851,397,790,356,344,684,332,723,440,202,937,559,989,592,799,391,847,656,652,578,481,919,756,889,339,836,697,353,162,390,395,930,422,999,98,938,237,298,522,494,389,334,801,436,616,1,136,235,556,857,735,642,708,752,575,622,933,372,258,188,940,960,263,584,20,266,142,132,13,726,855,703,644,504,305,547,694,189,742,897,61,428,759,566,827,216,692,359,161,251,885,661,315,1000,617,329,245,171,233,393,119,205,528,731,798,257,943,916,410,238,932,144,776,778,394,706,300,137,507,609,530,899,906,752,621,654,400,997,303,235,311,549,501,278,232,363,977,868,435,475,178,268,314,605,146,925,440,755,265,490,382,197,985,3,969,513,617,171,286,465,191,240,982,56,99,694,815,974,503,660,948,103,773,635,732,67,236,162,194,701,385,431,954,895,230,590,17,940,951,853,74,872,212,38,277,896,174,371,95,657,876,115,864,317,844,112,76,194,431,638,570,967,8,753,103,970,811,680,32,197,908,698,71,579,229,153,26,104,701,931,974,3,863,266,690,230,683,554,331,988,173,710,284,149,365,67,613,946,957,264,533,211,522,868,989,660,83,973,13,474,384,362,426,452,156,303,784,119,262,40,27,544,890,774,465,273,932,165,336,519,582,445,205,965,943,97,144,93,608,609,496,961,520,54,56,21,322,422,640,813,621,294,790,480,535,733,640,413,817,882,710,697,466,824,490,590,855,60,338,205,965,992,646,465,80,305,23,117,290,500,595,518,826,873,858,762,218,444,93,972,603,747,177,481,641,448,838,760,185,350,875,653,352,70,718,507,360,463,842,372,332,422,799,256,891,503,403,363,35,197,313,661,342,378,275,61,808,424,943,7,903,456,729,276,583,506,708,915,272,550,589,188,43,805,622,36,791,67,904,308,515,178,113,568,812,889,679,772,656,572,374,833,707,639,172,496,635,538,341,133,544,522,198,518,631,297,641,588,604,366,816,342,162,956,559,895,219,7,337,727,920,453,24,665,443,605,890,289,383,387,352,915,220,799,805,391,942,558,347,608,86,871,447,785,887,903,898,429,743,912,227,940,395,419,499,185,247,681,943,986,105,862,487,221,653,970,478,752,801,338,38,118,510,526,837,420,843,388,156,274,704,997,954,368,938,533,795,219,495,708,64,680,731,225,986,378,414,274,268,92,223,839,107,50,603,728,674,72,115,186,157,610,310,961,590,440,71,564,586,421,592,275,11,912,765,613,23,874,695,925,515,70,164,518,363,287,204,54,606,679,661,722,62,545,830,331,573,304,736,769,118,369,436,77,828,552,845,512,359,650,270,9,234,645,574,761,43,997,484,945,235,350,854,434,750,426,439,942,37,326,609,654,735,952,875,818,802,662,743,942,724,798,760,259,679,655,489,835,157,317,715,151,574,370,867,510,811,121,973,284,132,940,68,728,70,714,886,853,524,30,682,933,267,979,859,903,98,142,870,914,842,388,611,941,995,732,143,460,160,430,441,906,545,657,412,713,768,806,432,683,845,661,136,169,831,177,568,839,684,115,543,640,761,423,47,885,993,701,573,815,697,536,216,329,405,1000,299,808,896,840,904,383,445,866,346,946,538,990,852,909,634,401,45,385,616,548,438,611,568,512,31,888,444,424,381,153,495,451,403,545,156,770,994,814,103,657,26,411,362,667,241,110,34,207,895,434,787,697,686,682,530,20,343,503,795,820,18,941,828,917,263,147,626,632,83,289,889,913,148,517,866,461,102,473,257,28,636,670,85,60,706,536,947,174,113,524,853,641,373,798,294,581,638,654,968,371,668,471,662,596,374,522,252,959,262,641,486,801,43,103,884,652,824,587,221,162,443,980,933,617,450,564,668,917,241,193,615,457,158,263,482,885,723,988,192,744,131,578,722,691,709,316,47,232,670,412,600,875,537,366,157,760,231,973,102,38,550,895,456,778,184,1,802,627,370,985,789,515,545,453,139,796,544,511,170,296,154,534,867,836,187,173,246,586,856,838,351,613,202,494,374,505,607,343,292,6,319,724,119,767,717,630,813,278,12,669,761,87,415,825,442,394,41,730,24,615,102,156,630,721,973,510,552,210,684,540,531,190,403,917,224,737,427,777,494,191,885,51,916,385,170,341,308,693,270,715,430,357,346,972,361,177,977,53,585,982,803,611,444,409,250,740,267,3,493,543,462,257,849,242,132,855,993,903,560,420,870,112,860,586,303,454,246,475,996,77,340,491,281,353,542,512,827,399,187,459,350,364,685,847,484,492,660,230,418,704,421,165,217,62,123,174,65,896,612,159,522,824,78,605,832,969,679,525,935,431,486,983,506,458,402,779,320,303,571,518,885,95,677,470,126,761,86,905,189,173,680,89,645,533,214,157,619,35,794,184,913,772,753,696,887,321,719,622,638,750,918,607,792,868,941,265,856,758,380,839,323,509,922,98,821,219,288,134,934,848,218,511,615,447,897,376,111,375,873,778,285,735,771,105,287,77,993,185,892,757,601,840,545,490,70,388,440,108,826,101,206,210,164,386,3,925,85,778,684,573,857,205,208,822,406,242,992,611,346,706,404,686,634,61,83,460,323,958,362,74,394,819,814,357,642,516,461,828,433,679,985,736,13,845,696,2,131,953,973,494,858,689,924,419,65,470,549,115,693,246,591,592,305,964,726,338,887,681,502,168,806,733,889,904,781,466,704,805,637,354,659,327,119,640,574,422,748,328,612,824,525,195,614,549,32,17,324,147,842,877,486,718,158,440,734,266,969,214,484,118,811,108,932,717,563,670,84,48,386,531,60,738,100,638,790,327,644,990,653,736,481,406,187,986,177,326,66,690,379,242,837,760,365,330,161,831,543,209,149,828,217,957,428,495,492,628,529,381,208,76,857,167,567,533,183,938,422,249,79,323,348,296,215,656,871,340,795,49,454,540,714,590,135,467,275,321,883,630,942,492,272,967,523,59,255,51,676,248,829,901,578,527,425,851,467,65,469,918,577,600,909,928,782,346,37,101,684,54,842,50,573,57,984,956,340,285,756,670,284,308,759,906,443,705,668,516,738,878,662,115,511,313,701,826,441,49,442,880,39,145,732,699,108,838,47,62,981,407,282,783,299,865,775,965,790,286,693,860,43,868,582,550,345,426,371,744,776,387,700,112,952,499,79,413,796,191,204,875,558,911,593,987,846,811,527,543,7,512,874,146,646,324,220,777,397,185,934,326,542,618,553,485,905,812,794,828,901,635,674,550,887,342,848,178,869,800,229,973,213,35,82,580,115,258,313,581,6,759,42,256,818,672,346,203,503,360,857,900,275,43,956,843,902,388,765,53,170,112,941,408,523,757,242,629,785,29,670,784,638,807,248,486,870,127,661,421,541,546,677,889,491,222,806,477,935,137,961,412,320,834,788,574,817,711,619,746,662,550,694,762,107,928,65,345,45,887,223,758,480,936,612,366,394,33,53,774,210,202,839,710,200,815,195,942,243,522,777,24,806,944,110,190,943,514,178,418,125,152,670,166,145,733,894,305,250,949,544,845,442,621,264,705,587,539,50,46,18,543,188,406,88,576,122,456,141,803,965,71,703,423,888,492,205,286,433,135,629,237,698,995,500,226,362,397,957,323,467,702,469,177,81,473,939,683,949,1,42,432,709,274,476,228,344,863,775,233,997,520,326,741,88,400,522,70,706,534,763,703,525,659,342,304,475,269,979,810,845,253,99,673,786,904,343,113,356,616,351,66,549,544,717,770,234,668,347,38,907,467,231,448,780,662,894,748,357,380,524,833,32,994,323,813,453,68,107,993,449,695,839,387,872,393,960,308,60,376,165,643,30,947,279,278,338,582,140,33,962,926,609,694,174,217,654,323,677,801,730,819,308,791,236,660,958,976,527,132,274,780,580,521,664,188,837,33,627,910,469,197,768,290,898,941,576,503,300,486,390,554,662,347,728,455,88,457,589,305,16,544,562,296,762,915,124,983,257,900,266,261,127,367,981,497,286,885,405,693,692,667,828,893,765,851,430,267,309,668,615,833,952,161,726,332,824,861,905,783,207,822,62,809,81,444,129,784,365,545,350,665,992,650,985,232,742,413,268,303,431,283,918,28,108,962,932,808,678,515,702,553,868,421,425,393,131,950,497,448,146,202,423,690,32,3,417,622,311,87,923,532,468,184,380,156,667,64,641,204,587,607,381,349,259,277,818,724,217,1,729,791,889,480,339,136,775,68,384,665,684,235,523,683,470,309,55,128,952,281,224,675,243,483,464,117,941,569,412,722,844,271,543,987,99,469,386,475,538,971,700,92,958,784,432,385,917,589,958,643,747,931,698,935,692,532,579,446,93,938,829,887,510,268,388,677,50,298,431,581,434,781,617,879,16,372,875,20,885,381,62,872,29,822,819,281,394,535,756,629,821,22,27,618,365,929,796,188,870,333,392,128,170,727,36,970,259,642,327,231,167,498,263,380,209,724,480,911,534,214,47,551,190,278,652,194,763,69,6,346,672,245,440,502,884,142,584,969,624,861,303,355,73,664,578,232,264,795,872,678,259,145,546,251,302,791,718,902,20,644,589,671,541,207,263,552,402,327,883,741,374,345,375,855,611,633,448,407,389,404,110,939,256,521,485,508,605,761,37,500,384,275,101,712,654,759,683,422,615,587,475,155,844,887,843,381,174,729,522,646,550,732,527,57,890,394,598,388,132,916,585,625,455,780,820,331,850,313,284,839,665,219,668,152,679,261,457,315,136,4,382,895,740,121,899,389,517,307,490,70,469,188,205,72,212,701,916,810,689,508,625,15,192,610,937,482,915,653,749,47,954,758,833,767,384,593,918,110,259,788,943,532,730,514,618,140,308,377,908,14,342,773,562,830,980,409,529,520,381,275,464,535,581,250,534,727,723,165,882,985,945,211,787,623,898,547,907,592,889,321,506,785,208,594,433,371,441,577,179,163,185,131,293,16,949,184,448,101,84,725,561,479,565,82,631,431,662,669,724,931,713,727,663,371,681,752,842,105,787,218,510,602,774,527,386,259,513,280,749,467,999,508,688,570,377,575,634,236,874,228,945,219,546,401,112,935,153,341,872,694,375,942,687,306,495,209,928,27,553,581,271,725,838,543,326,42,530,849,557,589,523,330,686,588,610,913,355,199,961,823,503,679,786,221,696,806,71,302,880,36,122,369,109,882,761,329,590,675,254,379,661,423,275,82,318,255,905,811,471,18,980,912,457,715,399,355,40,842,419,586,32,344,146,85,104,949,486,280,966,851,633,117,648,302,762,957,35,832,293,481,776,944,680,86,514,73,881,61,691,63,39,201,43,899,516,4,131,21,986,792,696,234,998,721,547,687,928,279,439,797,844,805,95,798,752,364,677,300,467,120,808,249,452,168,332,621,767,276,566,854,920,127,756,886,301,228,170,936,50,773,490,918,12,133,117,419,580,641,515,980,596,872,706,484,272,721,877,377,847,534,734,975,138,651,739,769,624,159,895,920,667,144,610,745,765,341,116,234,731,615,67,486,33,369,774,846,226,837,677,619,889,822,978,121,324,671,184,851,827,855,73,487,848,697,948,191,177,298,954,840,928,225,652,760,883,629,161,576,924,646,557,945,502,756,951,754,829,974,241,501,771,676,681,729,579,904,749,548,261,143,869,989,190,470,393,170,570,344,766,958,69,683,529,802,49,328,306,237,592,526,669,435,584,992,497,341,29,851,549,436,77,270,507,185,113,141,718,913,276,40,168,502,127,326,809,805,753,81,471,136,545,412,548,9,568,810,319,212,18,627,573,648,830,777,426,353,76,715,264,398,478,659,543,173,25,442,783,934,88,798,261,556,731,74,210,304,371,768,921,53,275,183,540,849,625,233,200,95,267,583,562,814,256,92,437,340,286,492,693,48,655,588,513,218,56,78,55,194,984,253,120,284,860,938,691,547,951,937,982,207,627,330,630,965,940,244,465,398,96,99,129,995,293,41,158,423,614,429,467,695,294,539,503,830,609,836,197,837,962,126,664,561,74,410,22,481,69,661,279,666,33,876,639,154,579,934,855,497,733,362,31,555,621,905,122,428,567,811,302,825,290,763,690,854,454,50,643,735,112,884,966,960,170,546,388,824,357,669,494,220,977,253,406,809,82,506,352,22,843,689,404,77,339,600,75,774,680,723,282,479,558,255,738,975,25,317,70,853,248,226,906,189,815,23,751,764,272,38,153,377,562,332,451,127,881,468,679,527,169,552,836,847,137,806,702,580,45,358,359,525,519,840,745,61,102,725,156,804,217,6,614,587,256,791,361,869,393,496,296,744,221,66,67,624,631,125,348,64,717,760,844,656,303,31,995,742,79,489,484,517,656,701,715,348,81,999,611,457,38,853,550,362,962,927,769,879,854,76,110,467,900,947,194,602,646,785,58,309,996,15,276,687,872,344,820,132,201,777,231,904,608,260,290,874,605,89,557,568,524,520,43,311,34,46,397,436,259,787,626,128,285,297,438,394,984,763,270,678,912,464,178,887,569,2,355,576,766,988,321,616,269,144,521,205,533,924,714,873,894,772,553,980,640,185,156,326,187,827,891,448,688,153,821,641,181,479,620,250,729,12,815,912,291,445,520,820,665,865,786,642,143,149,419,133,878,167,753,715,676,929,860,546,229,437,173,450,201,798,930,661,207,304,265,438,561,203,122,124,867,16,679,970,346,300,633,783,485,429,806,106,747,673,894,372,388,238,259,267,966,231,18,837,356,155,397,379,695,1,823,236,980,522,774,49,954,634,295,48,435,613,279,645,711,866,580,148,257,402,558,270,691,86,932,191,521,253,325,916,154,550,178,998,423,818,133,774,739,27,809,316,706,214,995,646,971,38,956,75,612,770,888,183,258,319,70,834,618,699,376,347,524,53,404,565,52,946,419,890,954,51,450,306,921,32,161,33,855,234,569,707,288,401,802,429,500,509,920,354,506,431,335,494,244,880,48,5,326,209,498,635,534,470,462,886,837,622,483,350,115,135,838,502,492,890,491,228,340,492,30,641,892,903,723,77,297,876,119,828,292,933,811,662,846,718,895,136,313,35,902,947,909,698,271,379,80,357,776,134,694,560,756,157,551,594,342,222,295,460,957,274,716,319,382,416,914,868,870,781,748,615,821,956,678,242,812,376,23,97,455,642,851,439,965,593,687,620,194,324,796,600,959,150,841,257,270,999,727,388,24,761,67,94,818,629,283,128,951,4,650,565,400,514,351,620,562,180,594,535,960,468,720,877,268,587,547,92,895,254,31,845,856,472,134,699,148,948,869,723,828,7,826,734,693,406,167,866,324,714,272,399,281,384,889,433,984,643,35,421,197,953,188,525,822,119,320,978,13,575,3,864,255,537,824,67,306,361,485,770,764,825,691,507,639,761,820,894,839,854,806,501,840,644,164,784,248,758,947,112,370,742,638,97,609,580,708,27,79,871,260,171,209,409,215,438,719,97,163,900,786,103,227,107,644,373,821,697,150,308,589,455,702,556,693,793,422,898,167,849,27,22,651,68,169,627,134,606,54,1000,423,623,726,3,502,847,317,5,762,537,717,808,61,767,380,424,415,528,508,974,62,331,348,973,388,564,870,549,412,969,904,433,377,161,1,524,841,999,168,893,591,217,696,23,594,914,504,24,912,487,845,772,207,837,962,617,376,653,574,139,662,441,637,366,787,766,127,505,778,461,118,685,196,133,726,968,365,252,372,153,330,187,547,617,750,701,751,851,803,297,801,441,329,748,526,266,870,114,532,517,671,13,976,642,472,137,67,729,824,336,387,1,605,680,902,78,233,520,661,439,300,718,949,259,775,66,437,765,838,192,835,966,335,82,144,769,716,355,941,348,699,353,490,732,63,508,304,359,749,264,714,411,919,52,871,482,199,476,331,603,165,609,594,638,847,362,960,765,998,203,479,638,845,302,878,625,38,378,176,326,27,171,334,207,406,552,899,614,924,836,192,396,299,469,618,833,403,322,724,854,419,204,551,347,707,750,497,838,981,678,256,112,346,253,902,388,351,695,349,258,336,574,912,432,738,956,813,486,627,163,654,387,308,104,951,876,790,311,500,165,910,185,149,356,292,402,582,706,220,140,449,118,794,252,222,324,193,816,540,559,468,784,495,325,459,540,504,338,861,803,996,334,836,617,899,765,454,850,654,425,243,7,910,781,186,657,194,49,569,352,750,700,853,384,413,286,548,151,866,326,955,886,57,15,639,327,298,138,818,371,311,868,802,846,482,216,231,966,582,378,979,75,85,833,609,645,345,926,41,927,440,406,650,160,206,444,503,633,102,507,930,115,112,340,558,254,245,871,907,16,435,517,135,643,307,179,778,488,819,193,764,875,339,696,767,740,187,300,692,238,785,832,863,634,101,399,584,854,373,351,21,393,74,560,354,622,541,549,855,235,376,89,754,611,738,218,686,79,658,967,396,665,124,67,26,519,977,807,865,706,575,538,184,186,621,9,882,646,884,127,198,436,214,76,757,502,234,400,860,930,688,710,862,407,459,917,618,411,598,701,205,577,800,970,830,624,554,460,151,671,948,209,365,741,485,526,495,109,909,809,244,829,173,226,482,26,277,13,612,664,238,471,679,83,29,339,63,186,281,632,160,877,117,781,637,644,176,594,914,8,757,253,384,151,306,327,12,214,272,962,305,401,41,891,53,275,847,652,189,443,40,555,645,604,200,268,919,57,540,546,750,47,254,857,782,694,487,726,332,692,260,115,407,413,549,793,303,898,16,469,918,361,257,605,280,374,670,878,696,406,856,893,837,817,744,768,235,748,913,377,787,882,937,133,417,485,789,85,910,749,861,265,76,549,92,612,208,569,27,631,736,34,854,885,157,172,888,762,320,57,627,2,344,18,380,883,223,378,215,936,813,281,169,384,150,236,630,507,160,601,20,33,239,995,735,35,393,439,121,275,534,168,533,590,112,221,177,826,222,640,348,592,774,49,886,386,185,675,174,761,270,662,341,524,452,122,733,707,752,141,512,438,898,824,547,470,976,567,666,132,744,356,966,641,918,289,446,390,710,6,734,351,473,534,155,73,718,432,935,135,614,123,332,517,217,645,258,68,475,576,491,29,448,480,930,746,16,699,310,547,209,826,371,597,880,974,838,757,114,720,819,729,465,440,117,562,421,971,253,201,727,346,410,855,989,82,541,817,252,949,167,28,663,719,987,400,553,848,224,42,10,910,39,407,847,740,842,447,744,528,133,890,372,888,5,875,244,942,801,580,961,520,581,309,674,383,831,26,427,696,780,504,888,542,226,587,122,396,366,123,304,72,775,144,359,573,578,745,606,837,302,553,802,965,856,371,829,565,140,307,970,63,524,193,176,646,525,288,224,234,863,850,969,294,714,610,706,221,1,987,689,442,135,919,911,452,403,614,164,322,825,101,376,743,824,896,901,174,993,506,584,272,814,574,415,715,471,30,233,771,138,644,160,605,952,195,948,13,899,761,269,74,963,120,433,929,438,784,449,977,601,988,89,121,383,529,370,338,531,949,802,378,39,819,912,101,729,646,260,118,654,832,740,739,829,279,91,800,95,177,81,59,475,191,120,494,680,412,218,804,341,336,283,600,919,713,570,488,342,843,997,65,694,852,697,741,952,752,34,617,681,351,731,97,343,384,900,328,425,18,635,233,369,892,771,765,509,253,398,845,510,184,504,851,150,297,679,473,229,490,502,813,628,653,330,179,318,791,565,588,247,746,909,883,690,770,44,233,576,261,34,930,449,825,487,602,775,529,644,379,847,708,824,170,549,380,304,369,309,374,740,300,635,647,357,430,238,417,327,282,172,636,794,469,515,153,119,719,426,908,316,69,873,212,713,942,561,622,100,625,978,516,938,968,451,769,356,495,532,397,875,349,477,19,454,948,671,255,861,854,596,5,108,540,143,484,75,653,168,755,468,197,191,459,535,51,454,496,548,922,7,910,208,840,587,550,665,976,723,244,435,880,805,172,72,240,501,643,25,462,782,267,34,330,30,40,740,426,733,728,227,355,982,742,887,53,712,396,499,242,422,528,689,682,825,676,74,298,489,405,836,919,237,856,212,592,950,301,384,794,766,972,388,998,679,169,855,526,223,827,981,173,711,406,116,714,295,582,862,83,783,428,19,1,143,615,177,807,106,80,503,886,694,372,841]", 155931, 324},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string numsStr, int x, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.MinOperations(nums, x);

            Assert.That(expected == res);
        }
    }
}