using System;

namespace DSA.DataStructures.Array;

public class HeightChecker
{
    public int Solution(int[] heights)
    {
        int numberOfIndices = 0;
        var expected = heights.Order().ToArray();

        for (int i = 0; i < heights.Length; i++)
        {
            if (expected[i] != heights[i]) numberOfIndices++;
        }
        return numberOfIndices;
    }

    public int ThirdMax(int[] nums)
    {
        int length = nums.Length;
        int firstMax = nums[0];
        int secondMax = nums[0];
        int thirdMax = nums[0];
        for (int i = 0; i < length; i++)
        {
            if (nums[i] > firstMax)
            {
                firstMax = nums[i];
                secondMax = nums[i];
            }
            else if (nums[i] > secondMax)
            {
                secondMax = nums[i];
                thirdMax = nums[i];
            }
            else if (nums[i] > thirdMax)
            {
                thirdMax = nums[i];
            }
        }

        return thirdMax;
    }

    public void Solution()
    {
        int[] nums = [3, 2, 1, 3, 4, 6, 4, 5, 1, 1];
        System.Console.WriteLine(ThirdMax(nums)); ;
    }
}
