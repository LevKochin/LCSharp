namespace LCSharp.Array.Library;

public class ArrayConsecutiveCounterService
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        switch (nums)
        {
            case [1]:
                return 1;
            case [0]:
                return 0;
        }

        int higherCount = 0;
        int currentCounter = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                currentCounter = 0;
                continue;
            }

            if (nums[i] != 1) continue;
            
            currentCounter++;
            if (currentCounter > higherCount || currentCounter == higherCount)
            {
                higherCount = currentCounter;
            }
        }

        return higherCount;
    }
}