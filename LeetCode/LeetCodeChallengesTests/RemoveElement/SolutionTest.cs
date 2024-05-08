using LeetCodeChallenges.RemoveElement;

namespace LeetCodeChallengesTests.RemoveElement;

public class SolutionTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArray_WhenRemoveElement_ThenResultAsExpected(int[] nums, int val, int expectedValue)
    {
        int k = new Solution().RemoveElement(nums, val);
        k.ShouldBe(expectedValue);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[] { 3,2,2,3 },
            3,
            2,
        ];
        yield return
        [
            new[] { 0,1,2,2,3,0,4,2 },
            2,
            5,
        ];
    }
}
