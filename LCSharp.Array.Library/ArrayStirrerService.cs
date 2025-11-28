namespace LCSharp.Array.Library;

public class ArrayStirrerService
{
    public int[] Shuffle(int[] nums, int n)
    {
        if (n < 0 || n > 500)
        {
            throw new Exception("n has not valid value");
        }

        if (nums.Length != 2 * n)
        {
            throw new Exception("Length of array is invalid");
        }

        int[] result = new int[nums.Length];
        int xIndexer = 0;
        int yIndexer = 1;

        int partIndex = n;
        for (int i = 0; i < n; i++)
        {
            if (nums[i] < 1 || nums[i] > 10 * 10 * 10)
            {
                throw new Exception("Array value is invalid");
            }

            result[xIndexer] = nums[i];
            result[yIndexer] = nums[partIndex];
            partIndex++;

            xIndexer += 2;
            yIndexer += 2;
        }

        return result;
    }
}