using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Class1
    {
         public int  Pair(int[] nums)
        {
            int cnt = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i = i + 2)
            {
                if (nums[i] == nums[i + 1])
                {
                    cnt = cnt + 1;
                }
            }
            return cnt;
        }
    }
}
