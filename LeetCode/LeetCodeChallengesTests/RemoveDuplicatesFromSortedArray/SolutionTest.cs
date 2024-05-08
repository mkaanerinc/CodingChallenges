using LeetCodeChallenges.RemoveDuplicatesFromSortedArray;

namespace LeetCodeChallengesTests.RemoveDuplicatesFromSortedArray;

public class SolutionTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArray_WhenRemoveDuplicatesNumbers_ThenResultAsExpected(int[] nums, int expectedValue)
    {
        int k = new Solution().RemoveDuplicates(nums);
        k.ShouldBe(expectedValue);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[] { 1,1,2 },
            2,
        ];
        yield return
        [
            new[] { 0,0,1,1,1,2,2,3,3,4 },
            5,
        ];
    }
}
