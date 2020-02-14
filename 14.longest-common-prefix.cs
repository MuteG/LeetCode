/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        switch (strs.Length)
        {
            case 0:
                return string.Empty;
            case 1:
                return strs[0];
            default:
                return GetLongestCommonPrefix(strs);
        }
    }

    private string GetLongestCommonPrefix(string[] strs)
    {
        int length = strs[0].Length;
        for (int i = 1; i < strs.Length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (j == strs[i].Length || strs[0][j] != strs[i][j])
                {
                    length = j;
                    break;
                }
            }
        }

        return strs[0].Substring(0, length);
    }
}

