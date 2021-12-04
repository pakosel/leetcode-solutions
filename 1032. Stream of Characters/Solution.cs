using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace StreamOfCharacters
{
    public class StreamChecker
    {
        string[] Words; //copy of input table
        (int pos, int[] prefixTab)[] WordsPos;  //for each word keep current position and KMP prefix-suffix table 
        int len;

        public StreamChecker(string[] words)
        {
            Words = words;
            len = words.Length;
            WordsPos = new (int, int[])[len];
            for (int i = 0; i < len; i++)
                WordsPos[i] = (0, BuildPrefixTable(words[i]));
        }

        public bool Query(char letter)
        {
            var res = false;
            for (int i = 0; i < len; i++)
                if (Check(i, letter))
                    res = true;
            return res;
        }

        private bool Check(int word, char letter)
        {
            var res = false;
            var wPos = WordsPos[word].pos;
            var wLen = Words[word].Length;

            if (Words[word][wPos] == letter)
                wPos++;
            else if (wPos > 0)
            {
                WordsPos[word].pos = WordsPos[word].prefixTab[wPos - 1];
                return Check(word, letter);
            }

            if (wPos == wLen)
            {
                res = true;
                wPos = WordsPos[word].prefixTab[wPos - 1];
            }

            WordsPos[word].pos = wPos;
            return res;
        }

        //builds prefix table from KMP algorithm
        private int[] BuildPrefixTable(string word)
        {
            int len = word.Length;
            var res = new int[len];
            int i = 0;
            int j = 1;
            while (j < len)
                if (word[i] == word[j])
                {
                    res[j] = i + 1;
                    i++;
                    j++;
                }
                else
                {
                    if (i == 0)
                        j++;
                    else
                        i = res[i - 1];
                }
            //Console.WriteLine(string.Join(',', res));
            return res;
        }
    }
}