using System;

namespace DSA.DataStructures.Array;

public class RemoveElement
{
    public int removeElement(int[] result, int val)
    {
        int index = 0;
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] != val)
            {
                result[index++] = result[i];
            }
        }
        return index;
    }
}
