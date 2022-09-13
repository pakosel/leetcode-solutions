using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace UTF8Validation
{
    public class Solution
    {
        public bool ValidUtf8(int[] data)
        {
            var mask2b = 0b11000000;
            var mask3b = 0b11100000;
            var mask4b = 0b11110000;

            int i = 0;
            while (i < data.Length)
            {
                var oct = data[i];
                if ((oct & mask4b) == mask4b && (oct >> 3) % 2 == 0)   //4-bytes char
                {
                    if (!CheckRemainingOctets(ref i, 3))
                        return false;
                }
                else if ((oct & mask3b) == mask3b && (oct >> 4) % 2 == 0)  //3-bytes char
                {
                    if (!CheckRemainingOctets(ref i, 2))
                        return false;
                }
                else if ((oct & mask2b) == mask2b && (oct >> 5) % 2 == 0)  //2-bytes char
                {
                    if (!CheckRemainingOctets(ref i, 1))
                        return false;
                }
                else if ((oct >> 7) != 0)   //1-byte char
                    return false;
                i++;
            }

            return true;

            //checks for 0b10xxxxxx byte
            bool CheckRemOctet(int oct) => ((oct >> 6) % 2 == 0) && ((oct >> 7) == 1);

            bool CheckRemainingOctets(ref int i, int howMany)
            {
                if (i + howMany >= data.Length)
                    return false;
                else
                    for (int x = 0; x < howMany; x++)
                        if (!CheckRemOctet(data[++i]))
                            return false;
                return true;
            }
        }
    }
}