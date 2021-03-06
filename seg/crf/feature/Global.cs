using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace Program1
{
    namespace Feature
    {
        class Global
        {
            public static bool numLetterNorm = true;
            public static int featureTrim = 0;
            public const bool wordFeature = true;
            public const int wordMax = 6;
            public const int wordMin = 2;
            public const int nLabel = 5;//2 - 5
            public static int order = 1;//1 for 1st-order, 2 for 2nd-order

            //public static StreamWriter log;
            public static baseHashSet<string> trainLexiconSet;
            public static baseHashSet<string> trainBigramSet;

            public static char[] lineEndAry = { '\n' };
            public static string[] biLineEndAry = { "\n\n" };
            public static char[] undrlnAry = { '_' };
            public static char[] blankAry = { ' ' };
            public static char[] tabAry = { '\t' };
            public static char[] starAry = { '*' };
            public static char[] slashAry = { '/' };
            public const string delimInFeature = ".";
            public const string comma = ",";
            public const string B = "B";

            public const string chnNum = "几二三四五六七八九十千万亿兆零";
            public const string engNum = "0123456789.１２３４５６７８９０";
            public const string num = "0123456789.几二三四五六七八九十千万亿兆零１２３４５６７８９０％";
            public const string letter = "ＡＢＣＤＥＦＧＨＩＪＫＬＭＮＯＰＱＲＳＴＵＶＷＸＹＺａｂｃｄｅｆｇｈｉｇｋｌｍｎｏｐｑｒｓｔｕｖｗｘｙｚ／・－";
            public const string orgAppndx = "院部社国会所办库长委业协宫大局厂业区队帮";
            public const string nsLastWords = "地区市县乡区洲国村";
            public const string ntLastWords = "局院委会协联厂大中行艺站足办总队专所化党法部师校汽电新处室支贸司班垒监革厅小工高社科检系署百盟学旅组警段险团馆庭矿政";
            public const string mark = "*";
            public const string normalLetter = "abcdefghigklmnopqrstuvwxyz";
        }

    }

}
