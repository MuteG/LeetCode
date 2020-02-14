/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */
public class Solution {
    public int Reverse(int x) {
        int result = 0;
        while (x != 0) {
            int pop = x % 10;
            x /= 10;
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && pop > 7))
            {
                return 0;
            }

            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && pop < -8))
            {
                return 0;
            }
            
            result = result * 10 + pop;
        }

        return result;
    }
}

