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

}
