namespace LCSharp.Array.Library;

public class ArrayConcatenationService
{
    public int[] ConcatArray(int[] nums) 
    {
        int[] result = new int[nums.Length * 2];
        int indexer = 0;
        for(int i = 0; i < result.Length; i++ )
        {
            result[i] = nums[indexer];
            if(indexer >= nums.Length - 1){
                indexer = 0;
                continue;
            }

            indexer++;
        }

        return result;
    }
}