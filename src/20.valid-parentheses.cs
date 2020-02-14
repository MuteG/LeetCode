/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */
 using System.Collections;
 using System.Collections.Generic;

public class Solution {
    private readonly Dictionary<char, char> pairs = new Dictionary<char, char>() {
        { '(', ')' },
        { '{', '}' },
        { '[', ']' }
    };
    private readonly HashSet<char> right = new HashSet<char> { ')', '}', ']' };
    private readonly Stack<char> stack = new Stack<char>();
    public bool IsValid(string s) {
        if (string.IsNullOrEmpty(s))
        {
            return true;
        }
        int halfLength = s.Length / 2;
        foreach (var c in s)
        {
            if (pairs.ContainsKey(c))
            {
                stack.Push(c);
                if (stack.Count > halfLength)
                {
                    return false;
                }
            }
            else if (right.Contains(c))
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                if (pairs[stack.Peek()] == c)
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}

