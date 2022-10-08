namespace _977._Squares_of_a_Sorted_Array;

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        return nums.OrderBy(n => n * n).Select(n => n * n).ToArray();
    }
}
