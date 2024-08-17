/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

// @lc code=start
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var length = digits.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i] += 1;
                return digits;
            }
            else
            {
                digits[i] = 0;
            }

        }

        var result = new int[length + 1];
        result[0] = 1;
        return result;
    }
}
// @lc code=end

