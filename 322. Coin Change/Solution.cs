using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CoinChange
{
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            if (amount < 1)
                return amount;
            Array.Sort(coins);

            int len = coins.Length;
            const int inf = int.MaxValue-1;
            int[,] arr = new int[len+1, amount+1];
            
            for(int j=0; j<=amount; j++)
                arr[0,j] = inf;

            for(int i=1; i<=len; i++)
            {
                if(coins[i-1] > amount)
                {
                    arr[len, amount] = arr[i-1, amount];
                    break;
                }
                for(int j=1; j<=amount; j++)
                    if(j < coins[i-1])
                        arr[i,j] = arr[i-1,j];
                    else if(j == coins[i-1])
                        arr[i,j] = 1;
                    else
                        arr[i,j] = Math.Min(arr[i-1, j], j > coins[i-1] ? 1 + arr[i, j - coins[i-1]] : inf);
            }

            return arr[len, amount] == inf ? -1 : arr[len,amount];
        }
    }

    public class Solution_Recursive
    {
        Dictionary<int, int> dictChange = new Dictionary<int, int>();

        public int CoinChange(int[] coins, int amount)
        {
            if (dictChange.ContainsKey(amount))
                return dictChange[amount];

            int res = -1;
            if (amount == 0)
                res = 0;
            else if (amount < 0)
                res = -1;
            else
                foreach (var coin in coins)
                {
                    if (coin > amount)
                        continue;

                    int change = CoinChange(coins, amount - coin);
                    if (change != -1 && (res == -1 || change + 1 < res))
                        res = change + 1;
                }

            dictChange.Add(amount, res);
            return res;
        }
    }
}