using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsLeetCode
{

    /* https://leetcode.com/problems/running-sum-of-1d-array/description/ */
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                nums[i] = sum;
            }
            return nums;
        }
    }
}
