/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
        {
            return false;
        }

        long original = x;
        long reverse = 0;
        while (x != 0)
        {
            reverse = reverse * 10 + x % 10;
            x /= 10;
        }
        
        return original == reverse;
    }
}

