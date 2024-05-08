namespace LeetCodeChallenges.MajorityElement;

public class Solution
{
    private Dictionary<int, int> countNums(int[] nums)
    {
        Dictionary<int, int> counts = new();

        foreach (int num in nums)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts.Add(num, 1);
            }
        }
        return counts;
    }

    public int MajorityElement(int[] nums)
    {
        var counts = countNums(nums);

        foreach (var count in counts)
        {
            if (count.Value > nums.Length / 2)
            {
                return count.Key;
            }
        }
        return -1;
    }
}
