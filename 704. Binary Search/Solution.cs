namespace _704._Binary_Search;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int highest = nums.Length - 1;
        int lowest = 0;

        while (highest >= lowest)
        {
            int middle = (lowest + highest) / 2;

            if (target == nums[middle])
                return middle;

            if (target < nums[middle])
                highest = middle - 1;
            else if (target > nums[middle])
                lowest = middle + 1;
        }
        return -1;
    }
}
