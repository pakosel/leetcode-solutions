using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;
using System;

namespace DesignUndergroundSystem
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {new string[] {"checkIn","checkIn","checkIn","checkOut","checkOut","checkOut","getAverageTime","getAverageTime","checkIn","getAverageTime","checkOut","getAverageTime"}, "[[45,Leyton,3],[32,Paradise,8],[27,Leyton,10],[45,Waterloo,15],[27,Waterloo,20],[32,Cambridge,22],[Paradise,Cambridge],[Leyton,Waterloo],[10,Leyton,24],[Leyton,Waterloo],[10,Waterloo,38],[Leyton,Waterloo]]", new double?[] {null,null,null,null,null,null,14.00000,11.00000,null,11.00000,null,12.00000}},
            new object[] {new string[] {"checkIn","checkOut","getAverageTime","checkIn","checkOut","getAverageTime","checkIn","checkOut","getAverageTime"}, "[[10,Leyton,3],[10,Paradise,8],[Leyton,Paradise],[5,Leyton,10],[5,Paradise,16],[Leyton,Paradise],[2,Leyton,21],[2,Paradise,30],[Leyton,Paradise]]", new double?[] {null,null,5.00000,null,null,5.50000,null,null,6.66667}},
            new object[] {new string[] {"checkIn","checkIn","checkOut","checkOut","getAverageTime","checkIn","checkIn","checkIn","getAverageTime","getAverageTime","checkOut","checkOut"}, "[[252268,N1R8BQ8R,68],[496222,IZGXE8X8,140],[496222,2IJEJN4V,187],[252268,2IJEJN4V,239],[IZGXE8X8,2IJEJN4V],[309637,A8AIY9G3,243],[289473,N1R8BQ8R,295],[55863,N1R8BQ8R,395],[IZGXE8X8,2IJEJN4V],[IZGXE8X8,2IJEJN4V],[55863,W9RW4PPG,467],[309637,W9RW4PPG,508]]", new double?[] {null,null,null,null,47.00000,null,null,null,47.00000,47.00000,null,null}},
            new object[] {new string[] {"checkIn","checkIn","checkOut","getAverageTime","getAverageTime","checkOut","checkIn","getAverageTime","getAverageTime","checkIn","getAverageTime","getAverageTime","checkIn","checkOut","checkIn","checkIn","checkOut","checkOut","checkOut","checkOut","checkIn","checkIn","checkIn","getAverageTime","checkOut","checkIn","getAverageTime","checkIn","checkOut","checkIn","checkIn","getAverageTime","checkOut","getAverageTime","getAverageTime","getAverageTime","checkIn","checkOut","checkOut","checkOut","getAverageTime","checkIn","getAverageTime","checkIn","getAverageTime","checkIn","checkIn","checkIn","checkOut","getAverageTime","checkIn","checkOut","checkOut","checkOut","getAverageTime","checkIn","getAverageTime","checkOut","checkIn","checkOut","checkIn","checkOut","checkOut","checkIn","getAverageTime","checkIn","checkIn","getAverageTime","checkOut","checkOut","checkIn","checkOut","getAverageTime","getAverageTime","checkIn","getAverageTime","checkOut","getAverageTime","getAverageTime","checkIn","checkOut","checkIn","checkOut","checkOut","checkOut","checkIn","checkOut","checkIn","getAverageTime","checkOut","checkOut","checkIn","checkIn","getAverageTime","getAverageTime","getAverageTime","checkOut","checkIn","getAverageTime","getAverageTime","checkOut","checkIn","getAverageTime","getAverageTime","checkIn","checkOut","checkIn","checkIn","checkOut","getAverageTime","getAverageTime","checkIn","checkIn","checkIn","checkOut","getAverageTime","getAverageTime","checkIn","checkOut","getAverageTime","checkIn","checkOut","checkIn","getAverageTime","checkOut","getAverageTime","getAverageTime","checkOut","getAverageTime","checkOut","getAverageTime","getAverageTime","checkIn","getAverageTime","checkOut","checkOut","checkOut","checkOut","checkIn","checkIn","getAverageTime","checkOut","checkIn","getAverageTime","getAverageTime","checkOut","checkOut","checkIn","getAverageTime","checkIn","getAverageTime","getAverageTime","checkIn","checkIn","getAverageTime","getAverageTime","getAverageTime","checkIn","getAverageTime","getAverageTime","checkOut","checkOut","checkOut","checkIn","checkIn","checkIn","checkOut","getAverageTime","checkIn","getAverageTime","checkIn","checkIn","getAverageTime","getAverageTime","checkIn","checkOut","getAverageTime","getAverageTime","getAverageTime","checkIn","getAverageTime","checkIn","checkOut","getAverageTime","getAverageTime","getAverageTime","checkIn","checkIn","getAverageTime","checkOut","getAverageTime","checkIn","getAverageTime","checkIn","checkOut","getAverageTime","checkOut","getAverageTime","checkIn","getAverageTime","getAverageTime","checkIn","getAverageTime","getAverageTime","checkIn","checkIn","checkIn","checkIn","getAverageTime","getAverageTime","getAverageTime","checkOut","checkOut","checkIn","checkIn","checkIn","checkOut","checkIn","checkIn","getAverageTime","getAverageTime","checkIn","getAverageTime","getAverageTime","checkIn","checkIn","checkOut","checkIn","getAverageTime","checkIn","checkOut","checkOut","checkOut","checkIn","checkOut","getAverageTime","checkOut","checkIn","checkOut","getAverageTime","getAverageTime","getAverageTime","checkOut","checkIn","checkOut","checkOut","getAverageTime","checkOut","getAverageTime","checkIn","checkOut","checkOut","checkIn","checkOut","checkIn","getAverageTime","getAverageTime","checkOut","checkIn","getAverageTime","checkOut","checkIn","checkIn","getAverageTime","checkIn","checkOut","getAverageTime","checkIn","getAverageTime","getAverageTime","getAverageTime","checkIn","getAverageTime","getAverageTime","getAverageTime","getAverageTime","checkIn","getAverageTime","checkOut","checkOut","checkOut","checkIn","checkIn","checkOut","checkIn","checkIn","checkIn","checkOut","checkIn","getAverageTime","checkIn","getAverageTime","getAverageTime","checkOut","getAverageTime","getAverageTime","getAverageTime","checkOut","checkOut","checkOut","checkOut","checkIn","getAverageTime","checkOut","checkOut","checkIn","getAverageTime","checkOut","checkOut","checkOut","getAverageTime","checkIn","getAverageTime","getAverageTime","checkOut","getAverageTime","checkOut","checkIn","checkIn","checkIn","checkOut","checkIn","getAverageTime","checkOut","getAverageTime","checkOut","checkOut","checkOut","getAverageTime","checkOut","getAverageTime","checkIn","checkIn","checkIn","checkOut","checkIn","checkIn","checkOut","checkOut","checkOut","getAverageTime","checkIn","checkIn","checkOut","getAverageTime","checkOut","getAverageTime","getAverageTime","getAverageTime","getAverageTime","checkIn","checkOut","checkOut","checkOut","getAverageTime","checkIn","checkIn","getAverageTime","checkIn","checkOut","checkIn","checkOut","checkIn","getAverageTime","getAverageTime","checkIn","getAverageTime","getAverageTime","checkIn","checkOut","checkOut","checkIn","checkIn","checkIn","checkIn","getAverageTime","checkOut","getAverageTime","checkIn","getAverageTime","checkIn","getAverageTime","getAverageTime","getAverageTime","checkOut","getAverageTime","checkOut","checkIn","getAverageTime","checkOut","getAverageTime","checkOut","checkIn","getAverageTime","checkIn","checkIn","getAverageTime","getAverageTime","checkIn","getAverageTime","getAverageTime","checkOut"}, "[[609968,97QOLNZD,31],[37064,VU0HBL6F,129],[609968,OLTGDUJE,186],[97QOLNZD,OLTGDUJE],[97QOLNZD,OLTGDUJE],[37064,OLTGDUJE,216],[194105,97QOLNZD,242],[97QOLNZD,OLTGDUJE],[97QOLNZD,OLTGDUJE],[552818,97QOLNZD,335],[VU0HBL6F,OLTGDUJE],[VU0HBL6F,OLTGDUJE],[476332,YYF1P5VL,413],[194105,OLTGDUJE,449],[965495,VU0HBL6F,502],[368978,VU0HBL6F,563],[965495,OLTGDUJE,585],[368978,OLTGDUJE,644],[476332,OLTGDUJE,723],[552818,OLTGDUJE,759],[324787,VU0HBL6F,779],[929404,97QOLNZD,799],[72549,VU0HBL6F,868],[97QOLNZD,OLTGDUJE],[72549,OLTGDUJE,915],[899674,XVHLYCRN,923],[VU0HBL6F,OLTGDUJE],[256212,97QOLNZD,953],[929404,OLTGDUJE,982],[147703,VU0HBL6F,992],[904624,97QOLNZD,1053],[97QOLNZD,OLTGDUJE],[147703,OLTGDUJE,1080],[97QOLNZD,OLTGDUJE],[VU0HBL6F,OLTGDUJE],[97QOLNZD,OLTGDUJE],[192883,YYF1P5VL,1091],[256212,OLTGDUJE,1174],[899674,OLTGDUJE,1263],[324787,OLTGDUJE,1334],[97QOLNZD,OLTGDUJE],[586321,97QOLNZD,1397],[97QOLNZD,OLTGDUJE],[634498,VU0HBL6F,1471],[VU0HBL6F,OLTGDUJE],[892415,VU0HBL6F,1480],[19974,YYF1P5VL,1509],[874719,VU0HBL6F,1572],[586321,OLTGDUJE,1610],[VU0HBL6F,OLTGDUJE],[972254,NRW5SQLU,1629],[634498,OLTGDUJE,1725],[972254,OLTGDUJE,1787],[904624,OLTGDUJE,1882],[VU0HBL6F,OLTGDUJE],[597666,97QOLNZD,1949],[NRW5SQLU,OLTGDUJE],[19974,92KXDXW2,1980],[892678,VU0HBL6F,2078],[192883,OLTGDUJE,2084],[847464,YYF1P5VL,2147],[847464,OLTGDUJE,2204],[892678,OLTGDUJE,2220],[145043,97QOLNZD,2237],[YYF1P5VL,OLTGDUJE],[245633,13369TK7,2316],[620799,VU0HBL6F,2403],[97QOLNZD,OLTGDUJE],[145043,OLTGDUJE,2469],[245633,OLTGDUJE,2538],[875880,VU0HBL6F,2549],[892415,YI2ZL427,2625],[YYF1P5VL,OLTGDUJE],[YYF1P5VL,OLTGDUJE],[408668,XVHLYCRN,2725],[YYF1P5VL,OLTGDUJE],[875880,DE9O2U2V,2821],[VU0HBL6F,OLTGDUJE],[VU0HBL6F,YI2ZL427],[975667,VU0HBL6F,2864],[597666,92KXDXW2,2919],[530083,97QOLNZD,2938],[530083,OLTGDUJE,2966],[408668,OLTGDUJE,2973],[975667,URZAY52T,3068],[674822,YUSLG5L2,3088],[674822,92KXDXW2,3129],[997706,VU93U5Z8,3157],[VU0HBL6F,OLTGDUJE],[997706,OLTGDUJE,3257],[874719,OLTGDUJE,3261],[379129,0NSOUZYL,3263],[633576,OOEUYNSG,3319],[13369TK7,OLTGDUJE],[97QOLNZD,OLTGDUJE],[VU0HBL6F,OLTGDUJE],[379129,DE9O2U2V,3375],[987977,VU0HBL6F,3396],[97QOLNZD,OLTGDUJE],[VU0HBL6F,OLTGDUJE],[633576,OLTGDUJE,3474],[623554,VU0HBL6F,3520],[VU0HBL6F,OLTGDUJE],[VU0HBL6F,OLTGDUJE],[35929,97QOLNZD,3589],[987977,OLTGDUJE,3625],[68002,VU93U5Z8,3629],[930323,NRW5SQLU,3656],[623554,92KXDXW2,3723],[VU0HBL6F,OLTGDUJE],[VU0HBL6F,OLTGDUJE],[109889,OOEUYNSG,3814],[699461,VU0HBL6F,3870],[977676,97QOLNZD,3926],[35929,OLTGDUJE,3957],[VU0HBL6F,OLTGDUJE],[97QOLNZD,92KXDXW2],[595332,VU0HBL6F,3980],[620799,92KXDXW2,4034],[NRW5SQLU,OLTGDUJE],[949766,97QOLNZD,4109],[109889,OLTGDUJE,4198],[613141,13369TK7,4214],[VU0HBL6F,OLTGDUJE],[613141,YI2ZL427,4231],[YYF1P5VL,OLTGDUJE],[VU93U5Z8,OLTGDUJE],[68002,92KXDXW2,4287],[VU93U5Z8,OLTGDUJE],[977676,Z80P7Y4U,4344],[VU0HBL6F,OLTGDUJE],[VU0HBL6F,92KXDXW2],[109426,13369TK7,4358],[VU0HBL6F,OLTGDUJE],[595332,1PFT5D19,4397],[109426,YI2ZL427,4459],[949766,OLTGDUJE,4516],[930323,L23SLU6Z,4614],[718534,Z4OTBEJ5,4629],[886515,VU0HBL6F,4668],[97QOLNZD,OLTGDUJE],[718534,URZAY52T,4729],[568316,97QOLNZD,4821],[VU0HBL6F,OLTGDUJE],[YYF1P5VL,92KXDXW2],[886515,OLTGDUJE,4904],[568316,OLTGDUJE,4992],[95957,57VCMKDH,4998],[VU0HBL6F,92KXDXW2],[789569,97QOLNZD,5067],[VU0HBL6F,OLTGDUJE],[YYF1P5VL,OLTGDUJE],[941835,1RISPEQD,5070],[884430,XVHLYCRN,5126],[XVHLYCRN,OLTGDUJE],[13369TK7,YI2ZL427],[VU93U5Z8,92KXDXW2],[372017,0NSOUZYL,5145],[VU0HBL6F,OLTGDUJE],[VU0HBL6F,OLTGDUJE],[941835,OLTGDUJE,5174],[884430,OLTGDUJE,5236],[372017,OLTGDUJE,5336],[941816,0NSOUZYL,5353],[694859,XVHLYCRN,5452],[561303,97QOLNZD,5482],[789569,1M7VGPP5,5556],[XVHLYCRN,OLTGDUJE],[741167,1Z90BZJ1,5573],[YYF1P5VL,OLTGDUJE],[669546,VU0HBL6F,5650],[624349,97QOLNZD,5716],[VU0HBL6F,OLTGDUJE],[VU0HBL6F,92KXDXW2],[989249,VU0HBL6F,5801],[741167,OLTGDUJE,5898],[YYF1P5VL,OLTGDUJE],[0NSOUZYL,OLTGDUJE],[97QOLNZD,OLTGDUJE],[29246,VU0HBL6F,5991],[1RISPEQD,OLTGDUJE],[515862,0NSOUZYL,5995],[669546,FPC3FSCW,6094],[VU0HBL6F,OLTGDUJE],[97QOLNZD,1M7VGPP5],[VU0HBL6F,92KXDXW2],[322839,VU0HBL6F,6155],[891747,VU0HBL6F,6254],[VU93U5Z8,92KXDXW2],[989249,OPNTT8UT,6330],[VU0HBL6F,1PFT5D19],[915839,VU0HBL6F,6361],[YYF1P5VL,OLTGDUJE],[212417,97QOLNZD,6432],[891747,L23SLU6Z,6460],[97QOLNZD,OLTGDUJE],[515862,OLTGDUJE,6500],[Z4OTBEJ5,URZAY52T],[536366,97QOLNZD,6511],[VU0HBL6F,OLTGDUJE],[VU0HBL6F,OLTGDUJE],[749464,3AK318HM,6513],[YYF1P5VL,OLTGDUJE],[OOEUYNSG,OLTGDUJE],[952818,97QOLNZD,6558],[49834,VU0HBL6F,6560],[44449,VU0HBL6F,6601],[119876,13369TK7,6616],[VU0HBL6F,OLTGDUJE],[VU93U5Z8,92KXDXW2],[13369TK7,YI2ZL427],[44449,92KXDXW2,6646],[49834,AOIEBIUF,6713],[204307,97QOLNZD,6783],[271518,YZ7783RF,6807],[139572,N7B7DUJO,6848],[119876,46ECI908,6898],[620608,97QOLNZD,6923],[314121,BRM878KO,6935],[VU93U5Z8,OLTGDUJE],[VU0HBL6F,OLTGDUJE],[931843,97QOLNZD,6955],[1Z90BZJ1,OLTGDUJE],[NRW5SQLU,L23SLU6Z],[497950,13369TK7,6983],[851803,VU0HBL6F,7068],[561303,OLTGDUJE,7133],[537093,XVHLYCRN,7208],[VU0HBL6F,FPC3FSCW],[987519,13369TK7,7258],[952818,GLWEB05D,7356],[537093,92KXDXW2,7401],[536366,92KXDXW2,7477],[136100,K1T2P5YB,7542],[322839,OLTGDUJE,7615],[97QOLNZD,Z80P7Y4U],[624349,OLTGDUJE,7637],[418250,13369TK7,7723],[418250,OLTGDUJE,7809],[VU0HBL6F,OLTGDUJE],[VU0HBL6F,92KXDXW2],[VU0HBL6F,OLTGDUJE],[314121,YI2ZL427,7812],[249072,97QOLNZD,7907],[699461,OLTGDUJE,7933],[212417,OLTGDUJE,7984],[13369TK7,OLTGDUJE],[204307,7KC1OQ72,8009],[97QOLNZD,OLTGDUJE],[536224,VU0HBL6F,8066],[851803,OLTGDUJE,8087],[139572,666LR04S,8132],[912385,97QOLNZD,8181],[620608,87OQBEQY,8202],[514483,VU0HBL6F,8264],[VU0HBL6F,URZAY52T],[VU0HBL6F,OLTGDUJE],[536224,OLTGDUJE,8324],[823466,VU0HBL6F,8359],[13369TK7,OLTGDUJE],[912385,2HVUYYSF,8389],[588279,VU0HBL6F,8445],[615613,VU0HBL6F,8465],[VU0HBL6F,1PFT5D19],[70545,ULJH8N4O,8511],[915839,OLTGDUJE,8607],[0NSOUZYL,OLTGDUJE],[367895,BRM878KO,8617],[VU0HBL6F,OLTGDUJE],[YYF1P5VL,OLTGDUJE],[XVHLYCRN,OLTGDUJE],[446842,V4VFDI94,8640],[VU0HBL6F,OLTGDUJE],[VU0HBL6F,OLTGDUJE],[VU0HBL6F,92KXDXW2],[VU0HBL6F,92KXDXW2],[732106,97QOLNZD,8690],[XVHLYCRN,OLTGDUJE],[514483,92KXDXW2,8778],[987519,92KXDXW2,8823],[588279,87OQBEQY,8825],[964339,97QOLNZD,8900],[895799,VU0HBL6F,8952],[249072,7KC1OQ72,9029],[184108,YYF1P5VL,9048],[863917,VU0HBL6F,9109],[611083,QCZ80JUK,9168],[964339,OLTGDUJE,9244],[273152,97QOLNZD,9338],[VU0HBL6F,87OQBEQY],[167340,1RISPEQD,9374],[0NSOUZYL,DE9O2U2V],[NRW5SQLU,OLTGDUJE],[367895,AOIEBIUF,9405],[YYF1P5VL,OLTGDUJE],[97QOLNZD,OLTGDUJE],[VU0HBL6F,OLTGDUJE],[863917,OLTGDUJE,9438],[749464,OLTGDUJE,9488],[823466,5KWZ6KU7,9498],[895799,TG2FADR9,9538],[480913,NRW5SQLU,9621],[13369TK7,YI2ZL427],[480913,BX2G1JRH,9669],[497950,J9OAO4WI,9722],[448201,2HQD7S6U,9748],[YUSLG5L2,92KXDXW2],[446842,DE9O2U2V,9749],[70545,OLTGDUJE,9816],[941816,FPC3FSCW,9868],[VU0HBL6F,OLTGDUJE],[863114,NKNRXUWQ,9941],[VU0HBL6F,OLTGDUJE],[0NSOUZYL,DE9O2U2V],[184108,OLTGDUJE,10031],[OOEUYNSG,OLTGDUJE],[95957,BX2G1JRH,10079],[789305,97QOLNZD,10080],[601017,VU0HBL6F,10133],[991158,VU0HBL6F,10169],[991158,URZAY52T,10248],[810395,ULJH8N4O,10252],[97QOLNZD,2HVUYYSF],[732106,O82S1ZAE,10303],[YYF1P5VL,OLTGDUJE],[601017,OLTGDUJE,10354],[167340,OLTGDUJE,10439],[615613,7KC1OQ72,10539],[OOEUYNSG,OLTGDUJE],[694859,T4I1V7UN,10575],[13369TK7,YI2ZL427],[521370,OOEUYNSG,10596],[838146,YYF1P5VL,10630],[986434,0NSOUZYL,10652],[448201,NUD7TC0G,10732],[135503,97QOLNZD,10763],[544340,ULJH8N4O,10794],[611083,OLTGDUJE,10878],[810395,OLTGDUJE,10964],[789305,87OQBEQY,10986],[VU0HBL6F,OLTGDUJE],[912878,HYS1DOV0,11062],[629087,97QOLNZD,11128],[863114,AOIEBIUF,11151],[97QOLNZD,OLTGDUJE],[521370,5KWZ6KU7,11202],[0NSOUZYL,DE9O2U2V],[97QOLNZD,OLTGDUJE],[OOEUYNSG,OLTGDUJE],[VU0HBL6F,YI2ZL427],[792724,NRW5SQLU,11258],[273152,OLTGDUJE,11281],[135503,5KWZ6KU7,11333],[136100,TAYVGQKM,11343],[VU0HBL6F,7KC1OQ72],[556560,BOZBA70L,11350],[684867,VU0HBL6F,11371],[XVHLYCRN,OLTGDUJE],[566256,VQM6QYPS,11451],[566256,URZAY52T,11526],[524582,1RISPEQD,11551],[986434,92KXDXW2,11573],[230315,BRM878KO,11656],[VU0HBL6F,OLTGDUJE],[1RISPEQD,OLTGDUJE],[222592,97QOLNZD,11662],[VQM6QYPS,URZAY52T],[0NSOUZYL,FPC3FSCW],[315997,0NSOUZYL,11762],[792724,OLTGDUJE,11796],[222592,WJYDEQE5,11823],[42217,13369TK7,11824],[822508,97QOLNZD,11880],[978066,5M1ZSGFK,11971],[596047,V4VFDI94,12020],[97QOLNZD,OLTGDUJE],[822508,MHO4YLIO,12100],[NRW5SQLU,BX2G1JRH],[530310,ULJH8N4O,12199],[97QOLNZD,OLTGDUJE],[590609,VU0HBL6F,12264],[VU0HBL6F,TG2FADR9],[VU0HBL6F,OLTGDUJE],[NRW5SQLU,OLTGDUJE],[544340,OLTGDUJE,12292],[13369TK7,YI2ZL427],[315997,OLTGDUJE,12313],[281471,VU0HBL6F,12338],[VU0HBL6F,OLTGDUJE],[42217,5LE5PNEJ,12370],[VU0HBL6F,92KXDXW2],[29246,OLTGDUJE,12469],[82700,13369TK7,12505],[VU0HBL6F,OLTGDUJE],[454606,9OI9H11X,12534],[348718,LDDX3K3X,12580],[VU0HBL6F,92KXDXW2],[VU0HBL6F,OLTGDUJE],[626844,97QOLNZD,12658],[97QOLNZD,OLTGDUJE],[OOEUYNSG,5KWZ6KU7],[931843,OLTGDUJE,12686]]", new double?[] {null,null,null,155.00000,155.00000,null,null,155.00000,155.00000,null,87.00000,87.00000,null,null,null,null,null,null,null,null,null,null,null,262.00000,null,null,74.50000,null,null,null,null,242.25000,null,242.25000,77.20000,242.25000,null,null,null,null,238.00000,null,238.00000,null,156.83333,null,null,null,null,156.83333,null,null,null,null,170.71429,null,158.00000,null,null,null,null,null,null,null,453.33333,null,null,318.85714,null,null,null,null,453.33333,453.33333,null,453.33333,null,167.12500,1145.00000,null,null,null,null,null,null,null,null,null,167.12500,null,null,null,null,222.00000,276.88889,336.22222,null,null,276.88889,336.22222,null,null,336.22222,336.22222,null,null,null,null,null,325.50000,325.50000,null,null,null,null,325.50000,970.00000,null,null,158.00000,null,null,null,325.50000,null,453.33333,100.00000,null,100.00000,null,325.50000,917.00000,null,325.50000,null,null,null,null,null,null,297.00000,null,null,325.50000,471.00000,null,null,null,917.00000,null,317.36364,453.33333,null,null,294.00000,59.00000,658.00000,null,317.36364,317.36364,null,null,null,null,null,null,null,232.66667,null,453.33333,null,null,317.36364,917.00000,null,null,453.33333,191.00000,286.50000,null,104.00000,null,null,317.36364,489.00000,917.00000,null,null,658.00000,null,417.00000,null,453.33333,null,null,286.50000,null,100.00000,null,317.36364,317.36364,null,453.33333,269.50000,null,null,null,null,317.36364,658.00000,59.00000,null,null,null,null,null,null,null,null,100.00000,317.36364,null,325.00000,958.00000,null,null,null,null,444.00000,null,null,null,null,null,null,418.00000,null,null,null,412.58333,626.33333,412.58333,null,null,null,null,154.00000,null,570.80000,null,null,null,null,null,null,204.00000,716.64286,null,null,154.00000,null,null,null,417.00000,null,null,348.00000,null,783.56250,453.33333,232.66667,null,783.56250,783.56250,626.33333,626.33333,null,232.66667,null,null,null,null,null,null,null,null,null,null,null,380.00000,null,112.00000,158.00000,null,453.33333,556.62500,783.56250,null,null,null,null,null,59.00000,null,null,null,41.00000,null,null,null,756.82353,null,756.82353,112.00000,null,269.50000,null,null,null,null,null,null,208.00000,null,585.75000,null,null,null,269.50000,null,59.00000,null,null,null,null,null,null,null,null,null,727.05556,null,null,null,556.62500,null,112.00000,556.62500,269.50000,1145.00000,null,null,null,null,2074.00000,null,null,232.66667,null,null,null,null,null,727.05556,584.50000,null,75.00000,4515.00000,null,null,null,null,null,null,null,638.17647,null,48.00000,null,638.17647,null,586.00000,727.05556,348.00000,null,59.00000,null,null,727.05556,null,598.25000,null,null,1029.73684,null,null,598.25000,1029.73684,null,638.17647,606.00000,null}},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string[] commands, string argsStr, double?[] expected)
        {
            var args = ArrayHelper.MatrixFromString<string>(argsStr, true);

            ClassicAssert.AreEqual(commands.Length, args.Length);
            ClassicAssert.AreEqual(commands.Length, expected.Length);            

            var res = new double?[expected.Length];
            var sol = new UndergroundSystem();
            for(int i=0; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "checkIn":
                    {
                        var id = int.Parse(args[i][0]);
                        var station = args[i][1];
                        var t = int.Parse(args[i][2]);
                        sol.CheckIn(id, station, t);
                        break;
                    }
                    case "checkOut":
                    {
                        var id = int.Parse(args[i][0]);
                        var station = args[i][1];
                        var t = int.Parse(args[i][2]);
                        sol.CheckOut(id, station, t);
                        break;
                    }
                    case "getAverageTime":
                        res[i] = Math.Round(sol.GetAverageTime(args[i][0], args[i][1]), 5);
                        break;
                }

            CollectionAssert.AreEqual(expected, res);
        }
    }
}