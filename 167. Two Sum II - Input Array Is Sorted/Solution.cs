namespace _167._Two_Sum_II___Input_Array_Is_Sorted;

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int[] result = new int[2];

        for (int i = 0; i <= numbers.Length - 1; i++)
        {
            int index = Array.BinarySearch(numbers, target - numbers[i]);
            Console.WriteLine(index);
            if (index >= 0)
            {
                result[0] = Math.Min(i + 1, index + 1);
                result[1] = Math.Max(i + 1, index + 1);

                if (result[0] != result[1])
                    return result;
            }
        }
        return result;
    }
}
