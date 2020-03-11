using System;
using System.Collections;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(PairSumSequence(3));
            Console.ReadLine();

            Stack objStack = new Stack();
            objStack.Push(100000);
            objStack.Push(10000);
            objStack.Push(1000);
            objStack.Push(100);
            objStack.Push(10);
            objStack.Push(1);

            //Iterate stack;
            foreach (int item in objStack)
            {
                Console.WriteLine(item);
            }
            //Top Element
            int topElement = (int)objStack.Peek();
            Console.WriteLine("Top Element in Stock: {0}", topElement);

            //To get MinElement
            int minElement = (int)objStack.Peek();
            foreach (int item in objStack)
            {
                if (item < minElement)
                    minElement = item;
            }
            Console.WriteLine("Min Element in Stock:{0}", minElement);

            //Add item in Stock
            objStack.Push(1000000);
            objStack.Push(10000000);

            //Remove item from Stack


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
