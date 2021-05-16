/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
   int[] nums = { 1, 2, 1, 3, 2, 4, 5 };
            int cnt = 0;
            Array.Sort(nums);
            for(int i=0; i<nums.Length-1;i=i+2)
            {
                if(nums[i]==nums[i+1])
                {
                    cnt = cnt + 1;
                }
            }
            Console.WriteLine(cnt);
  }
}

