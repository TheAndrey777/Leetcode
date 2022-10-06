namespace _35._Search_Insert_Position;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int lowest = 0;
        int highest = nums.Length - 1;
        
        while (highest >= lowest)
        {
            int middle = (lowest + highest) / 2;

            if (target < nums[middle])
                highest = middle - 1;
            else if (target > nums[middle])
                lowest = middle + 1;
            else
                return middle;
        }
        return lowest;
    }
}
