using System;

namespace DSA.DataStructures.Array;

public class MergeSortedArrays
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var temp = new List<int>();
        int i = 0;
        int j = 0;

        while (i < m && j < n)
        {
            if (nums1[i] < nums2[j])
            {
                temp.Add(nums1[i++]);
            }
            else
            {
                temp.Add(nums2[j++]);
            }
        }

        while (i < m)
        {
            temp.Add(nums1[i++]);
        }

        while (j < n)
        {
            temp.Add(nums2[j++]);
        }

        for (int index = 0; index < m + n; index++)
        {
            nums1[index] = temp[index];
        }
    }

}
