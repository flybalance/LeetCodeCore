using Xunit;

namespace LeetCodeTopicSolutionTest.TwoSum
{
    public class TwoSumTest
    {
        private LeetCodeTopicSolution.TwoSum.TwoSum twoSum = null;
        public TwoSumTest()
        {
            twoSum = new LeetCodeTopicSolution.TwoSum.TwoSum();
        }

        [Fact]
        public void TwoSumFuncTest()
        {
            int[] nums = { 2, 7, 11, 15 };

            var aa = twoSum.TwoSumFunc(nums, 9);

            Assert.True(true);
        }

        [Fact]
        public void TwoSumFunc2Test()
        {
            int[] nums = { 2, 7, 11, 15 };

            var aa = twoSum.TwoSumFunc2(nums, 9);

            Assert.True(true);
        }
    }
}
