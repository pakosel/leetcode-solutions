using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace BagOfTokens
{
    public class Solution
    {
        public int BagOfTokensScore(int[] tokens, int power)
        {
            var score = 0;
            var tok = tokens.OrderBy(_ => _).ToList();
            while (tok.Count > 0)
            {
                if (tok.First() <= power)
                {
                    //face-up
                    score++;
                    power -= tok.First();
                    tok.RemoveAt(0);
                }
                else if (score > 0 && tok.Count > 1 && (tok.Last() + power) >= tok.First())
                {
                    //face-down
                    score--;
                    power += tok.Last();
                    tok.RemoveAt(tok.Count - 1);
                }
                else
                    break;
            }

            return score;
        }
    }
}