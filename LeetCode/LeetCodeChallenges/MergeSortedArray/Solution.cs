namespace LeetCodeChallenges.MergeSortedArray;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int index = 0;

        while (index <= n - 1 && n > 0)
        {
            nums1[m] = nums2[index];
            m++;
            index++;
        }

        Array.Sort(nums1);
    }
}
