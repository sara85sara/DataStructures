using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfNth(5));
            Console.WriteLine(SumOfNthNumber(5));
            Console.ReadLine();
        }
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

    }
}
