using System;

namespace DSA.DataStructures.Array;

/// <summary>
/// Given an integer array nums, return the third distinct maximum number in this array.
/// If the third maximum does not exist, return the maximum number.
/// </summary> <summary>
/// 
/// </summary>
public class ThirdMaximumNumber
{
    public int ThirdMax(int[] nums)
    {
        var length = nums.Length;
        var temp = nums.GroupBy(x => x).ToDictionary(x => x.Key);
        var sorted = temp.Keys.OrderDescending().ToList();
        if (sorted.Count < 3) return sorted[0];
        else return sorted[2];
    }

    public int Improve(int[] nums)
    {
        int? first = null;
        int? second = null;
        int? third = null;

        for (int i = 0; i < nums.Length; i++)
        {
            if (first == nums[i] || second == nums[i] || third == nums[i]) continue;    // already seen this number

            if (first == null || nums[i] > first)
            {
                third = second;
                second = first;
                first = nums[i];
            }
            else if (second == null || nums[i] > second)
            {
                third = second;
                second = nums[i];
            }
            else if (third == null || nums[i] > third)
            {
                third = nums[i];
            }
        }

        return third == null ? first.Value : third.Value;
    }

    public void Solution()
    {
        int[] nums = [3, 4, 6, 4, 5, 1];
        Console.WriteLine(ThirdMax(nums)); ;
    }
}
