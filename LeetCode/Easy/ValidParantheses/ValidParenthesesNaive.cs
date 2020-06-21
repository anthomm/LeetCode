using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LeetCode.Easy.ValidParantheses
{
    static class ValidParenthesesNaive
    {
        public static void Run(string input = "{()}")
        {
            Console.WriteLine("Starting Naive ValidParantheses");

            Console.WriteLine($"Input: {input}");

            bool result = IsValid(input);

            Console.WriteLine($"Result: {result}");
        }

        public static bool IsValid(string input)
        {
            Stack<char> activeStack = new Stack<char>(input);
            Stack<char> memoryStack = new Stack<char>();

            if (activeStack.Count % 2 != 0)
                return false;

            if (activeStack.Count == 2)
                return IsMatch(activeStack.Pop(), activeStack.Pop());

            char current = activeStack.Pop();
            char next;

            while (activeStack.Count > 0)
            {
                next = activeStack.Pop();
                if (IsMatch(current, next))
                {
                    if(activeStack.Count > 0)
                        current = memoryStack.Count > 0 ? memoryStack.Pop() : activeStack.Pop();
                }
                else
                {
                    memoryStack.Push(current);
                    current = next;
                }
            }
            return memoryStack.Count == 0;
        }

        private static bool IsMatch(char right, char left)
        {
            return (right, left) switch
            {
                (')', '(') => true,
                ('}', '{') => true,
                (']', '[') => true,
                _ => false
            };
        }
    }
}
