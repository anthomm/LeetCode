using System;
using System.Collections.Generic;
using System.Text;

/*
 * Write a function to find the longest common prefix string amongst an array of strings.
 * If there is no common prefix, return an empty string "".
 * Input: ["flower","flow","flight"]
 * Output: "fl"
 */

namespace LeetCode.Easy.LongestCommonPrefix
{
    class LongestCommonPrefixNaive
    {

        public static void Run()
        {
            Console.WriteLine("Starting Naive LongestCommonPrefix");

            string[] input = new string[] { "phytoflagellate", "conflagration", "flibbertigibbet", "stagflationary" };
            string result = LongestCommonPrefix(input);

            Console.Write("Input: ");
            foreach (string s in input)
                Console.Write($"{s} ");
            Console.WriteLine();
            Console.WriteLine($"Result: {result}");
        }

        public static string LongestCommonPrefix(string[] input)
        {
            if (input.Length == 0)
                return "";
            
            string alpha = input[0];
            string returnee = "";
            
            for (int a = 0; a < alpha.Length; a++)
            {
                for (int b = 1; b + a <= alpha.Length; b++)
                {
                    string current = alpha.Substring(a, b);
                    bool isCommon = Array.TrueForAll(input, str => { return str.Contains(current);});
                    bool isLongest = current.Length > returnee.Length;
                    if (isCommon && isLongest)
                        returnee = current;
                }
            }
            return returnee;
        }
    }
}
