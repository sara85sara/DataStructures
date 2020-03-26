using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace DataStructures
{
    public class StackWork
    {
        Stack<int> stk = null;

        public StackWork()
        {
            stk = new Stack<int>();

            stk.Push(100000000);
            stk.Push(100000000);
            stk.Push(10000000);
            stk.Push(10000000);
            stk.Push(1000000);
            stk.Push(100000);
            stk.Push(10000);
            stk.Push(1000);
            stk.Push(100);
            stk.Push(10);
            stk.Push(1);
           

        }
        public void ShowStackElements()
        {
            foreach (int item in stk)
            {
                Console.WriteLine(item);
            }
        }
        public void MinElementInStock(Stack<int> stck)
        {
            int minElement = (int)stck.Peek();// top element
            foreach (int item in stck)
            {
                if (item < minElement)
                    minElement = item;
            }
            Console.WriteLine("Min Element in Stack {0}", minElement);

        }
        public void MaxElementInStock()
        {
            int maxElement = (int)stk.Peek();// top element
            foreach (int item in stk)
            {
                if (item > maxElement)
                    maxElement = item;
            }
            Console.WriteLine("Max Element in Stack {0}", maxElement);

        }
        public void Add(int input)
        {
            stk.Push(input);
        }
        public void Remove()
        {
            stk.Pop();
        }
        public void Look()
        {
            stk.Peek();
        }


    }
}
