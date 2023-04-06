using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsLeetCode
{
    /* https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/description/ */
    public class Solution1
    {
        public int NumberOfSteps(int num)
        {
            int numSteps = 0;

            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num -= 1;
                }
                numSteps++;
            }

            return numSteps;
        }
    }
}
