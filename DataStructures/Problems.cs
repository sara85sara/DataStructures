using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public static class Problems
    {
        //Sum of N number, O(N)
        public static int SumOfNth(int number)
        {
            int total = 0;
            for (int i = 0; i <= number; i++)
            {
                total += i;
            }
            return total;
        }
        //Sum of N number without varriable, O(1)
        public static int SumOfNthNumber(int number)
        {
            return (number * (number + 1) / 2);
        }

        static int PairSumSequence(int n)
        {
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                total += AddPairs(i, i + 1);
            }
            return total;
        }
        static int AddPairs(int a, int b)
        {
            return a + b;
        }

        public static int[] ReverseArray(int[] array)
        {
            //int[] dummy = { };
            //int idx = 0;
            //for (int i = array.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(array[i]);
            //    dummy[idx] = (int)array[i];
            //    idx++;
            //}
            //return dummy;
            for (int i = 0; i < array.Length / 2; i++)
            {
                int lastPosition = array.Length - i - 1;
                int temp = array[i];
                array[i] = array[lastPosition];
                array[lastPosition] = temp;
            }
            return array;

        }

        public static int[] ReverseArrayWithList()
        {
            int[] dummy = { };
            int idx = 0;
            List<int> lstInts = new List<int>(new int[] { 4, 5, 2, 1 });
           
            for (int i = lstInts.Count - 1; i > 0; i--)
            {
                dummy[idx] = lstInts[i];
                idx++;
            }
            return dummy;
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                throw new Exception("Please provide an array with more than 2 elements in it");
            //{ 8, 1, 2, 2, 3 })
            int[] result = new int[nums.Length];
            int idx = 0;
            Dictionary<int, int> ht = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                result[idx] = GetCounts(nums[i], nums);
                idx++;
            }
            return result;

        }
        public static int GetCounts(int idx, int[] aray)
        {
            int count = 0;
            for (int j = 0; j < aray.Length; j++)
            {
                if (aray[j] < idx) count++;
            }
            return count;
        }

    }
}
