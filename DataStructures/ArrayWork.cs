using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class ArrayWork : IOperations
    {
        //Comments lines
        public void Create()
        {
            int[] intArr = { 5, 7, 8, 9, 10 };

        }
        public void Delete()
        {
            throw new NotImplementedException();
        }
        public void Search()
        {
            throw new NotImplementedException();
        }
        public void Update()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return the array indexs of the sum of elements by target
        /// //Worst Runtime O(N*N)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] output = new int[2];

            if (nums == null || nums.Length < 2)
                throw new Exception("Invalid Array.Please provide valid Array");

            for (int a = 0; a < nums.Length; a++)
            {
                for (int b = a + 1; b <= nums.Length - 1; b++)
                {
                    if (nums[a] + nums[b] == target)
                    {
                        output[0] = a;
                        output[1] = b;
                    }
                }
            }
            return output;
        }
        public static bool IsDuplicatesFound(int[] numbs)
        {
            bool result = false;
            if (numbs == null || numbs.Length < 1)
                throw new Exception("Provide valid array");
            for (int a = 0; a < numbs.Length; a++)
            {
                for (int b = a + 1; b <= numbs.Length - 1; b++)
                {
                    if (numbs[a] == numbs[b])
                        result = true;
                }
            }
            return result;
        }
        public static int MinValue(int[] numbers)
        {
            return 1;
        }
        public static int MaxValue(int[] numbers)
        {
            return 1;
        }
        public int[] SortArray(int[] numbers)
        {
            return new int[3];

        }
    }
}
