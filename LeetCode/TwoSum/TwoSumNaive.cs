using System;

/*
 * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
 * 
 * Example:
 * Given nums = [2, 7, 11, 15], target = 9,
 * Because nums[0] + nums[1] = 2 + 7 = 9,
 * return [0, 1].
 * 
 * public int[] TwoSum(int[] nums, int target)
*/

namespace LeetCode.TwoSum
{
    class TwoSumNaive
    {
        public static void Run()
        {
            Console.WriteLine("Starting Naive TwoSum");

            int[] input = new int[] { 2, 7, 11, 15 };
            int target = 17;
            int[] result = TwoSumNaive.TwoSum(input, target);

            Console.WriteLine($"Input: {Helpers.StringHelper.IntArrayToString(input)}");
            Console.WriteLine($"Target: {target}");
            Console.WriteLine($"Result: {Helpers.StringHelper.IntArrayToString(result)}");

            Console.WriteLine("Ending");
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int outer = 0; outer < nums.Length-1; outer++)
            {
                for (int inner = outer+1; inner < nums.Length; inner++)
                {
                    if(nums[outer] + nums[inner] == target)
                        return new int[] { outer, inner };
                }
            }
            return new int[] {};
        }
    }
}
