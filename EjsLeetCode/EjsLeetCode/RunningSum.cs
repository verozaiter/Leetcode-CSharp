using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsLeetCode
{
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
