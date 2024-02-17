using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindSubstringWithGivenHashValue
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"leetcode", 7, 20, 2, 0, "ee"},
            new object[] {"fbxzaad", 31, 100, 3, 32, "fbx"},
            new object[] {"xxterzixjqrghqyeketqeynekvqhc",15,94,4,16,"nekv"},
            new object[] {"xmmhdakfursinye",96,45,15,21,"xmmhdakfursinye"},
            new object[] {"puomfovzgiymqhxprfxqjzjzzzlggsrpgbrwrwlslbdpjzudtczaovcytefpqmkesqwgxluxog",13,8,69,7,"fovzgiymqhxprfxqjzjzzzlggsrpgbrwrwlslbdpjzudtczaovcytefpqmkesqwgxluxo"},
            new object[] {"abc",7,10,1,3,"c"},
            new object[] {"ecrelrwbqglxtqpjbpxhbxeqricfsxsjpaywetepeumxzhumbpgbyxpssxybdwwshdmtqexfebvsedchhnxxiwubwoebdbdvrbtlfqrfnfyevcoqhnnufpvrqsxiasogtuyykthuiigivdsxxnpbvishowiouqnnkwrmabhnjsxruegcsoeatcuiotzoxydqqnjanifexrnoydamsbrawlpdwquqgahdoigrglycsfkcxolspzbimfzungomtaozgqwjzlrqvruilzaqwnshxohujfvihsmitsslaxuvaqynrljxaytxuvgwpxnweadmurplurenhjatftidjylmskexfpmburgpcjxtqgnivfdkehvgdgoaufhhxgozpboxkooibcphuoymfgrnuzaicofrramghzwuqvarjhalizolbborchhqebhcvtgrxkvwokrksaochtrihkoedkklihdaxkqnhshrsipificqvaesrobrmlqicmouvxmasttxcdtlpkunyebtfxdpcetgznsyqjxrodhvbqxktrvwedbdppaxdfvxwvcilcbhgfywwnimcopukgolbuxawaflchrpeiquxdwfwulpcfoudswhnkbksbipymjjtplgobqseqjbigtvbdyazdvbrurhgssxouuassnxgeslhwgxxpojgqiietulsstiafxzkirqmshiganstskjdejqikxhcmhftaiacoylkoxjzzbvrbtzrdoddsyaajswiszgwsjpxtwvdbwhgicljjygtdnemjuwyirmpolypngjvbkyskavsojsebklsslybucasuqtwabiecioueveyfdwqkplrlmkxragmfavbhllecmtvflrkkbgbgwrahdupoypfnbtiiwfkygymjtrdkvqipmlfsdemqzhgccyjvqxdefpzawznkyemlwmpykgkolewcvsdnrabeesamqjdolkanqcdjdkawrvfczvwxgjphkohffwybsfngkbvqnahsxjuicczkjhrwxuxzgcozmqyvauvocmrgszhgvzydmmdmedkmjlgynvzzmnpezgytjxmmorbcxxodlrryqwhavfnfywjxpuaaconecurtmsxdpoacbsmdiyzbhgsuxlhslezhuhtopdxsqbymxuzmczpznkkjwfelvsyrejzpdpxfkwfpgvfavzjqxcbmxkojlvoeowbdruxobttiycfdlwauiknaoovxnvafqxnnssftggxdzvefxuzekhtcfyrqsjnwqehrwcizfegrnlkpwygqcaygxaoaattbsypmoecjjwbepznnainownzpkbfgrziyxsxpcsgrdtrjbpacphaavjaycedsyypnwqujfmzwxvvwpwkrhpbgmreiufayyhxbrllhwprwexxpmrwennoyrmxopkucosoabrlgwjxappyxcbfelskzqnadcvqtdspycuneburyfbqgdtomuehzbifjvdrzzcorjylfjqoqahrhemsidaupheikpdrtuedauiwrthbqlwjdhywkcqliozfoseoepemcqzfqabmiothozpahkyykxezolsrbuhqjkyixodyzsjucwnoozarcahakjeltkbudvefpuzktwzrdzosfvelcjjihxvvjiqfdwqutbkhoxgpbqlmtsnyfnplwobjejwugcgpwdkdgncpepyszatzlyuhfaqpbtvqlltuzdehxdhnisprnmzluynffczzncielxpsqoxopzjlggzqnzxreqqtekzbixifulwleatqoxnqtaxqfkztizicbocyvuyngnemkkpunclchzvumyrodhnkkxahlsncejydyzzyibxjmposqthxqzwkajzmbnfzdmijuncqdemurfsxavxwotwnalgslhoetohtyyvjdqhvgcoqvpkrnsuveupwgkhpbfucklkhohsrzpqjneeepikhglgjckfpxxdikpljmjnufghffrxbhlhjvvktoemgjtbtcsmgvlwnoepfiogudqqkkisfdlhkwonhcfpynezjevcnvpcbzuqgjbahfeledtqtuhaoxafiqhfmvdpmkrvmgcfpuoceytpkhbwjwefmcglqfadprmmxtrmaotgbsaduriucjcylqarafcahylojamjfnvoopvcyzvyypoqvxjjnteadtwqjnvzjbngurufeulfybrlbajnfvsfdskbylnkalkhezqcpibxqhesjfwqewrwkgzziqecziqiepyspiofrzwejwwtjituxjynaincpnamygrrexstsfvgjcyzdenqpqsspdtzvqxjlfclrpukswoiymnovkmgucmbktjkdfkilqvvebfzdfonebbvqognsjihcdooavsaizzuobudtdamgxxvxfwkjdarnldzraxlsjyjqjqwmkzzznnhjejppkavfnljyvazektyhxgseemjmbqxnsspjlwpynivdkkqlxgfshcdwqzihxyhhzwuppzmlfiruvjxlcygunrcmwouyfmrrfbqhiurllikgnwhhmrvdjbqbsrdukheflleshlbwrurwjnhlmmjklihegsrvzetotgwpzoshjehbgmsnozpbmkqiagmqvsavkvdjytbrbjrylseucmttyjvjoezlvmkhqxvxlbpbaurlbqdrjunitrszvsdhypxnvesojpaxnvbwsvzwnovphutxqmybestgiskufjqweylcsdrdpywojkhfmjkzuhyhuteyisbzibiaeaatuuvnsibltcfkkhxcdxfqbqkmjstuahpzilskxsyfypvxmwpuusikokvftiombiodmndxncpzemkstsipybxprvovkbovaxiirklwibroyyyscqiecmhogolnjdhjkbgmwudjaljxzffmdmpcytjtbtylfgtgocfvdgncxafcqltchrqjqvzywbdaehhwesniygcikrvcszpoaamnsiinajuhcyzopmjqrmncisevxmoysqvsmohevaigrbiikosjrbnebbooqognxptcuhigkzsgwnxqeexmcnetwwamqiedekgurufpvgvwyhrizlkdyowspxniqnbmdpuavqerhkqauuiclvegutgwibmodqhmoaqrcxlngmmbpxybditgbnmufpagjvwwvaftqhlkdqerlvsiomyplscuakznarzutmtzkqvnvbgmieajnmbntmlbvesvtdjeqzxjqpbowfxgdtvduyifijxigmwasfcslnaaxmgauczdjyhbyaiyspqoepjlnoighejmdkxjxigzzzsysrmazdrjfktnxaoeanxovtgwwtijissubhpxjiyifgtkldlhmglmjkjkdicvsbmzcfvesuvmqbqawjewjzhgpgpbxndqtlmgwomitylbmwkgwndyzgpvdwctygdfdhkxksfawxcnfbudukukzkaqelpqysuuyznuhaajcuszmthgspyevaxtazksqjqgpzffvzrlrijrpsmgxcnjrglwwzrujcsgtlmiokejibgpwygziosenyspuhkgfuimvowdgppkgotjbpdmhufigghvigwqakgmxktatkuuobiousyrzyhsqzjfengapvzxxwvxfqfdefguuoxlwawturndwckotmmuufjmcuzmdxiizkihgpjrfuuymrghfywxoqdthxpxugcglyyjdktsfmyzphfpyezolltekqkaobeelktabhapubulusioygrjiekppbontpipzutiqquqlstdrnnkoxlzozboqfuzbwgiaxsifkmonjteflrdpcdfembahcvardqcksxjsnbwlbqruejtlzlmlwhsucexorqduqjaneowmlharbrepezhebwdybkfsupuycaxoxbpthawynjiohxoxunfpfvusinajwvijlyjefhhggohffjyympmjtgywrdsnjbeuupeyuyhxmyugfyebbpgmnmrbddfdedlqtpdezcmnvfbyqiyvdqqcnihzpvleppjatrsynxmosmothitduzxcasgimrbaqhbszgmumktncyagocnuaoxhhhomyolotdfhgawahffzpogkgvthkosutrnblwgrrwkxkueogilcremwqklhsjuvawpjnnvrqdvjahibedwjlhrjdvjfxnntqjoxnozqnobmdoiktjohzbwiwibnzifiommlkqzayvhxdmyvjzqjmihegvdzdhzaemyfplbdnbzbbzdigbxhtqmgounykmidfalxrjsbyxtoyairigjctvsyuaoktyksklcakgisvgowmyktmovwxqgiwynqvjvrjqcdhqqnveeumjgqhoxwptfxcwnedpdhgpqxbrgxgiqiwinxvgrabqtrskzzftvqasojfvjmaipjvtklflpxiiqtrgaawemghqmnyzkigsyfyvomdzjnnfzcxxpfxefvkfajpbwszdgracntxacqxclbwgixkrieluqjkvkeocrilxrlnaqttipfmeoraujipapewufbarklsskgqhtkjphwnjrkdjssqscxdowrpmezzgmqwqdfgknvxizkvpydsypyqbqnztviizvrdvifdgwofcwxrmlsevznimbfeeeykxhthitvnxrtkahhunmeradovlvparilsscglzkypvmlsrelrbyzfogkmzoshnxqqgnypydjntfkwqqhuevmbizmexpxokcwwvsknqfrcysqnjdxctfijjlxmrhddxaqpqviuzvrwihafginxedpuqwrfowrkxbbfwqhwnnaoudpzffyartfbtyldeakldgleqraxwcssaloomhnbaflklcdyeuwudwocxazulterpjeeysmyfhioylcfrdrowgevjelscyiyxlslpxabltkpvodjkpxgtsxdzjkquvrgruysbqjjkleaaeksiagsfppdfgunwtkglmqmqmcmdoviogwcjwfknritnoigfmvhuclgxusxzsxsglfbyczziywjjupgtqnyrljqlacugxmmjmqhsiodzxsrjbexhdopwghmjdrcdntjgzrxpghkernwngicixfxcgjczeuzxzdjfbwktzjjwamcikveqmfzsnyycgjrjgulxdkoifatvjvkyujbaksqkohrknywzejnrzpyxsmruocwtqdwttuxunoychmfwursoezkqivmplizkzrnidosimlyqaxttgqmcmcgmccqfwgutdwvwhhzcmxbxjmqnmorcgsizrptkcicijxztwxnzjhemqpxyhqjylsuuczsguknvoxrpqmaoithrqocpxyslvmcmhvpgvhfqpmylliwrwiqezypcgickhkvhmikgaydruvbeolshbbgneshjjxnrfhjoranhgnzcdlgyqytlqokyvzvkzvizzupbqdhochhquomgxivtditqrzwhlcwwfsxokwtlnwwaitbshblsucvusihfewrxfdcxsrjawyelrtlbfuztjmgsulamubjzjkcctdcpftxbztwcdnxwooizqlnkcggvqhfhqslrbgtjmpvpmaaerjejfcjbtwjcsfznstbbeccmnzckhikfpegqxmifatlamqscbtapvnxgjklaabllfdegbscponegmdjrwefvdunolkyltmukdpyfeutkcnkjpohzneottwnyhqdbzsrbgsgloulmknpclrgkdfaiapopctgesnwbxjyyajkyhbbtzlfejijbgdkkzipemhaifibtmnkimjjjqbrrbwhcnhvtpmmiazzykseknyzbrfdliftpslcrulvoaqwhbdhekvawmajgqoqljvdgbzrifjcjdiaprhwyjabbprbudxkvqumdtubrjbskgfrifjkpuyeghoiifxjgcyvlvjlmeblwnarfyyoscqydymbbuwaecccoxjhsmescwgkwhbmqkvdmssqdfvoemmjrmfjeyblqkbknpqmgrbeyruegknnjyxhdllbfbjxrkthyjnwwwzblftunowfxqkxoghtsequcoyhqraxkqfcyehxcfbcgmnsxxkcbeeikewlxytkoztlvvqiirbabejiyatxonycfwzglgddvnlohyuuiegymrnvrkbgkkdkonhceneldylgsrajozvdzvxfxynoycjkquybysqwamnqghkitnzrzqkodohuaojsskdqjdiqxntdldpapwpscovavzhhawubknnegxifqmkbxfwsefnxwhbekvthucuhgeuscysriexpllwefyagalcdjcznuijrftmdjvhfmlakhgaglawdgqeqaaxmrjvmbvsyyvanuklpdkfohxiqborbexwbghxjcykbncnlgvwbyxvqbvnozoavxtvtbygpumfdelxogjaaawzpuwvkxahilrfzsqbekzrpdvrtavmjyeitcwzeiefiqdlcoodswastrkoduamudtuiyfmbhiulgjnlejzhmhfchdpuxpikkcxcyxmlluikazjivvhrpluhgmyvftwazdgyiymqefjnnpjlokhawllpzntpvmwnloclyujjkwfzzpheuynqqasjhnjwczcalatynetgmbphmzrelyhhqgbrxnyudofveydcmwewafphahgrykrzgylwerykngfghnsfvduvvzulfbylehnlrsfogtoirdxpfnfkppkkshqybstozfsbhweqsalzatfhqhvpqwwimxknuyylrnjfvbiyhcyhuhjowpyrvldmxctagjjxcrqytmqfwdzdyrupadpbsojgnucofshvavbswoaknkyldxnpzcexdwctmgfzwjnjdatirfvcdnivdklpugmfrefbstjefobgxpygglttwdyaggtjqnnqclovgcotyxcocojqqjnkiqrrnrqcqzyjokwcowckjgnnmdopdmrurokrjdlonqkdkbiehowaityujkeznkhlotpvxiukozvyojutpmhixstknxyzsdnhczvhymfrwmaezdolknwartsselqymptqbpdirihmouqbdzzthitesdgxbgsytdeyhxfzixowxquclcgsohfyiravaizgqqgadekyrjooljymxbhduznqqamdvnyffdyryaaotnxabxmpbcylzyhbnrnlazuctvoemwuxfzbxscyvzcvlprpuoubzgirvswdjfbaivbprbzdabtharpagqdzxfpqjwhoeyvzuzvugrxexaxffwefixltlzvuiqtyktxcmfoypqrgnekjugbajonmpjvreuaucilowvaqtwehbzzcmmsirukcvkbcjrjyqfragihjrvueptywrnhyfucvhlccjgajgybwkqadxpvbgkcbbjjftfayefzozbkbskdkxrfrsyxuvekjeiwxtdevvexxriefsyarnmtdokcxpnebccdctpxlhclllmtxisuprrnzoggwbxcmlvmvlacsbwxeexagdwbdtinupbgcbnafmdxacafpbyansexnxcclwzbcuabyudoebsqdhfamgeskaajbmqwzqvqpcrpclulkvotdgqcuegzqwsqqgvrljwzuawyivkzjrqdauzfidalutbwogqguvqzijuupsbxmjvbwdvxizfwngqrtfldiftsneysfvekgaftavtzrjkabrpyxznvkoofopdzxjdkefutpbawazbmmjmtggtozrfcbqgcqcfatlyuoumzajuzowdszoeynlwqmpdschegkzecetnjsfnwurumjflgzetwmdlkuaniqpaksexypjmmrlfxgjcxuhstupuvuuykirtfkectrzqaqfcscskpehccqlrnqlisfntyyncbsxjsolmaeupxjhqhpmxbidwmcyiexvtvoyqfaxipalzowhwckqiqsfoodftoamlyxfqhmbigqwxlpkiwfdswkybimfhgxfctuyvfdxqojlxjkwvdbqglvysqzkxwzghulvcfeuqfzfhelfbgxueoaqtcegrjzviaqjhawkaoodztawjjyddzfovxqemcvfpyszrfnywnufnyfcgdchzkqjmecjetbaxfdjtghiamnccyszrzcxhbtlxernvbghfwflqgihkeciqztxrfypdfnnjehiemcwiqtzptrmlomembeoemkhsnqreuccepmjdftxssqponebkjfjgvjnvtcniznuvwzmmasijftybkchwsiseztqibaxeukpietuqjaxupnzrkzmyunproonzjhpnpliqqbognbzpunypvfpuwuwwxfebwtmkxieytdxsvamfjdtmbclxzkmfkjnxbuknwdusvvfpoordyuynybjwuipxeccjlqbkrknvrzjvwnxylftcpsabpnckgctbeeilyauewqqcfoyagznwdfpntsqaumxdcftcxnljadmxglpxjzhbswmtcgsofxsvrutraookxkhrpqacyrhoekbvwldjvmimxictkinchrvrtdgaxdckgeyanonbsuhfoyztloiutgbdjkxajxzqwykelblliqzbfexejljfqdkfuszmjnhdobboyfyiyvgmqpfpesizekdqtcihskbucflxvlkadophvdhyblygbkttjugekpobgliufoluehsdvukfqjtrwhfytbmnauokjzxchbzpzyfdeguvfqylopylibwevzabpaqdczbzquillwbhxzuiatyoletnlckzndvexugfptjmvcqcmzjwhgjiwekmnigwkbgvvjndpvzxdndhdjkwqjpemgdhzslgofamsaxvsqjxxbnazjykizuldnfbyholycbleqncrisduwlpuuzirpffesbxtjxxkcrejwznpcqbwwoqeghzfqmxqqmoywryzqtrbqomzdaochyvcqfxuitcpwebyacnyzunhqdlkegannsivhtmajxqxhohlattckqkwaygcwiispwjxnffptddatymnusnpfelaprlzbknvihrqppiibamzdotboqjfzkkivtksvkmncxzvnphhkzddncgqmkicfdatdpdtpgfybwdkgqshcloyyceqjzfudjasrlruftezyeusxvlzdkdbtskiuusmumptuzpcckfgcxvfrpqjdblmqgdvhcpzmeqmdvlhxrkcrnewejdzvcnqkuyjiqufjfhiwxwmfzufnixpicftygjvkvmuoprjviadthtdkcewksmejiuauxaxyhymrkerchegpllqdfnilxuzjrwdbzjebzyadivnxeghgpvzanprwihlfbcofvzqcquzvclqhtgyaezlnutgzfdwysbrpvnipzojvzikhnyjiikakqhnvcvubydqsmjhwllcpjxqeoomygvmqtubecknvxgllcfotxvxjgifxzmogaojmihdqxkdaajpkmkkxydoapnvddolufdogfvylsdmonclijydzjjowewoyufgeutzatyqsvqiqzxlohdpepbmyqlskurnmpdflksqdueveottylidsausjxqavjsxedsrpuirzmrceumjvojcdtdwbqhtitgcegnuuhkvveffhtretpmrwgtpdhhhuwydyiktyeiymdcnmmmfsdufykypytrfduhofjgpmgjhxzfraxkxcovkmtieveqeqzehwmdzjdozogeqakegabrvefexivnoyromtsfmtisuwrbdqgxwffdgbmbjwsmxunduzoqhuhyrfbekfhwteyvrtcgtmsobmrmodblapsqbmrcrbpujiqpezichhmheplwmhvljptnecjmdkhpywaofpoqeelxzkeqwhicntomlfkoadrxvlnxcstifjoytfxoqyiezrrqahhgbwlexfgnvcofeepkyxmxuatrbkaakksgxggaikewpipjuczycwyydizbuniygnxnsynfcmehjvzpmssmskpkrlpzncpsgbdciolendhfvfksazparqkyrjsqoecdecvkepkiesrsgwesatvmkvchohievdubklnrkwvktvrdskoczfszpizvaqliwqtrrdfkgsnjentvxrwaopzqemnyvljjjiojogmrfecbnkkrpribtemujzdbrqwswumqonmhwrttgjeaxosyfyhcblezxvrkxrnwhlcilzzgowqwqptvijzkxqxanfgwhdkoaxcfrrsbnwwnxybdujbgymibijpxibowgvzxwwddenjvxhgbuibwwyrbttddoixbtahzcbofqecdnouwbyleprrsmhwctghyzbkwuijmoypgdvpvucaqageseqzvdahtllplenejftigyxcfvmdvsoviuacxgsgvvanvnmylenqnvtjqougalakaulcllnzpdankdyvraxpcqaydokdexivjtnvbujvkldbanjjwcvhespypdexcdlvmfhuumutssebxgxvyitaupgerxolhalwhjpmtqmnslaldcleugepnwlvrsfozucwebcvcfoqpzytpqaaysfxhvcpxbbsowjsjqcnphbvpinrnuietdskvhnwriqugmdcagcpmwginnicyfdgbdxjmgpabpazhqclkhyufmhhxkddpbykbhckpanszpszutakqfwlifrvjgsgnfxdejolialnbxwigtbkxxblgdcpvbksdilvgsdxtwxqpvnoercjckcajpmrnfoeozkosizpfnwzgsucqplprrwqbgnrhfhnvwlpnnpsjnpfedfpdgjcptwmedvzbajuxbemwcxvhrewkhtbhhbjjlejupeqejmxqawlvlsvwtslycdujftxuznhjiodpmmgvlbjkesifsqwuvuaspoltribtlymdnrifxuxqdlysbnsgwhqwcjxcuwdmnvdqdnocsfcgzisnbagusucdqvhkphiyekskxdxniwhdsmcqviiwnnjqpfxkuahkgkpnzddjveiucuxyzbiknkmzkdbnlykeiwhcotjslrmhzhoeauvniglqaksumcxkfljyjuvkowxdatvstzovrxttrapncrdpqdpgsxqtunjhatrrekcsqhlwqymayqremxubgqmllyhdbblolbqowxcktcwqmyoomcbhiurwdemsjycbdrotbkpufzakhfapgdwhzxixnmgxvjzdlzneqkhsbwnmwkkuwctdrxbajpqskbwbvjsvjexshxcvwsnnivurxzazrviuddmnwnqegvqtgmqtbdcddfjokcllhtgcqedmmfxcylfxyzggeapwoypvwtwfubfkqczwhbqsmmmutdnvarudlpoqwczkwnehihajtxezjdeiihtsppslpekbvyxxwhopnlrrvdzrfgpfcmexqccbhywokmagcyxaflbizwnzsiggbbofugakeipfhjfrkvxddxrshkrsggirgevcemjyyyhjdsdmvbhvcptbwlotulbxpdrjqywkpgtvzvmguupojcelcwyhqvrowawejnghhjtsxzvuebjeoqtmkcdirwabehetlksrdntvbfvpferipdfmrnvsklwfbrghszdkyvnyjaghthyoqopjqzcyxzewddbaobldlulmcaliemgfnhndfjzbvjqghhphwvtaxnymdvznurnvecmrtptmthtvxbphsonsspvobdcwhexifvbibyrctelpmcjvscqeevxpymahvunsplmasjspogabdgtlkhaxnvdgjphtmfppowlccwjahwalbrollcrkdindleeelxbrvexveytedwcbbikonxkcwiipkqxxetvwotvxbencxverypexlxkgrukxiucfjssghzdeoctknuvvkzqncaioxukjyjgtokdbczuzvidcgavvmqncyhlhbjabecchndqcweuabkroscagxttsilgjifsibefugamhqaebswoaauenmmoafhjdqmrqdfknvyxajopsdlcgwsialwfcbsqnsdwuxmmggjqxfcmlmfizqizltfqvisahdkgyvqkvkevdwmwsdjurtnpjxqrlykgwasklohkzpvlmdqifupinguphmezrzhmtswjilgvnldbbzxivvoqhrhdvdyypdtsvxwiaeeoggpddbiqwmbskrfwvcjtcdbsddrlusowhurgbonacaostuloeqoojdejbydlhlqfbzzgayjvvzckgtqocokmdjyrtbzvvdgwkghinclfucvygddeamifrmaqlpsfunbbjviiqbbkjcndeeixalihfkfhzmnxiaajogmqaevieehmoliwvubgtfwceuvhbzeedcpzbelzdczootbndolkalduplnfyzdkhxptpgpetjwjqssscuwnnxcgalliibxxftdfejsfmjlbpygtmuffwbinkadvyksiylxrntpvrudivvjjeszunkiopcaixqgodtvsxpdgfcvqwpmjuqmhnxktsqejjmidwhvebyvmvcqhirnbozsqfacpvkntzdympalidwkfinnetpaameenkvicikpcdswgswoedufnbqoijjysksbgzgploxzfteeupmragoblawammkhreiygxhynbhhjztppwazefnxlvkpxndepbpsxnuowwfeluidcppvtzlgshisssbvrwqtpkkvvhtzbvzuikzjxvmyrzvjfnpqylmtcalywuoplldayjdgrlricwnlsinaodpobnvdpocltyxpurcnuuwvbkhmsglfszwlxygyxbtaczhrblswveczyguzszwpyndpqteoibjkgtzrikgiqestutrfrvtdiaofqdnpnnqjmnhotvpjetlfrmvlorkrcipuzhiolqkjzazdvauogsutbsrongqbgzytiorpoddpnlahgoewtlethcncyfmiiaixeujewypqnzmuwrlwdbcudiatwwqrzyglzyaujijcbqgdguxutciubvsokzjwztowzdrzxabhmdeyyhvzqsveydmncbfwopcdeygzinqehlfaufozvdchxfljwsssgltskjmumbfmjkkeiqayeiteqeisqumatuqoumbwjewxtbqecqfrefetlvjowutrfmceplhxkuydkejdyvwryearyfvuihpyrtovwjfctsfxejcjbbbohpkdjsqwzlufuriojvaqrfeteumimjbashtxrclbhlblrcinbnfzewfzeengezmhunnftholpgsbethvwzlkwkryeccwusgnddhnfxgtxywaksputaceoeagfnflzagxkevlgvvpzvbsvbhjdqizjhgbqqindojczasiuhoqrfiljjezwjdpadomvvwsbcpsxsdjxwqysubgqmozubmixumcyaotzqmpoqpifglhtcbapbffjxdjkucugdwyggacdivysndruquhhpxyjukmwngofgdibxffuayfhllstxdhowzjrpolqnrwtmqohbievaezqhnwkvdtijjythdslaotyohyaqdxrfitqqdnqzhxijviqtmufmvqtmjlqomjurwzltrvwkjjsjccipxxtxdktqokfnbntovbchasyzbfgwlgdqxkchzztygymdfumbvpejrmetuqazfxwslvwfwjomgxjjzzcdwzszoijeydsekndfohvnmpmpegqakyassrhlgljncokisrpruqtvgnerqlkkqldhngypmknjfrmplraruizbotwaojujxrwslfhwahhidikrrwxsdxwlupeczrgfrxdnmqgxzjvnmwsjdjlipujkuyilwxnagqkmtktkioszivcyfyjgvdhggooiifcvzlnilhugwypfcnhzkahdktkpouahfxvacpvsljgohevkmqhuwfyrrlgqphnrykrtvqixvhztdmpwmpznoleniwgkftssnjrrbzdqrxxrwcrbwbukxczalegepuzbxgmxxucrrmzlxesigxbxbnkmpvuwhfupfcypahkwultfuqxgibnwkotpjaobjapiwrinzwitjfyqmfuufssncisckjnehsvinopmpyuccwprhglnrnjoardetkedrbndabkxfofudjmaqcahyxshfaiwkriwopgtrnhivrfxkswbneaxgjqvpkynkfxaicprftbnfzgprcolzmasyvhyyutmapqtlwxhdgmuczbeinalmerjdviqquwbypiguhoycutdblfddqyuuhpnhdowgqgrowovgiyggzyddgbqvzpytyostllzdeyoicqfinrjwidexewzlisuyizjikzfzsmvqhozijulddqqigommgovfplmhqpfzqedqsymjerltlefomjgzufxfwkpodvmnkzpwlotorsjgnrfhznxgvgvvjxsnqcnwmjtsjtvnbnnjxtuotcrgykmbjsjiwrjczaoupghomsletuotsirafuyrvefzfgvlxmrxotgqcvqployoqgqmluyjimgmcvyhbmrznjyzeawhwrfmruhsflposqmsthnudivzqbfgccvhsojgxbsmsigdluxenhqgvqppnvtyadrvseiptoaipndvxhblkwbfwgxsusgmwvotojbbtfwgwgrwiamkhsbcriunmccscsehyxmxrvmjjgrtrfognpddrqjyihzrzheqeqnxvcdpivpusimtektbspnyslmoicoyyciwoeqmqaoacwkksgvdgvpfljyggzdafniujxjoebxlrqppujxfoxfzuthknagaesnwxwxmxqppxkdvtgzlinbinxihlswrmvwhcjhdfyjgoxjtyyomzycacvvsjuvmwhkardxrqffrvfxrzxtubcckjkzttxhnaeayothbpqwotztlithcilpqoxvwbclurkjixupfradjzfwjlnvbkubckmdcwjitgbawncbwaqeluldrtsqrgcjmhgxqrwfbdtynraxdaofaymtaihvkddunxikmhqtredbhswyuhymdrlopxfsgnmatnymfauqxghvpkoctjmnwukylzdampfrngrvxurznoizvokrihzhyjhlnllyftbodgtqqddvnsqphfnafbndbxphcqripfpvjquhpbeqzqsabjmlznuvsilzjikclhyhgqnteesucgrnxkyrmdiiuulfwovwgrnwrfvsykpabnrapukuhsudmdjxgflcqjhevoxejsuhmylbmrvhsksrklajxzmgnnkjnjuahsjxjelmjvnkqriebpgmsozqftxpuloudjhhlugdbjffsoqivqyjsfxkiwaatxpfkaaziexkdicwnyowcumjfoayokleqdfkuneestjjieieketlrltzwtsbqpeyihxodrdzoaxgwzaibsqbgnahgrvqsjdhxxioxjpctrygncyfjdludrddohcxtovvdnmmypozwsuvxejdribxsegpvxtvovaphufgvcigkilsiothfonbonjqeoouvadlffwbjdkcgixniuamdzkvzqoohmvthjguupsbkrorwttzgjsjwekbwhyqkiuhcmmnfchiupbacmukcywpdsmqoibpliaswwuicfexrdwyjsqnteohnxflteiwfrdojdoqupbfcuxomiktdhqqkylelgmhwgekmvtznpquhxmgdpxhniwoxypbxrtelezivkxyhpiatqxhcyzeeejginybdtydgjntssbbcifysvauyoprqoazgtrwnziajhzyiurwvswfzhwvxirpapoafsiahwlvkieuyxicidgoaobxrqfllymxkpkazuthakjghwoqfxcstvrgwysqedzidfrgxpowqsgokiuectqripisjiryswavinqlsufgijjtaxwfjvtwvqbtyscngsebardarbrpcxroyxwahaxatlqkfmmxxghvnpqttfdviyjogfabcwjpzshtovadlmlqvrgtpxfcusjeklwyihovlvsxukohqaoaqxbujosveoxzuxrwscymevivkerpgqwdpntrdrzfkncjzjuakcagbgfdplmxyulkoiadmqzjzdnisyopolnalopzrqhhgfamkdyjbeywtlyjhaegmnafiltvyhypxczkxupzvaurozjjwxpqvblnvnetfvxaowszotvhnvumnhvzbwzydzympmdqfjnjujpxwmbvbubnspoxsdzgxwyobejbggnnwzkhojrrkapdhsgsmbkhdomngymguqmzlfxispmzewokttbfukpctzftlldevvhypfvwxyztilscdjvboescgrpqakbefgsvyypbgkfgffgozpwcuxnwulyiwdfdqusobsobfjcdcyzrnjnromlrttogppatjdtilqvioyzgzvmllommxplbzijgrcscxtmncpgsirqlqcxjlkswrfrdysyxorhmxukmpklautxlszmmyvoaysdzofnmphwkzeshvpapxqnphcxwuyxerbfwlwnndxijrnqmaopzerztejfwuslsfobhlqsxhkxfgtylihchsfsrnrcsyeclntohhtahorfoldrqtrfnwypolmjxhbwrmlcqasvhwfltqexmwfhizmqpdbimnjmucckkzjmhndvxnqttfrolnizoqtbkrxustvxfmqqafdnjorgevkanhxupuqbxrvmbkusvjuwtgbydezxmhfpsjddhgccjnighpjbueivlwhuymidbadqkticsabhsbpaqtftjmqzbmguzgxycbufhgkakwmwltdmymwjjyllpbciarutvqfckabpogolwtpewfrlxvcwefpjkxrjtmwkbrtcnchsbnoyuegymptqvibjxhddtoavovnrpcvvdngzsizihomacjueohqoukotimmqamtlsvznimtkjnfbzpxeggnerswpbqhcyurzsmlgyniqruiqkaiyzkyxuvefwrsaualifchdxahvezbecgahtfbwyildpamaoqrzmqeftjgfakekfreukxcnupvzplzgojdkxqbfkbebccvntamuthdcbkhdmsdnwxjukgnnoihflklmrczdfqjpjtladbzeymegoexzwueghhsilzefroywuiwmuotjgekgpbsmcpuinzeakrxcgxjuzcjhgvhndjwplrcjsxgfvqsddqkbhggqsdoemfftnquciprwiculqtzjvqqawtcipipvpwpvhmcpuwxufnmuovdkwnpdxraezavhqliimklcqqywwbveuwoltwaepeungjpghpvpuyiwoxjuqenkjoqcvertmsrjcdfiuqyrnaasqggcribqyqtbvsqzhysmwfmgildbffoaulgigezp",797354686,226258631,11645,117860120,"jlyjefhhggohffjyympmjtgywrdsnjbeuupeyuyhxmyugfyebbpgmnmrbddfdedlqtpdezcmnvfbyqiyvdqqcnihzpvleppjatrsynxmosmothitduzxcasgimrbaqhbszgmumktncyagocnuaoxhhhomyolotdfhgawahffzpogkgvthkosutrnblwgrrwkxkueogilcremwqklhsjuvawpjnnvrqdvjahibedwjlhrjdvjfxnntqjoxnozqnobmdoiktjohzbwiwibnzifiommlkqzayvhxdmyvjzqjmihegvdzdhzaemyfplbdnbzbbzdigbxhtqmgounykmidfalxrjsbyxtoyairigjctvsyuaoktyksklcakgisvgowmyktmovwxqgiwynqvjvrjqcdhqqnveeumjgqhoxwptfxcwnedpdhgpqxbrgxgiqiwinxvgrabqtrskzzftvqasojfvjmaipjvtklflpxiiqtrgaawemghqmnyzkigsyfyvomdzjnnfzcxxpfxefvkfajpbwszdgracntxacqxclbwgixkrieluqjkvkeocrilxrlnaqttipfmeoraujipapewufbarklsskgqhtkjphwnjrkdjssqscxdowrpmezzgmqwqdfgknvxizkvpydsypyqbqnztviizvrdvifdgwofcwxrmlsevznimbfeeeykxhthitvnxrtkahhunmeradovlvparilsscglzkypvmlsrelrbyzfogkmzoshnxqqgnypydjntfkwqqhuevmbizmexpxokcwwvsknqfrcysqnjdxctfijjlxmrhddxaqpqviuzvrwihafginxedpuqwrfowrkxbbfwqhwnnaoudpzffyartfbtyldeakldgleqraxwcssaloomhnbaflklcdyeuwudwocxazulterpjeeysmyfhioylcfrdrowgevjelscyiyxlslpxabltkpvodjkpxgtsxdzjkquvrgruysbqjjkleaaeksiagsfppdfgunwtkglmqmqmcmdoviogwcjwfknritnoigfmvhuclgxusxzsxsglfbyczziywjjupgtqnyrljqlacugxmmjmqhsiodzxsrjbexhdopwghmjdrcdntjgzrxpghkernwngicixfxcgjczeuzxzdjfbwktzjjwamcikveqmfzsnyycgjrjgulxdkoifatvjvkyujbaksqkohrknywzejnrzpyxsmruocwtqdwttuxunoychmfwursoezkqivmplizkzrnidosimlyqaxttgqmcmcgmccqfwgutdwvwhhzcmxbxjmqnmorcgsizrptkcicijxztwxnzjhemqpxyhqjylsuuczsguknvoxrpqmaoithrqocpxyslvmcmhvpgvhfqpmylliwrwiqezypcgickhkvhmikgaydruvbeolshbbgneshjjxnrfhjoranhgnzcdlgyqytlqokyvzvkzvizzupbqdhochhquomgxivtditqrzwhlcwwfsxokwtlnwwaitbshblsucvusihfewrxfdcxsrjawyelrtlbfuztjmgsulamubjzjkcctdcpftxbztwcdnxwooizqlnkcggvqhfhqslrbgtjmpvpmaaerjejfcjbtwjcsfznstbbeccmnzckhikfpegqxmifatlamqscbtapvnxgjklaabllfdegbscponegmdjrwefvdunolkyltmukdpyfeutkcnkjpohzneottwnyhqdbzsrbgsgloulmknpclrgkdfaiapopctgesnwbxjyyajkyhbbtzlfejijbgdkkzipemhaifibtmnkimjjjqbrrbwhcnhvtpmmiazzykseknyzbrfdliftpslcrulvoaqwhbdhekvawmajgqoqljvdgbzrifjcjdiaprhwyjabbprbudxkvqumdtubrjbskgfrifjkpuyeghoiifxjgcyvlvjlmeblwnarfyyoscqydymbbuwaecccoxjhsmescwgkwhbmqkvdmssqdfvoemmjrmfjeyblqkbknpqmgrbeyruegknnjyxhdllbfbjxrkthyjnwwwzblftunowfxqkxoghtsequcoyhqraxkqfcyehxcfbcgmnsxxkcbeeikewlxytkoztlvvqiirbabejiyatxonycfwzglgddvnlohyuuiegymrnvrkbgkkdkonhceneldylgsrajozvdzvxfxynoycjkquybysqwamnqghkitnzrzqkodohuaojsskdqjdiqxntdldpapwpscovavzhhawubknnegxifqmkbxfwsefnxwhbekvthucuhgeuscysriexpllwefyagalcdjcznuijrftmdjvhfmlakhgaglawdgqeqaaxmrjvmbvsyyvanuklpdkfohxiqborbexwbghxjcykbncnlgvwbyxvqbvnozoavxtvtbygpumfdelxogjaaawzpuwvkxahilrfzsqbekzrpdvrtavmjyeitcwzeiefiqdlcoodswastrkoduamudtuiyfmbhiulgjnlejzhmhfchdpuxpikkcxcyxmlluikazjivvhrpluhgmyvftwazdgyiymqefjnnpjlokhawllpzntpvmwnloclyujjkwfzzpheuynqqasjhnjwczcalatynetgmbphmzrelyhhqgbrxnyudofveydcmwewafphahgrykrzgylwerykngfghnsfvduvvzulfbylehnlrsfogtoirdxpfnfkppkkshqybstozfsbhweqsalzatfhqhvpqwwimxknuyylrnjfvbiyhcyhuhjowpyrvldmxctagjjxcrqytmqfwdzdyrupadpbsojgnucofshvavbswoaknkyldxnpzcexdwctmgfzwjnjdatirfvcdnivdklpugmfrefbstjefobgxpygglttwdyaggtjqnnqclovgcotyxcocojqqjnkiqrrnrqcqzyjokwcowckjgnnmdopdmrurokrjdlonqkdkbiehowaityujkeznkhlotpvxiukozvyojutpmhixstknxyzsdnhczvhymfrwmaezdolknwartsselqymptqbpdirihmouqbdzzthitesdgxbgsytdeyhxfzixowxquclcgsohfyiravaizgqqgadekyrjooljymxbhduznqqamdvnyffdyryaaotnxabxmpbcylzyhbnrnlazuctvoemwuxfzbxscyvzcvlprpuoubzgirvswdjfbaivbprbzdabtharpagqdzxfpqjwhoeyvzuzvugrxexaxffwefixltlzvuiqtyktxcmfoypqrgnekjugbajonmpjvreuaucilowvaqtwehbzzcmmsirukcvkbcjrjyqfragihjrvueptywrnhyfucvhlccjgajgybwkqadxpvbgkcbbjjftfayefzozbkbskdkxrfrsyxuvekjeiwxtdevvexxriefsyarnmtdokcxpnebccdctpxlhclllmtxisuprrnzoggwbxcmlvmvlacsbwxeexagdwbdtinupbgcbnafmdxacafpbyansexnxcclwzbcuabyudoebsqdhfamgeskaajbmqwzqvqpcrpclulkvotdgqcuegzqwsqqgvrljwzuawyivkzjrqdauzfidalutbwogqguvqzijuupsbxmjvbwdvxizfwngqrtfldiftsneysfvekgaftavtzrjkabrpyxznvkoofopdzxjdkefutpbawazbmmjmtggtozrfcbqgcqcfatlyuoumzajuzowdszoeynlwqmpdschegkzecetnjsfnwurumjflgzetwmdlkuaniqpaksexypjmmrlfxgjcxuhstupuvuuykirtfkectrzqaqfcscskpehccqlrnqlisfntyyncbsxjsolmaeupxjhqhpmxbidwmcyiexvtvoyqfaxipalzowhwckqiqsfoodftoamlyxfqhmbigqwxlpkiwfdswkybimfhgxfctuyvfdxqojlxjkwvdbqglvysqzkxwzghulvcfeuqfzfhelfbgxueoaqtcegrjzviaqjhawkaoodztawjjyddzfovxqemcvfpyszrfnywnufnyfcgdchzkqjmecjetbaxfdjtghiamnccyszrzcxhbtlxernvbghfwflqgihkeciqztxrfypdfnnjehiemcwiqtzptrmlomembeoemkhsnqreuccepmjdftxssqponebkjfjgvjnvtcniznuvwzmmasijftybkchwsiseztqibaxeukpietuqjaxupnzrkzmyunproonzjhpnpliqqbognbzpunypvfpuwuwwxfebwtmkxieytdxsvamfjdtmbclxzkmfkjnxbuknwdusvvfpoordyuynybjwuipxeccjlqbkrknvrzjvwnxylftcpsabpnckgctbeeilyauewqqcfoyagznwdfpntsqaumxdcftcxnljadmxglpxjzhbswmtcgsofxsvrutraookxkhrpqacyrhoekbvwldjvmimxictkinchrvrtdgaxdckgeyanonbsuhfoyztloiutgbdjkxajxzqwykelblliqzbfexejljfqdkfuszmjnhdobboyfyiyvgmqpfpesizekdqtcihskbucflxvlkadophvdhyblygbkttjugekpobgliufoluehsdvukfqjtrwhfytbmnauokjzxchbzpzyfdeguvfqylopylibwevzabpaqdczbzquillwbhxzuiatyoletnlckzndvexugfptjmvcqcmzjwhgjiwekmnigwkbgvvjndpvzxdndhdjkwqjpemgdhzslgofamsaxvsqjxxbnazjykizuldnfbyholycbleqncrisduwlpuuzirpffesbxtjxxkcrejwznpcqbwwoqeghzfqmxqqmoywryzqtrbqomzdaochyvcqfxuitcpwebyacnyzunhqdlkegannsivhtmajxqxhohlattckqkwaygcwiispwjxnffptddatymnusnpfelaprlzbknvihrqppiibamzdotboqjfzkkivtksvkmncxzvnphhkzddncgqmkicfdatdpdtpgfybwdkgqshcloyyceqjzfudjasrlruftezyeusxvlzdkdbtskiuusmumptuzpcckfgcxvfrpqjdblmqgdvhcpzmeqmdvlhxrkcrnewejdzvcnqkuyjiqufjfhiwxwmfzufnixpicftygjvkvmuoprjviadthtdkcewksmejiuauxaxyhymrkerchegpllqdfnilxuzjrwdbzjebzyadivnxeghgpvzanprwihlfbcofvzqcquzvclqhtgyaezlnutgzfdwysbrpvnipzojvzikhnyjiikakqhnvcvubydqsmjhwllcpjxqeoomygvmqtubecknvxgllcfotxvxjgifxzmogaojmihdqxkdaajpkmkkxydoapnvddolufdogfvylsdmonclijydzjjowewoyufgeutzatyqsvqiqzxlohdpepbmyqlskurnmpdflksqdueveottylidsausjxqavjsxedsrpuirzmrceumjvojcdtdwbqhtitgcegnuuhkvveffhtretpmrwgtpdhhhuwydyiktyeiymdcnmmmfsdufykypytrfduhofjgpmgjhxzfraxkxcovkmtieveqeqzehwmdzjdozogeqakegabrvefexivnoyromtsfmtisuwrbdqgxwffdgbmbjwsmxunduzoqhuhyrfbekfhwteyvrtcgtmsobmrmodblapsqbmrcrbpujiqpezichhmheplwmhvljptnecjmdkhpywaofpoqeelxzkeqwhicntomlfkoadrxvlnxcstifjoytfxoqyiezrrqahhgbwlexfgnvcofeepkyxmxuatrbkaakksgxggaikewpipjuczycwyydizbuniygnxnsynfcmehjvzpmssmskpkrlpzncpsgbdciolendhfvfksazparqkyrjsqoecdecvkepkiesrsgwesatvmkvchohievdubklnrkwvktvrdskoczfszpizvaqliwqtrrdfkgsnjentvxrwaopzqemnyvljjjiojogmrfecbnkkrpribtemujzdbrqwswumqonmhwrttgjeaxosyfyhcblezxvrkxrnwhlcilzzgowqwqptvijzkxqxanfgwhdkoaxcfrrsbnwwnxybdujbgymibijpxibowgvzxwwddenjvxhgbuibwwyrbttddoixbtahzcbofqecdnouwbyleprrsmhwctghyzbkwuijmoypgdvpvucaqageseqzvdahtllplenejftigyxcfvmdvsoviuacxgsgvvanvnmylenqnvtjqougalakaulcllnzpdankdyvraxpcqaydokdexivjtnvbujvkldbanjjwcvhespypdexcdlvmfhuumutssebxgxvyitaupgerxolhalwhjpmtqmnslaldcleugepnwlvrsfozucwebcvcfoqpzytpqaaysfxhvcpxbbsowjsjqcnphbvpinrnuietdskvhnwriqugmdcagcpmwginnicyfdgbdxjmgpabpazhqclkhyufmhhxkddpbykbhckpanszpszutakqfwlifrvjgsgnfxdejolialnbxwigtbkxxblgdcpvbksdilvgsdxtwxqpvnoercjckcajpmrnfoeozkosizpfnwzgsucqplprrwqbgnrhfhnvwlpnnpsjnpfedfpdgjcptwmedvzbajuxbemwcxvhrewkhtbhhbjjlejupeqejmxqawlvlsvwtslycdujftxuznhjiodpmmgvlbjkesifsqwuvuaspoltribtlymdnrifxuxqdlysbnsgwhqwcjxcuwdmnvdqdnocsfcgzisnbagusucdqvhkphiyekskxdxniwhdsmcqviiwnnjqpfxkuahkgkpnzddjveiucuxyzbiknkmzkdbnlykeiwhcotjslrmhzhoeauvniglqaksumcxkfljyjuvkowxdatvstzovrxttrapncrdpqdpgsxqtunjhatrrekcsqhlwqymayqremxubgqmllyhdbblolbqowxcktcwqmyoomcbhiurwdemsjycbdrotbkpufzakhfapgdwhzxixnmgxvjzdlzneqkhsbwnmwkkuwctdrxbajpqskbwbvjsvjexshxcvwsnnivurxzazrviuddmnwnqegvqtgmqtbdcddfjokcllhtgcqedmmfxcylfxyzggeapwoypvwtwfubfkqczwhbqsmmmutdnvarudlpoqwczkwnehihajtxezjdeiihtsppslpekbvyxxwhopnlrrvdzrfgpfcmexqccbhywokmagcyxaflbizwnzsiggbbofugakeipfhjfrkvxddxrshkrsggirgevcemjyyyhjdsdmvbhvcptbwlotulbxpdrjqywkpgtvzvmguupojcelcwyhqvrowawejnghhjtsxzvuebjeoqtmkcdirwabehetlksrdntvbfvpferipdfmrnvsklwfbrghszdkyvnyjaghthyoqopjqzcyxzewddbaobldlulmcaliemgfnhndfjzbvjqghhphwvtaxnymdvznurnvecmrtptmthtvxbphsonsspvobdcwhexifvbibyrctelpmcjvscqeevxpymahvunsplmasjspogabdgtlkhaxnvdgjphtmfppowlccwjahwalbrollcrkdindleeelxbrvexveytedwcbbikonxkcwiipkqxxetvwotvxbencxverypexlxkgrukxiucfjssghzdeoctknuvvkzqncaioxukjyjgtokdbczuzvidcgavvmqncyhlhbjabecchndqcweuabkroscagxttsilgjifsibefugamhqaebswoaauenmmoafhjdqmrqdfknvyxajopsdlcgwsialwfcbsqnsdwuxmmggjqxfcmlmfizqizltfqvisahdkgyvqkvkevdwmwsdjurtnpjxqrlykgwasklohkzpvlmdqifupinguphmezrzhmtswjilgvnldbbzxivvoqhrhdvdyypdtsvxwiaeeoggpddbiqwmbskrfwvcjtcdbsddrlusowhurgbonacaostuloeqoojdejbydlhlqfbzzgayjvvzckgtqocokmdjyrtbzvvdgwkghinclfucvygddeamifrmaqlpsfunbbjviiqbbkjcndeeixalihfkfhzmnxiaajogmqaevieehmoliwvubgtfwceuvhbzeedcpzbelzdczootbndolkalduplnfyzdkhxptpgpetjwjqssscuwnnxcgalliibxxftdfejsfmjlbpygtmuffwbinkadvyksiylxrntpvrudivvjjeszunkiopcaixqgodtvsxpdgfcvqwpmjuqmhnxktsqejjmidwhvebyvmvcqhirnbozsqfacpvkntzdympalidwkfinnetpaameenkvicikpcdswgswoedufnbqoijjysksbgzgploxzfteeupmragoblawammkhreiygxhynbhhjztppwazefnxlvkpxndepbpsxnuowwfeluidcppvtzlgshisssbvrwqtpkkvvhtzbvzuikzjxvmyrzvjfnpqylmtcalywuoplldayjdgrlricwnlsinaodpobnvdpocltyxpurcnuuwvbkhmsglfszwlxygyxbtaczhrblswveczyguzszwpyndpqteoibjkgtzrikgiqestutrfrvtdiaofqdnpnnqjmnhotvpjetlfrmvlorkrcipuzhiolqkjzazdvauogsutbsrongqbgzytiorpoddpnlahgoewtlethcncyfmiiaixeujewypqnzmuwrlwdbcudiatwwqrzyglzyaujijcbqgdguxutciubvsokzjwztowzdrzxabhmdeyyhvzqsveydmncbfwopcdeygzinqehlfaufozvdchxfljwsssgltskjmumbfmjkkeiqayeiteqeisqumatuqoumbwjewxtbqecqfrefetlvjowutrfmceplhxkuydkejdyvwryearyfvuihpyrtovwjfctsfxejcjbbbohpkdjsqwzlufuriojvaqrfeteumimjbashtxrclbhlblrcinbnfzewfzeengezmhunnftholpgsbethvwzlkwkryeccwusgnddhnfxgtxywaksputaceoeagfnflzagxkevlgvvpzvbsvbhjdqizjhgbqqindojczasiuhoqrfiljjezwjdpadomvvwsbcpsxsdjxwqysubgqmozubmixumcyaotzqmpoqpifglhtcbapbffjxdjkucugdwyggacdivysndruquhhpxyjukmwngofgdibxffuayfhllstxdhowzjrpolqnrwtmqohbievaezqhnwkvdtijjythdslaotyohyaqdxrfitqqdnqzhxijviqtmufmvqtmjlqomjurwzltrvwkjjsjccipxxtxdktqokfnbntovbchasyzbfgwlgdqxkchzztygymdfumbvpejrmetuqazfxwslvwfwjomgxjjzzcdwzszoijeydsekndfohvnmpmpegqakyassrhlgljncokisrpruqtvgnerqlkkqldhngypmknjfrmplraruizbotwaojujxrwslfhwahhidikrrwxsdxwlupeczrgfrxdnmqgxzjvnmwsjdjlipujkuyilwxnagqkmtktkioszivcyfyjgvdhggooiifcvzlnilhugwypfcnhzkahdktkpouahfxvacpvsljgohevkmqhuwfyrrlgqphnrykrtvqixvhztdmpwmpznoleniwgkftssnjrrbzdqrxxrwcrbwbukxczalegepuzbxgmxxucrrmzlxesigxbxbnkmpvuwhfupfcypahkwultfuqxgibnwkotpjaobjapiwrinzwitjfyqmfuufssncisckjnehsvinopmpyuccwprhglnrnjoardetkedrbndabkxfofudjmaqcahyxshfaiwkriwopgtrnhivrfxkswbneaxgjqvpkynkfxaicprftbnfzgprcolzmasyvhyyutmapqtlwxhdgmuczbeinalmerjdviqquwbypiguhoycutdblfddqyuuhpnhdowgqgrowovgiyggzyddgbqvzpytyostllzdeyoicqfinrjwidexewzlisuyizjikzfzsmvqhozijulddqqigommgovfplmhqpfzqedqsymjerltlefomjgzufxfwkpodvmnkzpwlotorsjgnrfhznxgvgvvjxsnqcnwmjtsjtvnbnnjxtuotcrgykmbjsjiwrjczaoupghomsletuotsirafuyrvefzfgvlxmrxotgqcvqployoqgqmluyjimgmcvyhbmrznjyzeawhwrfmruhsflposqmsthnudivzqbfgccvhsojgxbsmsigdluxenhqgvqppnvtyadrvseiptoaipndvxhblkwbfwgxsusgmwvotojbbtfwgwgrwiamkhsbcriunmccscsehyxmxrvmjjgrtrfognpddrqjyihzrzheqeqnxvcdpivpusimtektbspnyslmoicoyyciwoeqmqaoacwkksgvdgvpfljyggzdafniujxjoebxlrqppujxfoxfzuthknagaesnwxwxmxqppxkdvtgzlinbinxihlswrmvwhcjhdfyjgoxjtyyomzycacvvsjuvmwhkardxrqffrvfxrzxtubcckjkzttxhnaeayothbpqwotztlithcilpqoxvwbclurkjixupfradjzfwjlnvbkubckmdcwjitgbawncbwaqeluldrtsqrgcjmhgxqrwfbdtynraxdaofaymtaihvkddunxikmhqtredbhswyuhymdrlopxfsgnmatnymfauqxghvpkoctjmnwukylzdampfrngrvxurznoizvokrihzhyjhlnllyftbodgtqqddvnsqphfnafbndbxphcqripfpvjquhpbeqzqsabjmlznuvsilzjikclhyhgqnteesucgrnxkyrmdiiuulfwovwgrnwrfvsykpabnrapukuhsudmdjxgflcqjhevoxejsuhmylbmrvhsksrklajxzmgnnkjnjuahsjxjelmjvnkqriebpgmsozqftxpuloudjhhlugdbjffsoqivqyjsfxkiwaatxpfkaaziexkdicwnyowcumjfoayokleqdfkuneestjjieieketlrltzwtsbqpeyihxodrdzoaxgwzaibsqbgnahgrvqsjdhxxioxjpctrygncyfjdludrddohcxtovvdnmmypozwsuvxejdribxsegpvxtvovaphufgvcigkilsiothfonbonjqeoouvadlffwbjdkcgixniuamdzkvzqoohmvthjguupsbkrorwttzgjsjwekbwhyqkiuhcmmnfchiupbacmukcywpdsmqoibpliaswwuicfexrdwyjsqnteohnxflte"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, int power, int modulo, int k, int hashValue, string expected)
        {
            var sol = new Solution();
            var res = sol.SubStrHash(s, power, modulo, k, hashValue);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}