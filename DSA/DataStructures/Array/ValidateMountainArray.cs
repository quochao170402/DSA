namespace DSA.DataStructures.Array;

public class ValidateMountainArray
{
    public bool ValidMountainArray(int[] arr)
    {
        if (arr.Length < 3) { return false; }

        var peakFound = false;
        for (var i = 1; i < arr.Length; i++)
        {
            // Find peak
            if (peakFound == false
            && i < arr.Length - 1
            && arr[i - 1] < arr[i]
            && arr[i] > arr[i + 1])
            {
                peakFound = true;

                continue;
            }

            // if not found peak but before element greater than current return false
            if (arr[i - 1] >= arr[i] && peakFound == false)
            {
                return false;
            }

            // if found peak but before element less than current return false
            if (arr[i - 1] <= arr[i] && peakFound == true)
            {
                return false;
            }
        }

        return peakFound;
    }


    public void Solution()
    {
        int[] arr = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        System.Console.WriteLine(ValidMountainArray(arr));
    }
}