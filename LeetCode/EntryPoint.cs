using LeetCode.Helpers;
using LeetCode.NumberPalindrome;
using LeetCode.ReverseInteger;
using LeetCode.TwoSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class EntryPoint
    {
        static void Main(string[] args)
        {


            int[] inputs = new int[] { 123, -123, 120, Int32.MaxValue, Int32.MinValue };

            foreach (int i in inputs)
                ReverseIntegerNaive.Run(i);



        }
    }
}
