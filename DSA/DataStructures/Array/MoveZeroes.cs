using System;

namespace DSA.DataStructures.Array;

public class MoveZeroesToEnd
{
    public void MoveZeroes(int[] nums)
    {
        int length = nums.Length;
        int left = 0;
        for (int i = 0; i < length; i++)
        {
            if (nums[i] != 0)
            {
                var temp = nums[i];
                nums[i] = nums[left];
                nums[left++] = temp;
            }
        }
    }

    public void Solution()
    {
        int[] nums = [0, 1, 0, 0, 2, 2, 0, 1, 2];
        MoveZeroes(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            System.Console.WriteLine(nums[i]);
        }
    }
}
