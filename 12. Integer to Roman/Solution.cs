using System.Text;

namespace IntegerToRoman
{
    public class Solution
    {
        public string IntToRoman(int num)
        {
            int[] numbers = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int index = 0;
            StringBuilder sb = new StringBuilder();
            while (index < 13)  //arrays size
            {
                int div = num / numbers[index];
                for (int i = 0; i < div; i++)
                    sb.Append(symbols[index]);

                num = num % numbers[index];

                index++;
            }

            return sb.ToString();
        }
    }
}