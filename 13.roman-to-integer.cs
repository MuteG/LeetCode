/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */
public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        for (int i = s.Length - 1; i > -1 ; i--)
        {
            switch (s[i])
            {
                case 'I':
                    result += 1;
                    break;
                case 'V':
                    if (i > 0)
                    {
                        switch (s[i - 1])
                        {
                            case 'I':
                                result += 4;
                                i--;
                                break;
                            default:
                                result += 5;
                                break;
                        }
                    }
                    else
                    {
                        result += 5;
                    }
                    break;
                case 'X':
                    if (i > 0)
                    {
                        switch (s[i - 1])
                        {
                            case 'I':
                                result += 9;
                                i--;
                                break;
                            default:
                                result += 10;
                                break;
                        }
                    }
                    else
                    {
                        result += 10;
                    }
                    break;
                case 'L':
                    if (i > 0)
                    {
                        switch (s[i - 1])
                        {
                            case 'X':
                                result += 40;
                                i--;
                                break;
                            default:
                                result += 50;
                                break;
                        }
                    }
                    else
                    {
                        result += 50;
                    }
                    break;
                case 'C':
                    if (i > 0)
                    {
                        switch (s[i - 1])
                        {
                            case 'X':
                                result += 90;
                                i--;
                                break;
                            default:
                                result += 100;
                                break;
                        }
                    }
                    else
                    {
                        result += 100;
                    }
                    break;
                case 'D':
                    if (i > 0)
                    {
                        switch (s[i - 1])
                        {
                            case 'C':
                                result += 400;
                                i--;
                                break;
                            default:
                                result += 500;
                                break;
                        }
                    }
                    else
                    {
                        result += 500;
                    }
                    break;
                case 'M':
                    if (i > 0)
                    {
                        switch (s[i - 1])
                        {
                            case 'C':
                                result += 900;
                                i--;
                                break;
                            default:
                                result += 1000;
                                break;
                        }
                    }
                    else
                    {
                        result += 1000;
                    }
                    break;
            }
        }

        return result;
    }
}

