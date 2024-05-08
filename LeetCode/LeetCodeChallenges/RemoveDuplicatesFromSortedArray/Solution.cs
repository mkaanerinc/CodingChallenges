namespace LeetCodeChallenges.RemoveDuplicatesFromSortedArray;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 0;
        int isUnique = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (isUnique != nums[i] || k == 0)
            {
                nums[k] = nums[i];
                k++;
                isUnique = nums[i];
            }
        }
        return k;
    }
}
