using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Palindrome
{

    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string input)
        {
            if (string.IsNullOrEmpty(input)) 
                return true;

            string normalized = new string(input.ToLower()
                .Where(char.IsLetter)
                .ToArray());

            Stack<char> stack = new Stack<char>();

            foreach (char c in normalized)
            {
                stack.Push(c);
            }

            foreach (char c in normalized)
            {
                if (c != stack.Pop())
                    return false;
            }

            return true;
        }
    }
}
