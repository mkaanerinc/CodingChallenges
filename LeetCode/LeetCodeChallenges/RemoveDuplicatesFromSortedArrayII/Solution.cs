namespace LeetCodeChallenges.RemoveDuplicatesFromSortedArrayII;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 0;
        int count = 0;
        int prevValue = 0;

        for (int i = 0; i < nums.Length; i++)
        {

            if (prevValue != nums[i] || k == 0)
            {
                if (count > 0)
                {
                    count = 0;
                }
                nums[k] = nums[i];
                k++;
                prevValue = nums[i];
                count++;
            }
            else if (prevValue == nums[i] && count < 2)
            {
                nums[k] = nums[i];
                k++;
                count++;
            }
        }
        return k;
    }
}
