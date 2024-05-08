using LeetCodeChallenges.RemoveDuplicatesFromSortedArrayII;

namespace LeetCodeChallengesTests.RemoveDuplicatesFromSortedArrayII;

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
            new[] { 1, 1, 1, 2, 2, 3 },
            5,
        ];
        yield return
        [
            new[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 },
            7,
        ];
    }
}
