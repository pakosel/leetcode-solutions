using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NumberOfStudentsUnableToEatLunch
{
    public class Solution
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            var qStudent = new Queue<int>(students);
            var qSandw = new Queue<int>(sandwiches);
            var taken = true;
            while (taken && qSandw.Count > 0)
            {
                taken = false;
                var cnt = qStudent.Count;
                for (int i = 0; i < cnt; i++)
                    if (qSandw.Peek() == qStudent.Peek())
                    {
                        taken = true;
                        qSandw.Dequeue();
                        qStudent.Dequeue();
                    }
                    else
                        qStudent.Enqueue(qStudent.Dequeue());
            }
            return qStudent.Count;
        }
    }
}