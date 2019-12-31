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
            int[] array = { 6, 1, 10, 4, 0, 5, 7, 5 };
            int num = 10;
            var reslut = twoSum.TwoSumFunc(array, num);

            Assert.True(reslut.Count == 2);
        }

        [Fact]
        public void TwoSumFunc2Test()
        {
            int[] array = { 6, 1, 10, 4, 0, 5, 7, 5 };
            int num = 10;
            var result = twoSum.TwoSumFunc2(array, num);

            Assert.True(result.Count == 2);
        }
    }
}
