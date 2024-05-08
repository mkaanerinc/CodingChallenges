using LeetCodeChallenges.MajorityElement;

namespace LeetCodeChallengesTests.MajorityElement;

public class SolutionTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArray_WhenFindMajorityElement_ThenResultAsExpected(int[] nums, int expectedResult)
    {
        int count = new Solution().MajorityElement(nums);
        count.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[] { 3, 2, 3 },
            3,
        ];
        yield return
        [
            new[] { 2, 2, 1, 1, 1, 2, 2 },
            2,
        ];
    }
}


