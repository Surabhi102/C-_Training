/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
					
public class Program
{
	public static void Main()
	{
		secLarg();
	}
	private static void secLarg()
	{
		int[] nums = {1,6,8,2,4,5,7,9,0};
		int first,sec;
		if(nums[0]<nums[1])
		{
           first= nums[1];
           sec = nums[0];
        }
       else{ 
           first = nums[0];
           sec = nums[1];
       }    
   for (int i = 2; i< nums.Length ; i++) {

      if (nums[i] > first) {
         sec = first;
         first = nums[i];
      }
      else if (nums[i] > sec && nums[i] != first) {
         sec = nums[i];
      }
   }
     Console.WriteLine("Second largest element is:" +sec);

}
		
}
