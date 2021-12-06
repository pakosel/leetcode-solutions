using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumNumberOfOperationsToMoveAllBallsToEachBox
{
    public class Solution
    {
        public int[] MinOperations(string boxes)
        {
            int len = boxes.Length;
            var res = new int[len];
            
            var leftOnes = boxes[0] == '1' ? 1 : 0;
            var rightOnes = 0;

            for (int i = 1; i < len; i++)
                if (boxes[i] == '1')
                {
                    res[0] += i;
                    rightOnes++;
                }
            
            for (int i = 1; i < len; i++)
            {
                res[i] = res[i - 1] - rightOnes + leftOnes;
                if (boxes[i] == '1')
                {
                    leftOnes++;
                    rightOnes--;
                }
            }
            return res;
        }
    }
}