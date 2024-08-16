using System;


namespace DSA.DataStructures.Array;

/// <summary>
/// Given an integer array nums sorted in non-decreasing order,
/// return an array of the squares of each number sorted in non-decreasing order.
/// </summary>
public class SquaresSortedArray
{
    public int[] SortedSquares(int[] nums)
    {
        var length = nums.Length;
        var negativeNums = nums.Where(x => x < 0).Reverse().Select(x => x * x).ToArray();
        var positiveNums = nums.Where(x => x >= 0).Select(x => x * x).ToArray();

        var negativeIndex = 0;
        var positiveIndex = 0;
        var index = 0;

        while (negativeIndex < negativeNums.Length && positiveIndex < positiveNums.Length)
        {
            if (negativeNums[negativeIndex] < positiveNums[positiveIndex])
            {
                nums[index++] = negativeNums[negativeIndex++];
            }
            else
            {
                nums[index++] = positiveNums[positiveIndex++];
            }
        }
        while (positiveIndex < positiveNums.Length)
        {
            nums[index++] = positiveNums[positiveIndex++];
        }

        while (negativeIndex < negativeNums.Length)
        {
            nums[index++] = negativeNums[negativeIndex++];
        }

        return nums;
    }

    public int[] Improve(int[] nums)
    {
        int length = nums.Length;
        int left = 0;
        int right = length - 1;
        int[] result = new int[length];
        for (int i = right; i >= 0; i--)
        {
            if (Math.Abs(nums[right]) > Math.Abs(nums[left]))
            {
                result[i] = (int)Math.Pow(nums[right--], 2);
            }
            else
            {
                result[i] = (int)Math.Pow(nums[left++], 2);
            }
        }

        return result;
    }

    public void Solution()
    {
        int[] nums = [-4, -1, 0, 3, 10];

        var result = Improve(nums);
        for (int i = 0; i < result.Length; i++)
        {
            System.Console.WriteLine(result[i]);
        }
    }
}
