using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace TheNumberOfWeakCharactersInTheGame
{
    public class Solution
    {
        public int NumberOfWeakCharacters(int[][] properties)
        {
            const int MAX_VAL = 100001;
            var arr = new int[MAX_VAL + 1]; //max defence val for a given attack
            var maxAttack = 0;
            var res = 0;
            foreach (var p in properties)
            {
                arr[p[0]] = Math.Max(arr[p[0]], p[1]);
                maxAttack = Math.Max(maxAttack, p[0]);
            }

            var currMax = arr[maxAttack];
            for (int i = maxAttack - 1; i > 0; i--)
                if (arr[i] < currMax)
                    arr[i] = currMax;
                else
                    currMax = arr[i];

            for (int i = 0; i < properties.Length; i++)
                if (properties[i][1] < arr[properties[i][0] + 1])
                    res++;
            return res;
        }
    }
}