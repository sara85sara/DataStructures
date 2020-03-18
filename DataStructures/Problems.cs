using System;
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

    }
}
