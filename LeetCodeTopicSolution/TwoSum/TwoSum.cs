using System.Collections.Generic;
using System.Linq;

namespace LeetCodeTopicSolution.TwoSum
{
    public class TwoSum
    {
        /// <summary>
        ///  循环两次
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public List<int[]> TwoSumFunc(int[] array, int target)
        {
            List<int[]> result = new List<int[]>();
            for (int i = 0; i < array.Count(); i++)
            {
                for (int j = i + 1; j < array.Count(); j++)
                {
                    if (array[i] + array[j] == target && array[i] != array[j])
                    {
                        int[] aa = { i, j };
                        result.Add(aa);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 循环一次
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public List<int[]> TwoSumFunc2(int[] array, int target)
        {
            List<int[]> result = new List<int[]>();
            for (int i = 0; i < array.Count(); i++)
            {
                var findIndexs = array.Select((value, index) => new { value, index }).Where(t => t.value == (target - array[i]));
                if (null == findIndexs || findIndexs.Count() <= 0)
                {
                    continue;
                }

                foreach (var item in findIndexs)
                {
                    if (i == item.index || array[i] == item.value)
                    {
                        continue;
                    }

                    var exists = result.Any(t => t[0] == item.index && t[1] == i);
                    if (!exists)
                    {
                        result.Add(new int[] { i, item.index });
                    }
                }
            }

            return result;
        }
    }
}

