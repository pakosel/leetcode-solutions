using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RobotBoundedInCircle
{
    public class Solution
    {
        public bool IsRobotBounded(string instructions)
        {
            (int x, int y) pos = (0, 0);
            int dir = 0;    //0 = N, 1 = E, 2 = S, 3 = W
            var repeats = 4;
            while (repeats-- > 0)
            {
                Process(instructions, ref pos, ref dir);
                if (pos == (0, 0))
                    return true;
            }
            return false;
        }

        private void Process(string instructions, ref (int, int) pos, ref int dir)
        {
            foreach (var c in instructions)
                switch (c)
                {
                    case 'G':
                        Move(ref pos, dir);
                        break;
                    case 'R':
                        dir++;
                        dir %= 4;
                        break;
                    case 'L':
                        dir--;
                        if (dir < 0)
                            dir = 3;
                        break;
                }
        }

        private void Move(ref (int x, int y) pos, int dir)
        {
            switch (dir)
            {
                case 0:
                    pos.y--;
                    break;
                case 1:
                    pos.x++;
                    break;
                case 2:
                    pos.y++;
                    break;
                case 3:
                    pos.x--;
                    break;
            }
        }
    }
}